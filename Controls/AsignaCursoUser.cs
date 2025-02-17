using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls.Models;

namespace Controls
{
    public partial class AsignaCursoUser : UserControl
    {      
        public Form Form {  get; set; }
        Course course;
        Teacher Teacher;
        CourseSubject subject;
        List<CourseSubject> courseSubjects;
        public SchoolSubject SchoolSubject  {  get; set; }
        string msg;
        public AsignaCursoUser()
        {
            InitializeComponent();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
 //           Utilities<string>.Cerrar("Salir de asigna curso", e);       
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form .Close ();
        }

        private void AsignaCursoUser_Load(object sender, EventArgs e)
        {
            Form.FormClosing += Form_FormClosing;
            courseSubjects =SchoolSubject .CourseSubjects ;
            dgAsignaturas .DataSource=courseSubjects .Select(x=>new 
            { 
                x.Id,
               Curso= x.Course.Reference  ,
               Asignatura=x.SchoolSubject.Reference ,
               Profesor=x.Teacher.Identification+" - "+ x.Teacher.CompleteName 
            }).ToList();
            txtAsignatura .Text =SchoolSubject .Reference;
        }

        private async void  BtnCurso_Click(object sender, EventArgs e)
        {
            Utilities<Course>.Api = "api/Course";      
            List<Course> courses = await Utilities<Course>.Get();
            int id = Utilities<Course >.GetID(courses);

            course = courses .FirstOrDefault ( x=>x.Id ==id );
            if (course == null)
            {
             return ;
            }
            txtCurso.Text = course.Reference;
        }

        private void dgAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <0)
                return ;
            int.TryParse(dgAsignaturas.Rows[e.RowIndex].Cells["id"].Value.ToString (), out int id);
            subject =courseSubjects .FirstOrDefault ( x=>x.Id ==id);
            txtAsignatura .Text =subject .SchoolSubject .Reference ;
            txtCurso .Text=subject .Course .Reference ;
            course =subject .Course ;
            Teacher = subject.Teacher;
            txtIdentificacion.Text = Teacher.Identification;
            txtNombre.Text = Teacher.CompleteName;
        }

        private async  void btnGuardar_Click(object sender, EventArgs e)
        {
            Utilities <CourseSubject >.Api= "api/CourseSubject";
            try
            {
                if(course ==null)
                {
                    return; 
                }
                if (subject == null)
                {
                    subject = new CourseSubject
                    {
                        SchoolSubjectId =SchoolSubject .Id,
                        CourseId =course.Id ,
                        TeacherId=Teacher.Id ,
                    };
                   msg= await  Utilities <CourseSubject >.Post(subject ) ;

                }
                else
                {
                    subject.SchoolSubjectId = SchoolSubject.Id;
                    subject.CourseId = course.Id;
                    subject.TeacherId = Teacher.Id;
                    msg = await Utilities<CourseSubject>.Put (subject.Id , subject);
                }
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message , "", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            finally 
            {
                Form.Close();
            }
        }

        private async  void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (subject == null)
                {
                    return;
                }
                Utilities<string>.Api = "api/CourseSubject";
                msg = await Utilities<string>.Delete(subject.Id);
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Form.Close();
            }
        }

        private async void btnProfesor_Click(object sender, EventArgs e)
        {
            Utilities<Teacher>.Api = "api/Teacher"; 
            var teachers = await Utilities<Teacher>.Get();
            int id = Utilities<Teacher>.GetID(teachers );
            Teacher = teachers.FirstOrDefault(x => x.Id == id );
            if (teachers == null)
            {
                return;
            }
            txtIdentificacion .Text = Teacher.Identification;
            txtNombre.Text = Teacher.CompleteName;


        }
    }
}
