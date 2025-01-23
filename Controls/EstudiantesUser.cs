
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls.Models;

namespace Controls
{
    public partial class EstudiantesUser : UserControl
    {
         string[] arr = { "Id", "Name" };
        public Form Form {  get; set; }
        List<Student> students;
        Student student;
        List <IdentificationType > identities;
        List< Sex> sexes;
        public EstudiantesUser()
        {
            InitializeComponent();
        }
        async void newStudent()
        {
            student=null ;            
            Utilities<Student>.Api = "api/Students";
            students = await Utilities<Student>.Get();
            dgvEstudiante.DataSource = students.Select(x => new
            {
                x.Id,
                IdentificationType = x.IdentificationType.Name,
                x.Identification,
                x.CompleteName,
                x.BirthDate,
                x.Age,
                x.Address,
                Sex = x.Sex.Name,
                x.PhoneNumber,
                x.Email,
            //    status= x.Status.Name ,
            }).ToList();
            txtNumDoc .Clear ();
            txtPriNombre .Clear ();
            txtPriApellido .Clear ();
            txtFechaNacim .Value =DateTime .Now;
            txtDireccion .Clear (); 
            txtTelefono .Clear ();
            txtEmail .Clear ();
            txtUsuario .Clear ();
            txtPssword .Clear ();
            cboSexo.SelectedIndex = -1;
            cboTipoDoc .SelectedIndex = -1;
            txtNumDoc .Focus ();
        }
        private async void EstudiantesUser_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Utilities<IdentificationType>.Api = "api/Students/IdentificationTypes";
            identities = await Utilities<IdentificationType>.Get();
            Utilities<IdentificationType>.FillCombo(identities , arr, cboTipoDoc);
            Utilities<Sex >.Api = "api/Students/Sexes";
            sexes = await Utilities<Sex>.Get();
            Utilities<Sex >.FillCombo(sexes , arr,cboSexo );
            Cursor = Cursors.Default ;
            newStudent();

        }

       

        private async  void btnGuardar_Click(object sender, EventArgs e)
        {
            Utilities<Student>.Api = "api/Students";
            if (student == null)
            {
                student = new Student { 
                    IdentificationTypeId=int .Parse ( cboTipoDoc.SelectedValue.ToString ()),
                    Identification=txtNumDoc.Text,
                    FirstName =txtPriNombre.Text,
                    LastName =txtPriApellido.Text,
                    BirthDate =txtFechaNacim .Value ,
                    Address =txtDireccion .Text ,
                    PhoneNumber =txtTelefono .Text ,
                    Email =txtEmail .Text ,
                    SexId=int.Parse (cboSexo .SelectedValue .ToString ()),  
                  //  StatusId=1
                };
                await Utilities<Student>.Post(student);                
            }
            else
            {
                student .Identification = txtNumDoc.Text;
                student .Email = txtEmail.Text;
                student .Address = txtDireccion .Text;
                student .PhoneNumber = txtTelefono .Text;
                student .FirstName =txtPriNombre .Text;
                student .LastName =txtPriApellido .Text;
                student .BirthDate = txtFechaNacim .Value;
                student .IdentificationTypeId=int.Parse ( cboTipoDoc .SelectedValue.ToString ());
                student.Sex = sexes.FirstOrDefault(x => x.Id == int.Parse(cboSexo.SelectedValue.ToString()));
                student .IdentificationType =identities .FirstOrDefault(x => x.Id ==int.Parse(cboTipoDoc .SelectedValue.ToString()));
                student .SexId = int.Parse(cboSexo.SelectedValue.ToString());
                await Utilities<Student>.Put(student .Id , student);

            }
            newStudent ();
        }

        private void txtFechaNacim_ValueChanged(object sender, EventArgs e)
        {
       txtEdad .Text=     Math.Round((DateTime.Now - txtFechaNacim.Value ).TotalDays / 365).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form. Close();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            newStudent();


        }

        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) {
                return;
            }
          int.TryParse ( dgvEstudiante .Rows[e.RowIndex ].Cells["Id"].Value.ToString (),out int id);
            student =students .First (x => x.Id == id);
            txtNumDoc.Text =student .Identification ;
            txtPriNombre.Text =student .FirstName ;
            txtPriApellido.Text =student .LastName ;
            txtFechaNacim.Value = student .BirthDate ;
            txtDireccion.Text =student .Address ;
            txtTelefono.Text =student .PhoneNumber ;
            txtEmail.Text =student .Email ;
            txtUsuario.Clear();
            txtPssword.Clear();
            cboSexo.SelectedValue =student .SexId  ;
            cboTipoDoc.SelectedValue = student .IdentificationTypeId ;

        }

        private async  void btnEliminar_Click(object sender, EventArgs e)
        {
            if(student ==null) { return; }
            Utilities<string >.Api = "api/Students";
        await     Utilities<string>.Delete(student.Id);

        }

        private void btnImagenes_Click(object sender, EventArgs e)
        {
            int.TryParse(dgvEstudiante .CurrentRow != null ? dgvEstudiante .CurrentRow.Cells["id"].Value.ToString() : "0", out int id);
            var current =students .Where(x => x.Id == id).FirstOrDefault();
            if (current == null)
            {
                MessageBox.Show("Escoja una asignatura", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmSecundario frmSecundario = new frmSecundario();
          ImagenesUser  imagenes  = new ImagenesUser 
            {
                Form = frmSecundario,
             Student  = current,
                Dock = DockStyle.Fill,
            };
            frmSecundario.UserControl = imagenes ;
            frmSecundario.ShowDialog();
            newStudent();

        }
    }
}
