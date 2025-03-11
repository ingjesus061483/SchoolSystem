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
    public partial class FacturacionControl : UserControl
    {
        public Form Form;
        string name;
        public FacturacionControl()
        {
            InitializeComponent();
        }

        private void toolStripMensualidad_Click(object sender, EventArgs e)
        {
            Form.Text  = name+" - Mensualidad" ;
            MensualidadControl mensualidadControl    = new MensualidadControl
            {
                Dock = DockStyle.Fill,
                Form = Form,
            };
            Utilities<MensualidadControl>.AddControl(panelFacturacion, mensualidadControl);
        }

        private void FacturacionControl_Load(object sender, EventArgs e)
        {
            name = Form.Text;
        }
    }
}
