using Controls;
using System;
using Controls.Menu;
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

      

       

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmSecundario frmSecundario = new frmSecundario();
            ReportesUser reportesUser = new ReportesUser
            {
                Form = frmSecundario,
                Dock = DockStyle.Fill
            };
            frmSecundario.UserControl = reportesUser;
            frmSecundario.ShowDialog();
       
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
           ConfiguracionControl configuracionControl = new ConfiguracionControl
           {
                Dock = DockStyle.Fill,
                Form = this,
            };
            Utilities<ConfiguracionControl>.AddControl(pnlbody,configuracionControl   );
        }

        private void btnAdmisiones_Click(object sender, EventArgs e)
        {
            AdmisionesControl admisionesControl = new AdmisionesControl
            {
                Dock = DockStyle.Fill,
                Form = this,
            };
            Utilities<AdmisionesControl>.AddControl(pnlbody, admisionesControl);


    }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            NotasControl notasControl = new NotasControl
            {
                Dock = DockStyle.Fill,
                Form = this,
            };
            Utilities<NotasControl>.AddControl(pnlbody, notasControl);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
