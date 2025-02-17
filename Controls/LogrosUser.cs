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

namespace Controls 
{

    public partial class LogrosUser : UserControl
    {
        Achievement achievement;
        Period period;
        SchoolSubject SchoolSubject;
        List<Achievement>  achievements;
        Course Course;
        public Form Form { get; set; }
        public LogrosUser()
        {
            InitializeComponent();
        }
        async void NewAchievement()
        {
            try
            {
                achievement = null;
                period = null;
                SchoolSubject = null;
                Course=null;
                Utilities<Achievement>.Api = "api/Achievement";
                Cursor = Cursors.WaitCursor;
                achievements = await Utilities<Achievement>.Get();
                dgvLogros.DataSource = achievements.Select(x => new
                {
                    x.Id,
                    x.Code,
                    x.Title,
                    x.Description,
                    SchoolSubject = x.SchoolSubject.Reference,
                    Course=  x.Course.Reference ,
                    period=x.Period.Title 
                }).ToList();
                txtAsignatura.Clear();
                txtPeriodo.Clear();
                txtCurso.Clear();                txtCodigo.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LogrosUser_Load(object sender, EventArgs e)
        {
            NewAchievement();
        }

        private async void btnAsignatura_Click(object sender, EventArgs e)
        {

            Utilities<SchoolSubject>.Api = "api/SchoolSubject";
            List<SchoolSubject> schoolSubjects = await Utilities<SchoolSubject>.Get();
            int id = Utilities<SchoolSubject>.GetID(schoolSubjects);

            SchoolSubject = schoolSubjects.Where(x => x.Id == id).FirstOrDefault();
            if (SchoolSubject == null)
            {
                return;

            }
            txtAsignatura.Text = SchoolSubject.Reference;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NewAchievement();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SchoolSubject == null)
                {
                    return;
                }
                else if(Course ==null)
                {
                    return;
                }
                if(period == null)
                {
                    return;
                }
                Utilities<Achievement>.Api = "api/Achievement";
                if (achievement == null)
                {
                    achievement = new Achievement
                    {
                        Code = txtCodigo.Text,
                        Title = txtNombre.Text,
                        Description = txtDescripcion.Text,
                        SchoolSubjectId = SchoolSubject.Id,
                        CourseId=Course .Id ,
                       PeriodId=period.Id ,
                    };
                    await Utilities<Achievement>.Post(achievement);
                }
                else
                {
                    achievement.Code = txtCodigo.Text;
                    achievement.Title = txtNombre.Text;
                    achievement.Description = txtDescripcion.Text;
                    achievement.SchoolSubjectId = SchoolSubject.Id;
                    achievement.CourseId = Course.Id;
                    achievement.PeriodId = period.Id;
                    await Utilities<Achievement>.Put(achievement.Id, achievement);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                NewAchievement();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Utilities<Achievement>.Api = "api/Achievement";
                if (achievement == null)
                {
                    return;
                }
                await Utilities<Achievement>.Delete(achievement.Id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                NewAchievement();
            }
        }

        private void dgvLogros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <0)
            {
                return;
            }
            int.TryParse(dgvLogros.Rows[e.RowIndex].Cells["id"].Value.ToString(), out int id);
            achievement = achievements.Where(x => x.Id == id).FirstOrDefault();
            txtCodigo.Text = achievement.Code;
            txtNombre.Text = achievement.Title;
            txtDescripcion.Text = achievement.Description;
            Course = achievement.Course;
            period = achievement.Period;
            SchoolSubject = achievement.SchoolSubject;
            txtAsignatura.Text = SchoolSubject.Reference;
            txtPeriodo.Text = period.Title;
            txtCurso.Text = Course.Reference;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private async    void BtnCurso_Click(object sender, EventArgs e)
        {
            Utilities<Course>.Api = "api/Course";
            var courses = await Utilities<Course>.Get();
            int id = Utilities<Course>.GetID(courses);

            Course = courses.FirstOrDefault(x => x.Id == id);
            if (Course == null)
            {
                return;
            }
            txtCurso.Text = Course.Reference;
        }

        private async void btnPeriodo_Click(object sender, EventArgs e)
        {
            Utilities<Period>.Api = "api/Period";
            var periods =await Utilities<Period>.Get();
            int id =Utilities<Period>.GetID(periods);
            period = periods.FirstOrDefault(x => x.Id == id);
            if(period ==null)
            {
                return;

            }
            txtPeriodo.Text = period.Title;



        }
    }
}
