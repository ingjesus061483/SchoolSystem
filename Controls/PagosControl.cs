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
    public partial class PagosControl : UserControl
    {
        List<MethodOfPayment> methodOfPayments ;
        bool istotalpay=true;
        public MonthlyPayment MonthlyPayment { get; set; }
        public Form Form {  get; set; }
        List<Payment> Payments;
        Payment payment;
        public PagosControl()
        {
            InitializeComponent();
        }
        void NewPayment()
        {
            txtCodigoMensualidad.Text = MonthlyPayment.Code;
            rbtPagoTotal.Checked=true;
            txtCodigo.Text = DateTime.Now.ToOADate().ToString();
            txtFecha.Value = DateTime.Now;
            txtObservaciones.Clear();
            Payments = MonthlyPayment.Payments;
            dgvCurso.DataSource = Payments.Select(x => new{ 
            x.Id,
            x.Code,
            x.Date,
            x.Value ,
            x.Remark,
            x.IsTotalPay
            }).ToList ();

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private void rbtPagoTotal_CheckedChanged(object sender, EventArgs e)
        {
            txtTotalPagar.ReadOnly = rbtPagoTotal.Checked;
            istotalpay = rbtPagoTotal.Checked;
            txtTotalPagar.Text = MonthlyPayment.Value.ToString();
        }

        private void rbtPagoParcial_CheckedChanged(object sender, EventArgs e)
        {
            istotalpay=rbtPagoParcial.Checked ;
            txtTotalPagar.ReadOnly = false;
            txtTotalPagar.Clear();
            txtTotalPagar.Focus();

        }

        private async void PagosControl_Load(object sender, EventArgs e)
        {
            Utilities<MethodOfPayment>.Api = "api/Payment/MethodOfPayment";
            methodOfPayments =await Utilities<MethodOfPayment>.Get();
            NewPayment();
        }

        private void btnDetallePago_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtTotalPagar.Text, out decimal totalpay);
            if (payment==null )
            {
                payment =new Payment 
                {
                    MonthlyPaymentId=MonthlyPayment.Id ,
                    Code=txtCodigo .Text ,
                    Date=txtFecha.Value ,
                    Value=totalpay,
                    IsTotalPay=istotalpay,
                    Remark =txtObservaciones.Text,
                    PaymentDetails=new List<PaymentDetail>()                    
                };
            }
            if(payment .PaymentDetails.Sum (x=>x .Value)>=totalpay)
            {
                MessageBox.Show("Ha sobrepasado el limite", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmSecundario frmSecundario = new frmSecundario 
            {
                Text ="Detalle de pago",
                Icon = new Icon(Application.StartupPath + "\\icon\\DetallePago.ico")
            };

            DetallePagoControl detallePagoControl = new DetallePagoControl
            {
                Payment=payment ,
                MethodOfPayments =methodOfPayments ,
                Form = frmSecundario,
                Dock = DockStyle.Fill,
            };
            frmSecundario.Size = detallePagoControl.Size;
            frmSecundario.UserControl = detallePagoControl;
            frmSecundario.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
