using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls.Models;

namespace Controls
{
    public partial class ReportesUser : UserControl
    {
        string url;
        Course Course;
        Period period;
        Student student;
        public  Form Form { get; set; }
        public ReportesUser()
        {
            InitializeComponent();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (Course == null)
            {
                return;
            }
            if (rbtCursos.Checked)
            {
                url = $"{ConfigurationManager.AppSettings["base_url"]}/Report/GetFileStudent?courseid={Course.Id}";
                Process.Start("IExplore.exe", url);
            }
            else
            {
                Process.Start("IExplore.exe", url);

            }


        }

        private async void BtnCurso_Click(object sender, EventArgs e)
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
            var periods = await Utilities<Period>.Get();
            int id = Utilities<Period>.GetID(periods);
            period = periods.FirstOrDefault(x => x.Id == id);
            if (period == null)
            {
                return;

            }
            txtPeriodo.Text = period.Title; 

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private async  void btnEstudiante_Click(object sender, EventArgs e)
        {
            Utilities<Tuition>.Api = "api/Tuition";
            var tuitions = await Utilities<Tuition>.Get();
            int tuitionId = Utilities<Tuition>.GetID(tuitions.Where(x => x.CourseId  == Course.Id).ToList());
            var tuition = tuitions.FirstOrDefault(x => x.Id == tuitionId);
            if (tuition == null) { return; }
           student   = tuition.Student ;
            txtIdentificacion.Text = student.Identification;
            txtNombre.Text = student.CompleteName;
        }
    }
}
