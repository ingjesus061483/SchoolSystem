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
    public partial class AdmisionesControl : UserControl
    {
        public Form Form { get; set; }
        public AdmisionesControl()
        {
            InitializeComponent();
        }


        private void toolStripStudent_Click(object sender, EventArgs e)
        {
            EstudiantesUser estudiantesUser = new EstudiantesUser
            {
                Dock = DockStyle.Fill,
                Form = Form,
            };
       Utilities <EstudiantesUser>.AddControl(panelConfiguration, estudiantesUser);
        }

        private void toolStripMatricula_Click(object sender, EventArgs e)
        {
            MatriculaUser matriculaUser = new MatriculaUser
            {
                Form = Form ,
                Dock = DockStyle.Fill,
            };
           Utilities <MatriculaUser >.AddControl(panelConfiguration, matriculaUser);
        }

        private void toolStripConcepto_Click(object sender, EventArgs e)
        {
            ConceptosUser conceptoUser = new ConceptosUser
            {
                Form = Form ,
                Dock = DockStyle.Fill
            };
         Utilities <ConceptosUser>.AddControl(panelConfiguration , conceptoUser);
        }

        private void toolStripButtonAcudiente_Click(object sender, EventArgs e)
        {
            AcudienteUser acudienteUser = new AcudienteUser
            {
                Form = Form,
                Dock = DockStyle.Fill,
            };
            Utilities < AcudienteUser>.AddControl(panelConfiguration, acudienteUser);

        }

    }
}
