
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
    public partial class NovedadesUser : UserControl
    {
       public  Tuition Tuition { get; set; }
        List<Strangeness> strangenesses;
        Strangeness Strangeness { get; set; }
       public Form Form { get; set; }
        public NovedadesUser()
        {
            InitializeComponent();
        }
        void newStrangeness()
        {
            txtIdentificacion.Text =Tuition .Student.Identification;
            txtNombre.Text = Tuition.Student.CompleteName;
            strangenesses = Tuition.Strangenesses;
            dgvCurso .DataSource = strangenesses.Select(x=>new 
            {
                x.Id,
                x.Code ,
                x.Date,
                x.Course ,
               Concept= x.Concept.Title ,
               x.Detail
            }).ToList();
            txtCodigo .Text =DateTime .Now .ToOADate().ToString();
            txtDescripcion .Clear ();
            cmbConcepto.SelectedIndex = -1;
            txtFecha.Value = DateTime.Now;
            txtCodigo .Focus ();

            
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form .Close ();
        }

        private async void NovedadesUser_Load(object sender, EventArgs e)
        {
            newStrangeness();
            string[] arr = { "Id", "Title" };
   
            Utilities<Concept>.Api = "api/Concept";
          Utilities <Concept>.FillCombo (  await Utilities<Concept>.Get(),arr ,cmbConcepto);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            newStrangeness ();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Utilities<Strangeness>.Api = "api/Strangeness";
            if (Strangeness == null)
            {
                Strangeness = new Strangeness 
                {
                    Code =txtCodigo.Text,
                    ConceptId=int.Parse( cmbConcepto .SelectedValue.ToString () ),
                    TuitionId =Tuition.Id,
                    Date = txtFecha .Value ,
                    Detail = txtDescripcion.Text
                };
               await Utilities<Strangeness>.Post(Strangeness);

            }
            else
            {
                Strangeness.Code = txtCodigo.Text;
                Strangeness.ConceptId = int.Parse(cmbConcepto.SelectedValue.ToString());
                Strangeness.TuitionId = Tuition.Id;
                Strangeness.Date = txtFecha.Value;
                Strangeness.Detail = txtDescripcion.Text;
               await  Utilities<Strangeness>.Put(Strangeness.Id, Strangeness);
            }
            Form.Close();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            Utilities<Strangeness>.Api = "api/Strangeness";

            if (Strangeness == null)
                return;
           await Utilities<Strangeness>.Delete (Strangeness. Id);
            Form .Close();
        }
    }
}
