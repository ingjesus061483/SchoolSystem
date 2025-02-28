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
    public partial class NotasControl : UserControl
    {
        public Form Form { get; set; }
        public NotasControl()
        {
            InitializeComponent();
        }


        private void toolStripButtonLogro_Click(object sender, EventArgs e)
        {
            LogrosUser logrosUser = new LogrosUser
            {
                Dock = DockStyle.Fill,
                Form = Form ,
            };
          Utilities<LogrosUser> .  AddControl(pnlNotas, logrosUser);
        }



        private void toolStripButtonCalificaciones_Click(object sender, EventArgs e)
        {
            CalificacionesUser calificacionesUser = new CalificacionesUser
            {
                Dock = DockStyle.Fill,
                Form =Form ,
            };
          Utilities<CalificacionesUser> .  AddControl(pnlNotas, calificacionesUser);
        }

    }
}
