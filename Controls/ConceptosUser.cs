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
    public partial class ConceptosUser : UserControl
    {
        public Form Form { get; set; }
        List<Concept> Concepts { get; set; }
        Concept concept;
        public ConceptosUser()
        {
            InitializeComponent();
        }
        async void newConcept()
        {
            concept = null;
            Utilities<Concept>.Api = "api/Concept";
            Cursor = Cursors.WaitCursor;
            Concepts = await Utilities<Concept>.Get();
            Cursor = Cursors.Default;
            dgAsignaturas.DataSource = Concepts.Select(x => new
            {
                x.Id,
                x.Code,
                x.Title,
                x.Description,
            }).ToList();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCodigo.Focus();
        }
        private void ConceptoUser_Load(object sender, EventArgs e)
        {
            newConcept();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            newConcept();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Utilities<Concept>.Api = "api/Concept";
            if (concept == null)
            {
                concept = new Concept
                {
                    Code = txtCodigo.Text,
                    Title = txtNombre.Text,
                    Description = txtDescripcion.Text,

                };
                await Utilities<Concept>.Post(concept);
            }
            else
            {
                concept.Code = txtCodigo.Text;
                concept.Title = txtNombre.Text;
                concept.Description = txtDescripcion.Text;
                await Utilities<Concept>.Put(concept.Id, concept);
            }
            newConcept();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            Utilities<Concept>.Api = "api/Concept";
            if (concept == null)
            {
                return;

            }
            await Utilities<Concept>.Delete(concept.Id);
            newConcept ();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close ();
        }

        private void dgAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int.TryParse(dgAsignaturas.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out int id);
            concept =Concepts.FirstOrDefault(x => x.Id == id);
            txtCodigo.Text = concept.Code;
            txtNombre.Text = concept.Title;
            txtDescripcion.Text = concept.Description;
        }
    }
}
