using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  UserControls. Models;
namespace UserControls
{
    public partial class CursosUser : UserControl
    {
        string msg;
        Course course ;
        List<Course> courses ;
        public  Form Form {  get; set; }
        public CursosUser()
        {
            InitializeComponent();
        }
        async void NewCourse()
        {
            try
            {
                course = null;
                this.Cursor = Cursors.WaitCursor;
                courses = await Utilities<Course>.Get();
                dgvCurso.DataSource = courses;
                txtCodigo.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtCapacidadMax.Clear();
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private  void CursosUser_Load(object sender, EventArgs e)
        {
            Utilities<Course>.Api = "api/Course";
            NewCourse();            
        }

        private  void btnNuevo_Click(object sender, EventArgs e)
        {
            NewCourse();
        }

        private async  void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal.TryParse(txtCapacidadMax.Text, out decimal capacidadmax);
                if (course == null)
                {
                    course = new Course
                    {
                        Code = txtCodigo.Text,
                        Name = txtNombre.Text,
                        Description = txtDescripcion.Text,
                        Amount = capacidadmax,
                    };
                    msg = await Utilities<Course>.Post(course);
                }
                else
                {
                    course.Code = txtCodigo.Text;
                    course.Name = txtNombre.Text;
                    course.Description = txtDescripcion.Text;
                    course.Amount = capacidadmax;
                    msg = await Utilities<Course>.Put(course.Id, course);
                }
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message , "", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            finally
            {
                NewCourse();
            }
        }

        private void dgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex <0)
            {
                return;
            }
            int.TryParse(dgvCurso.Rows[e.RowIndex].Cells["id"].Value.ToString(), out int id);
           course = courses.Where(x => x.Id == id).FirstOrDefault();
            txtCodigo.Text = course.Code;
            txtNombre.Text = course.Name;
            txtDescripcion.Text = course.Description;
            txtCapacidadMax.Text = course.Amount.ToString ();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Utilities<string>.Api = "api/Course";
                if (course == null)
                {
                    return;
                }
                msg = await Utilities<string>.Delete(course.Id);
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                NewCourse();

            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close(); 
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
