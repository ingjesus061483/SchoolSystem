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
    public partial class DetallePagoControl : UserControl
    {
        string[] arr = { "Id", "Name" };
        int methodofp;
       public Payment Payment { get; set; }
       public  List<MethodOfPayment> MethodOfPayments { get; set; }
       List< PaymentDetail> PaymentDetails { get; set; }
        PaymentDetail paymentDetail;
        public Form Form {  get; set; }
        public DetallePagoControl()
        {
            InitializeComponent();
        }
        void newDetail()
        {
            paymentDetail = null;
            PaymentDetails = Payment.PaymentDetails;
            dgvmatricula.DataSource = PaymentDetails.Select (x=>new {
            x.Id,
                MethodOfPayment=      x.MethodOfPayment.Name,
                x.Title,
                x.Value,

            }).ToList() ;
            cmbFormaPago.SelectedIndex = -1;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private void DetallePagoControl_Load(object sender, EventArgs e)
        {
            Utilities<MethodOfPayment>.FillCombo(MethodOfPayments, arr, cmbFormaPago);
            newDetail();

        }

        private void cmbFormaPago_SelectedValueChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbFormaPago.SelectedValue==null?"": cmbFormaPago.SelectedValue.ToString(), out methodofp);
            if (methodofp == 1)
            {
                txtTitulo.Text = "Pago de contado";
                txtValor.Clear();
                txtValor.Focus();
            }
            else
            {
                txtTitulo.Focus();
                txtTitulo.Clear();
                txtValor.Clear();

            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            paymentDetail = new PaymentDetail
            {
                MethodOfPaymentId = methodofp,
                MethodOfPayment = MethodOfPayments.FirstOrDefault(x => x.Id == methodofp),
                Title = txtTitulo.Text,
                Value = decimal.Parse(txtValor.Text)
            };
            PaymentDetails.Add(paymentDetail);
            newDetail(); 
        }
    }
}
