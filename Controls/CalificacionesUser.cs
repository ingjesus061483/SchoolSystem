using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Controls 
{ 
    public partial class CalificacionesUser : UserControl
    {
        Period Period;
        Student student;
        Course course;
        Achievement achievement;
        Qualification qualification;
        List<Qualification> Qualifications;
        public Form Form { get; set; }
        public CalificacionesUser()
        {
            InitializeComponent();
        }
        async void NewQualification()
        {
            try
            {
                Utilities<Qualification>.Api = "api/Qualification";
                Cursor = Cursors.WaitCursor;
                Qualifications = await Utilities<Qualification>.Get();
                dgvEstudiante.DataSource = Qualifications.Select(x => new
                {
                    x.Id,
                    Achievement = x.Achievement.Title,
                    student = x.Student.Identification + " " + x.Student.CompleteName,
                    x.DateTime,
                    reference = x.Code + " - " + x.Title,
                    x.Note,
                    x.Detail
                }).ToList();
                Period = null;
                student = null;
                course = null;
                achievement = null;
                qualification = null;
                txtCodigo.Clear();
                txtConcepto.Clear();
                txtFecha.Value = DateTime.Now;
                txtNota.Clear();
                txtLogros.Clear();
                txtPeriodo.Clear();
                txtEstudiante.Clear();
                txtIdentificacion.Clear();
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex .Message , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void CalificacionesUser_Load(object sender, EventArgs e)
        {
            NewQualification();


        }

        private async void btnPeriodo_Click(object sender, EventArgs e)
        {
            Utilities<Period>.Api = "api/Period";
            var periods=await Utilities<Period>.Get();
           var id= Utilities<Period>.GetID(periods);
            Period =periods .FirstOrDefault(x=>x.Id==id);
            if (Period == null){return;}
            txtPeriodo.Text = Period.Title;
            txtFecha.MinDate = (DateTime)Period.Since;
            txtFecha.MaxDate = (DateTime)Period.Untill;
        }

        private async void btnEstudiante_Click(object sender, EventArgs e)
        {
            Utilities<Student>.Api = "api/Students";
           var students=await Utilities<Student>.Get();
            int id = Utilities<Student>.GetID(students);
            student = students .FirstOrDefault(x=>x.Id==id);
            if (student == null) { return; }
            txtIdentificacion.Text = student.Identification;
            txtEstudiante.Text = student.CompleteName;
            Utilities<Tuition>.Api = "api/Tuition";
            var tuitions =await Utilities<Tuition>.Get();
            int tuitionId = Utilities<Tuition>.GetID(tuitions.Where (x=>x.StatusId==student .Id).ToList());
            var tuition = tuitions.FirstOrDefault(x => x.Id == tuitionId);
            if (tuition == null) { return; }
            course = tuition.Course;
        }

        private async void btnLogros_Click(object sender, EventArgs e)
        {
            if (course == null) { return; }                
            Utilities<Achievement>.Api = "api/Achievement";
            var achievements = await Utilities<Achievement>.Get();
            int id =Utilities<Achievement >.GetID(achievements.Where (x=>x.CourseId ==course.Id).ToList());
            achievement = achievements.FirstOrDefault(x => x.Id == id);
            if (achievement == null) { return; }
            txtLogros.Text = achievement.Title;
            MessageBox.Show(achievement.Description, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Utilities<Qualification>.Api = "api/Qualification";
                if (qualification == null)
                {
                    qualification = new Qualification
                    {
                        Code = txtCodigo.Text,
                        AchievementID = achievement.Id,
                        DateTime = txtFecha.Value,
                        Detail = txtObservacion.Text,
                        Note = decimal.Parse(txtNota.Text),
                        StudentId = student.Id,
                        Title = txtConcepto.Text,

                    };
                    await Utilities<Qualification>.Post(qualification);
                }
                else
                {
                    qualification.Code = txtCodigo.Text;
                    qualification.AchievementID = achievement.Id;
                    qualification.DateTime = txtFecha.Value;
                    qualification.Detail = txtObservacion.Text;
                    qualification.Note = decimal.Parse(txtNota.Text);
                    qualification.StudentId = student.Id;
                    qualification.Title = txtConcepto.Text;
                    await Utilities<Qualification>.Put(qualification.Id, qualification);
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                NewQualification();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            Utilities<Qualification>.Api = "api/Qualification";
            if (qualification == null)
            {
                return;
            }
            await Utilities<Qualification>.Delete(qualification.Id);
            NewQualification();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NewQualification();
        }
    }
}
