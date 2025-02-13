using Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            toolStripButtonCourse.PerformClick();
        }
        private void toolStripButtonCourse_Click(object sender, EventArgs e)
        {
            CursosUser cursosUser = new CursosUser 
            {
                Dock = DockStyle.Fill ,
                Form =this,
            };
            addControl (cursosUser);
        }
        void addControl(UserControl control)
        {
            pnlbody.Controls.Clear();
            pnlbody.Controls.Add(control );
        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utilities<string>.CloseForm("Salir de aplicacion", e);
        }

        private void toolStripButtonSchoolSubject_Click(object sender, EventArgs e)
        {
            AsignaturaUser asignaturaUser = new AsignaturaUser
            {
                Dock = DockStyle.Fill,
                Form = this,
            };
            addControl(asignaturaUser);

        }

        private void toolStripStudent_Click(object sender, EventArgs e)
        {
            EstudiantesUser estudiantesUser = new EstudiantesUser
            {
                Dock = DockStyle.Fill,
                Form =this,
            };
            addControl(estudiantesUser );
        }

        private void toolStripMatricula_Click(object sender, EventArgs e)
        {
            MatriculaUser matriculaUser = new MatriculaUser
            {
                Form = this,
                Dock = DockStyle.Fill,
            };
            addControl(matriculaUser);
        }

        private void toolStripConcepto_Click(object sender, EventArgs e)
        {
            ConceptosUser conceptoUser = new ConceptosUser
            {
                Form = this,
                Dock = DockStyle.Fill
            };
            addControl(conceptoUser);
        }

        private void toolStripButtonAcudiente_Click(object sender, EventArgs e)
        {
            AcudienteUser acudienteUser = new AcudienteUser 
            {
                Form = this,
                Dock = DockStyle.Fill,
            };
            addControl(acudienteUser);

        }

        private void toolStripTeacher_Click(object sender, EventArgs e)
        {
            ProfesorUser ProfesorUser  = new ProfesorUser
            {
                Dock = DockStyle.Fill,
                Form = this,
            };
            addControl(ProfesorUser);
        }
    }
}
