using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.Models;

namespace  UserControls

{
    public partial class AsignaturaUser : UserControl
    {
        public Form Form {  get; set; }
        SchoolSubject subject;
        List<SchoolSubject> schoolSubjects;
        string msg;
        public AsignaturaUser()
        {
            InitializeComponent();
        }

        private void AsignaturaUser_Load(object sender, EventArgs e)
        {
            newSchool();
        }
        async void newSchool()
        {
            try
            { 
                subject = null;
                this.Cursor = Cursors.WaitCursor;
                Utilities<SchoolSubject>.Api = "api/SchoolSubject";
                schoolSubjects=new List<SchoolSubject>();
                schoolSubjects = await Utilities <SchoolSubject >.Get();                
                txtCodigo .Clear();
                txtNombre .Clear();
                txtDescripcion .Clear();
                txtCantidadHoraria .Clear();
                dgAsignaturas.DataSource = schoolSubjects.Select(y => new
                {                   
                    y.Id,
                    y.Name,
                    y.Description,
                    y.Code,
                    y.HourAmount,
                }).ToList();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                txtCodigo.Focus();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            newSchool();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Utilities<SchoolSubject>.Api = "api/SchoolSubject";
                decimal.TryParse(txtCantidadHoraria.Text, out decimal houramunt);
                if (subject == null)
                {
                    subject = new SchoolSubject
                    {
                        Code = txtCodigo.Text,
                        Name = txtNombre.Text,
                        Description = txtDescripcion.Text,
                        HourAmount = houramunt,
                    };
                    msg = await Utilities<SchoolSubject>.Post(subject);
                }
                else
                {
                    subject.Code = txtCodigo.Text;
                    subject.Name = txtNombre.Text;
                    subject.Description = txtDescripcion.Text;
                    subject.HourAmount = houramunt;
                    msg = await Utilities<SchoolSubject>.Put(subject.Id, subject);
                }
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                newSchool();
            }
        }
        private async  void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (subject == null)
                {
                    return ;
                }
                Utilities<string>.Api = "api/SchoolSubject";
                msg =await       Utilities<string > .Delete (subject.Id );
                MessageBox.Show(msg , "", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                newSchool();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private void dgAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
             int.TryParse(dgAsignaturas.Rows[e.RowIndex].Cells["id"].Value.ToString(), out int id);
            subject = schoolSubjects.Where(x => x.Id == id).FirstOrDefault();
            txtCodigo.Text = subject.Code;
            txtNombre.Text = subject.Name;
            txtDescripcion.Text = subject.Description;
            txtCantidadHoraria.Text = subject.HourAmount.ToString();
        }

        private void btnAsignarCursos_Click(object sender, EventArgs e)
        {
            int.TryParse(dgAsignaturas.CurrentRow!=null? dgAsignaturas.CurrentRow .Cells["id"].Value.ToString():"0", out int id);
            var current = schoolSubjects.Where(x => x.Id == id).FirstOrDefault();
            if (current==null )
            {
                MessageBox.Show("Escoja una asignatura", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmSecundario frmSecundario= new frmSecundario ();
            AsignaCursoUser asignaCursoUser = new AsignaCursoUser 
            {  
                Form = frmSecundario,
                SchoolSubject  = current ,
                Dock = DockStyle.Fill,
            };
            frmSecundario .UserControl = asignaCursoUser; 
            frmSecundario.ShowDialog();
            newSchool();
        }
    }
}
