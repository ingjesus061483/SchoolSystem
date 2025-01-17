using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.Models;

namespace UserControls
{
    public partial class BuscarUser : UserControl
    {
        List<Course> courses;
        public int Id {  get; set; }
        public  object List {  get; set; }
        public Form Form { get; set; }
        public BuscarUser()
        {
            InitializeComponent();
        }

        private void BuscarUser_Load(object sender, EventArgs e)
        {
            courses =List as List<Course> ;
            dgVer.DataSource =  courses.Select(x => new { 
                x.Id,
                Referencia=x.Reference ,
                Descripcion =x.Description ,
               CapicidadMax= x.Amount,
            }).ToList();
            var cols = Utilities<DataGridViewColumn>.GetValues(dgVer);
            Utilities<DataGridViewColumn>.FillCombo(cols, cbofiltro);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
     Id=int.Parse (      dgVer .CurrentRow .Cells["id"].Value.ToString  ());
            Form .Close();
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            dgVer .DataSource = courses.Select(x=>new 
            
            {
                x.Id,
                Referencia = x.Reference,
                Descripcion = x.Description,
                CapicidadMax = x.Amount,
            }).ToList().Where(z => Utilities<object>.GetValue(z, cbofiltro .Text ,txtfiltro .Text )).ToList();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
