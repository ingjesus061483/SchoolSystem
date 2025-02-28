using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls.Menu
{
    public partial class ConfiguracionControl : UserControl
    {
        public Form Form { get; set; }
        public ConfiguracionControl()
        {
            InitializeComponent();
        }

        private void toolStripButtonCourse_Click(object sender, EventArgs e)
        {
            CursosUser cursosUser = new CursosUser
            {
                Dock = DockStyle.Fill,
                Form = Form,
            };
            Utilities<CursosUser>.   AddControl(panelConfiguration, cursosUser);
        }

        private void toolStripButtonSchoolSubject_Click(object sender, EventArgs e)
        {
            AsignaturaUser asignaturaUser = new AsignaturaUser
            {
                Dock = DockStyle.Fill,
                Form = Form ,
            };
           Utilities <AsignaturaUser> .AddControl(panelConfiguration, asignaturaUser);

        }

        private void toolStripTeacher_Click(object sender, EventArgs e)
        {
            ProfesorUser ProfesorUser = new ProfesorUser
            {
                Dock = DockStyle.Fill,
                Form = Form ,
            };
            Utilities<ProfesorUser>.AddControl(panelConfiguration, ProfesorUser);
        }

        private void toolStripButtonPeriodo_Click(object sender, EventArgs e)
        {
            PeriodoUser periodoUser = new PeriodoUser
            {
                Dock = DockStyle.Fill,
                Form =Form ,
            };
        Utilities <PeriodoUser>.    AddControl(panelConfiguration, periodoUser);
        }
    }
}
