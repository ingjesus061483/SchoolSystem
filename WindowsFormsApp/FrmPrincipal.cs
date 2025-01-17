using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls;
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
            Utilities<string>.Cerrar("Salir de aplicacion", e);

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

            };
            addControl(estudiantesUser );
        }
    }
}
