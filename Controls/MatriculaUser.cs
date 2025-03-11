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
    public partial class MatriculaUser : UserControl
    {
        List<Tuition> Tuitions;
        public Form Form { get; set; }
        Course Course;
        string[] arr = { "Id", "Name" };
        Student student;
        Tuition Tuition {  get; set; }
        public MatriculaUser()
        {
            InitializeComponent();
        }
        List <MonthlyPayment > GetMonthlyPayments()
        {
            DateTime date = txtFechaInicioMatricula.Value;  
            List<MonthlyPayment> monthlyPayments = new List<MonthlyPayment>();
            for (int i = 0; i <= int.Parse( txtDuracion.Text) - 1; i++)
            {
                MonthlyPayment monthlyPayment;
                int day = (date.AddDays(30)- date ).Days;
                if (i == 0 )
                {
                    monthlyPayment = new MonthlyPayment
                    {
                        Code =txtCodigo .Text +(i+1).ToString (),
                        Since = date,
                        Untill = date.AddMonths(1),
                        IsConfirmed = false,
                        Value = date.Month == txtfechaMatricula.Value.Month? decimal.Parse(txtValorMensualidad.Text)+decimal .Parse(txtValorMatricula.Text): decimal.Parse(txtValorMatricula.Text)
                    };
                }
                else
                {
                    monthlyPayment = new MonthlyPayment
                    {
                        Code = txtCodigo.Text +  (i + 1).ToString(),
                        Since = date,
                        Untill = date.AddMonths(1),
                        IsConfirmed = false,
                        Value = decimal.Parse(txtValorMensualidad.Text)
                    };
                }
                date = date.AddMonths(1);
                monthlyPayments.Add(monthlyPayment);             
            }
            return monthlyPayments;
         }
        async  void newTuition()
        {
            Tuition = null;
            Utilities<Tuition>.Api = "api/Tuition";
            Cursor = Cursors.WaitCursor;
            Tuitions= await Utilities<Tuition>.Get();
            Cursor  = Cursors.Default;
            dgvmatricula .DataSource = Tuitions.Select (x=>new 
            {
                x.Id,
                Student=x.Student .Identification +" "+ x.Student.CompleteName,
                WorkingDay=x.WorkingDay.Name,
                Course=x.Course.Reference ,
                x.Code,
                x.Date,
                x.FirstDate,
                x.LastDate,
                x.Duration ,
                x.TutionValue,
                x.MonthValue,
                status=x.Status.Name ,
            }).ToList ();
          txtCurso .Clear ();
            txtIdentificacion .Clear ();
            txtNombre .Clear ();
            txtFechaFinMatricula.Value =DateTime.Now;
            txtFechaInicioMatricula.Value =DateTime.Now;
            txtfechaMatricula.Value = DateTime.Now;
            txtValorMensualidad .Clear ();
            txtValorMatricula .Clear ();    
            txtCodigo .Clear ();
            txtCodigo .Focus ();
            Course = null;
            student=null;
            cmbJornada .SelectedIndex = -1;

        }
        private async  void MatriculaUser_Load(object sender, EventArgs e)        
        {
            newTuition ();
            Utilities<WorkingDay>.Api = "api/Tuition/WorkingDay";
            Utilities <WorkingDay >.FillCombo(await  Utilities<WorkingDay>.Get(),arr,cmbJornada );            
        }

        private async  void BtnCurso_Click(object sender, EventArgs e)
        {
            Utilities<Course>.Api = "api/Course";
            var courses=await  Utilities <Course>.Get();
            int id = Utilities<Course>.GetID(courses,"cursos");

            Course = courses .FirstOrDefault(x => x.Id == id);
            if (Course == null)
            {
                return;
            }
            txtCurso.Text = Course.Reference;
        }

        private async  void btnEstudiante_Click(object sender, EventArgs e)
        {
            Utilities<Student>.Api = "api/Students";
            var students=await Utilities<Student>.Get();
            int id = Utilities<Student>.GetID(students,"estudiante");

            student = students .FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return;
            }
        
            if(Tuitions.Where (x=>x.StudentId == student.Id && /*x.CourseId==Course.Id&&*/ (x.StatusId == 1 || x. StatusId == 2)).Any() )
            {
                MessageBox.Show("El estudiante ya se encuentra registrado en este curso","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtNombre .Text = student .CompleteName ;
            txtIdentificacion .Text =student .Identification ;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            newTuition();
        }

        private void txtFechaFinMatricula_ValueChanged(object sender, EventArgs e)
        {
          double duracion=  ( txtFechaFinMatricula.Value- txtFechaInicioMatricula.Value).Days / 30;
            txtDuracion .Text =duracion.ToString();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Utilities<Tuition>.Api = "api/Tuition";
            if (Tuition == null)
            {
                Tuition = new Tuition
                {
                    Code = txtCodigo.Text,
                    StudentId = student.Id,
                    WorkingDayId = int.Parse(cmbJornada.SelectedValue.ToString()),
                    FirstDate = txtFechaInicioMatricula.Value,
                    Date=txtfechaMatricula.Value,
                    LastDate = txtFechaFinMatricula.Value,
                    CourseId = Course.Id,
                    MonthValue = decimal.Parse(txtValorMensualidad.Text),
                    TutionValue = decimal.Parse(txtValorMatricula.Text),
                    StatusId = 1, 
                    MonthlyPayments=GetMonthlyPayments()
                    
                };
                await Utilities<Tuition>.Post(Tuition);
                Tuitions = await Utilities<Tuition>.Get();
                Utilities<Concept >.Api = "api/Concept";
                List <Concept > concepts =await  Utilities<Concept>.Get();
                Utilities<Strangeness>.Api = "api/Strangeness";
                Strangeness  Strangeness = new Strangeness
                {
                    Code = DateTime.Now.ToOADate().ToString(),
                    ConceptId = concepts .FirstOrDefault(x=>x.Code== "001").Id ,
                    TuitionId = Tuitions.Last().Id,
                    Date = DateTime .Now ,
                    Detail = $"El estudiante identificado {student.Identification} esta cursando {Course .Name }"
                };
                await Utilities<Strangeness>.Post(Strangeness);
            }
            else
            {
                Tuition.Code = txtCodigo.Text;
                Tuition.StudentId = student.Id;
                Tuition.Date = txtfechaMatricula.Value;
                Tuition.WorkingDayId = int.Parse(cmbJornada.SelectedValue.ToString());
                Tuition.FirstDate = txtFechaInicioMatricula.Value;
                Tuition.LastDate = txtFechaFinMatricula.Value;
                Tuition.CourseId = Course.Id;
                Tuition.MonthValue = decimal.Parse(txtValorMensualidad.Text);
                Tuition.TutionValue = decimal.Parse(txtValorMatricula.Text);
                await Utilities<Tuition>.Put(Tuition.Id, Tuition);
            }
            newTuition();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form .Close();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            Utilities<Tuition>.Api = "api/Tuition";

            if (Tuition == null)
                { return; }
            await Utilities<Tuition>.Delete (Tuition .Id);

        }

        private void dgvmatricula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int.TryParse(dgvmatricula.Rows[e.RowIndex].Cells["id"].Value.ToString(), out int id);
           Tuition = Tuitions.FirstOrDefault(x=>x.Id == id);
            txtCodigo.Text = Tuition.Code;
            txtIdentificacion.Text = Tuition.Student.Identification;
            cmbJornada.SelectedValue = Tuition.WorkingDayId;
            txtfechaMatricula.Value = Tuition.Date;
            txtFechaInicioMatricula.Value = Tuition.FirstDate;
            txtFechaFinMatricula.Value = Tuition.LastDate;
            txtCurso.Text = Tuition.Course.Reference;
            txtValorMensualidad.Text = Tuition.MonthValue .ToString();
               txtValorMatricula.Text = Tuition.TutionValue.ToString();
            Course =Tuition.Course;
            student = Tuition.Student;
            if (e.ColumnIndex == 0)
            {
                frmSecundario frmSecundario= new frmSecundario();
                NovedadesUser novedadesUser = new NovedadesUser 
                { 
                    Form = frmSecundario,
                    Tuition =Tuition ,
                    Dock=DockStyle.Fill
                };

                frmSecundario.UserControl=novedadesUser ;
                frmSecundario.ShowDialog();
                newTuition();

            }
        }
    }
}
