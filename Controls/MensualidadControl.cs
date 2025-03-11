using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls.Models;

namespace Controls
{
    public partial class MensualidadControl : UserControl
    {
        Tuition Tuition;
        public Form Form;
        List<MonthlyPayment> MonthlyPayments;
        public MensualidadControl()
        {
            InitializeComponent();
        }

        private async void btnMatricula_Click(object sender, EventArgs e)
        {
            try
            {
                Utilities<Tuition>.Api = "api/Tuition";
                Cursor = Cursors.WaitCursor;
                var tuitions = await Utilities<Tuition>.Get();
                int tuitionId = Utilities<Tuition>.GetID(tuitions.ToList(),"matricula");
                Tuition = tuitions.FirstOrDefault(x => x.Id == tuitionId);
                if (Tuition == null) { return; }
                txtCodigo.Text = Tuition.Code;
                txtEstado.Text = Tuition.Status.Name;
                MonthlyPayments = Tuition.MonthlyPayments;
                dgvCurso.DataSource = MonthlyPayments.Select(x => new
                {
                    x.Id,
                    x.Code,
                    x.Monthly,
                    x.Value,
                    x.Detail,
                    IsConfirmed = x.Confirmed
                }).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Cursor= Cursors.Default;
            }
        }
        void NewMonthlyPayments()
        {
            Tuition = null;
            MonthlyPayments = new List<MonthlyPayment>();
            dgvCurso.DataSource = MonthlyPayments.Select(x => new {
                x.Id,
                x.Code,
                x.Monthly,
                x.Value,
                x.Detail,
                x.Confirmed 
            }).ToList();
            txtCodigo.Clear();
            txtEstado.Clear();

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NewMonthlyPayments();
        }

        private void MensualidadControl_Load(object sender, EventArgs e)
        {
            NewMonthlyPayments();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private void dgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                int.TryParse(dgvCurso.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out int id);
                var monthy = MonthlyPayments.FirstOrDefault(x => x.Id == id);
                frmSecundario frmSecundario = new frmSecundario 
                {
                    Text = $"Pagos: {monthy.Monthly} ",
                    Icon = new Icon(Application.StartupPath + "\\icon\\pagos.ico") 
                };                
                PagosControl pagosControl= new  PagosControl                
                {
                    Form = frmSecundario,
                    MonthlyPayment= monthy ,
                    Dock = DockStyle.Fill,
                };
                frmSecundario.Size = pagosControl.Size;
                frmSecundario.UserControl = pagosControl;
                frmSecundario.ShowDialog();
            }
        }

        private void btnPreView_Click(object sender, EventArgs e)
        {
            if (Tuition == null) { return; }
          string   url = $"{ConfigurationManager.AppSettings["base_url"]}/Report/GetFileMonthlyPayments?tuitionId={Tuition.Id}";
            Process.Start("IExplore.exe", url);
        }
    }
}
