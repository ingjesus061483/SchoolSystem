using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls.Models;

namespace Controls
{
    public partial class PeriodoUser : UserControl
    {
        Period period;
        List<Period > periods ;
        public Form Form { get; set; }
        public PeriodoUser()
        {
            InitializeComponent();
        }
        async void NewPeriod()
        {
            try
            {
                period =null;
                Utilities<Period>.Api = "api/Period";
                Cursor = Cursors.WaitCursor;
                periods = await Utilities<Period>.Get();
                dgvCurso.DataSource = periods.Select(x => new
                {
                    x.Id,
                    x.Title,
                    x.Since,
                    x.Untill,
                    x.Description
                }).ToList();
                txtNombre.Clear();
                txtDesde.Value = DateTime.Now;
                txtHasta.Value = DateTime.Now;
                txtDescripcion.Clear();
                txtNombre.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }
        private void PeriodoUser_Load(object sender, EventArgs e)
        {
            NewPeriod();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NewPeriod();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Utilities<Period>.Api = "api/Period";

                if (period == null)
                {
                    period = new Period
                    {
                        Title = txtNombre.Text,
                        Since = txtDesde.Value,
                        Untill = txtHasta.Value,
                        Description = txtDescripcion.Text,
                    };
                    await Utilities<Period>.Post(period);
                }
                else
                {
                    period.Title = txtNombre.Text;
                    period.Since = txtDesde.Value;
                    period.Untill = txtHasta.Value;
                    period.Description = txtDescripcion.Text;
                    await Utilities<Period>.Put(period.Id, period);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                NewPeriod();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (period == null)
            {
                return;
            }
            Utilities<Period>.Api = "api/Period";
           await Utilities<Period> .Delete(period.Id);
            NewPeriod();
        }

        private void dgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <0)
            {
                return;
            }
            int.TryParse(dgvCurso.Rows[e.RowIndex].Cells["id"].Value.ToString(), out int id);
            period = periods.Where(x => x.Id == id).FirstOrDefault();
            if (period != null)
            {
                txtNombre.Text = period.Title;
                txtDesde.Value = period.Since==null?DateTime .Now :DateTime.Parse( period.Since.ToString());
                txtHasta.Value = period.Untill  == null ? DateTime.Now : DateTime.Parse(period.Untill .ToString());
                txtDescripcion.Text = period.Description;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }
    }
}
