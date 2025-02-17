using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Controls
{
    public partial class ProfesorUser : UserControl
    {
        List<Teacher> teachers;
        string[] arr = { "Id", "Name" };
        Teacher teacher;
        public Form Form { get; set; }
        public ProfesorUser()
        {
            InitializeComponent();
        }
        async  void  NewTeacher()
        {
            Utilities<Teacher>.Api = "api/Teacher";
            teachers = await Utilities<Teacher>.Get();
            teacher = null;
            txtNumDoc.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtFechaNacim.Value = DateTime.Now;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();
            cboSexo.SelectedIndex = -1;
            cboTipoDoc.SelectedIndex = -1;
            txtNumDoc.Focus();
            dgvUsuario.DataSource = teachers.Select(x => new
            {
                x.Id,
                TipoIdentificacion = x.IdentificationType.Name,
                Identificacion = x.Identification,
                NombreCompleto = x.CompleteName,
                FechaNacimiento = x.BirthDate,
                Edad = x.Age,
                Direccion = x.Address,
                Sexo = x.Sex.Name,
                Telefono = x.PhoneNumber,
                x.Email,
            }).ToList();
        }
        private async void ProfesorUser_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                NewTeacher();
                Utilities<IdentificationType>.Api = "api/Students/IdentificationTypes";
                var identities = await Utilities<IdentificationType>.Get();
                Utilities<IdentificationType>.FillCombo(identities, arr, cboTipoDoc);
                Utilities<Sex>.Api = "api/Students/Sexes";
                var sexes = await Utilities<Sex>.Get();
                Utilities<Sex >.FillCombo(sexes, arr, cboSexo);             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NewTeacher();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Utilities<Teacher>.Api = "api/Teacher";
            if(teacher==null)
            {
                teacher = new Teacher
                {
                    FirstName = txtNombre.Text,
                    Identification = txtNumDoc.Text,
                    LastName = txtApellido.Text,
                    BirthDate = txtFechaNacim.Value,
                    Address = txtDireccion.Text,
                    Email = txtEmail.Text,
                    PhoneNumber = txtTelefono.Text,
                    IdentificationTypeId =int .Parse(  cboTipoDoc.SelectedValue.ToString()),
                    SexId=int .Parse (cboSexo .SelectedValue .ToString()),                     
                };
                await Utilities<Teacher>.Post(teacher);
            }
            else
            {
                teacher.FirstName = txtNombre.Text;
                teacher.Identification = txtNumDoc.Text;
                teacher.LastName = txtApellido.Text;
                teacher.BirthDate = txtFechaNacim.Value;
                teacher.Address = txtDireccion.Text;
                teacher.Email = txtEmail.Text;
                teacher.PhoneNumber = txtTelefono.Text;
                teacher.IdentificationTypeId = int.Parse(cboTipoDoc.SelectedValue.ToString());
                teacher.SexId = int.Parse(cboSexo.SelectedValue.ToString());
                await Utilities<Teacher>.Put(teacher .Id  , teacher);
            }
            NewTeacher();
        }

        private async  void btnEliminar_Click(object sender, EventArgs e)
        {
            Utilities<Teacher>.Api = "api/Teacher";
            if (teacher ==null)
            {
                return;
            }
            await Utilities<Teacher>.Delete(teacher.Id);
            NewTeacher();
        }

        private void txtFechaNacim_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = Math.Round((DateTime.Now - txtFechaNacim.Value).TotalDays / 365).ToString();

        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <0)
            {
                return;
            }
            int.TryParse(dgvUsuario.Rows[e.RowIndex].Cells["id"].Value.ToString(),out int id);
            teacher = teachers.Where(x => x.Id == id).FirstOrDefault();            
            txtNumDoc.Text =teacher.Identification ;
            txtNombre.Text =teacher.FirstName ;
            txtApellido.Text=teacher .LastName ;
            txtFechaNacim.Value =teacher .BirthDate ;
            txtDireccion.Text =teacher .Address;
            txtTelefono.Text =teacher .PhoneNumber ;
            txtEmail.Text =teacher .Email ;
            txtUsuario.Clear();
            txtPassword.Clear();
            cboSexo.SelectedValue = teacher.SexId;
            cboTipoDoc.SelectedValue = teacher .IdentificationTypeId ;

        }

        private void btnImagenes_Click(object sender, EventArgs e)
        {
            int.TryParse(dgvUsuario  .CurrentRow != null ? dgvUsuario.CurrentRow.Cells["id"].Value.ToString() : "0", out int id);
            var current = teachers.Where(x => x.Id == id).FirstOrDefault();
            if (current == null)
            {
                MessageBox.Show("Escoja un profesor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmSecundario frmSecundario = new frmSecundario();
            ImagenesUser imagenes = new ImagenesUser
            {
                Form = frmSecundario,
                Teacher = current,
                Dock = DockStyle.Fill,
            };
            frmSecundario.UserControl = imagenes;
            frmSecundario.ShowDialog();
           NewTeacher ();
        }
    }
}
