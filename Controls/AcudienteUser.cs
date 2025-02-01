using Controls.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class AcudienteUser : UserControl
    {
        public Form Form { get; set; }
        string[] arr = { "Id", "Name" };
        List<Attendant> attendants;
        Attendant attendant;
        public AcudienteUser()
        {
            InitializeComponent();
        }
        async void NewAttendant()
        {
            attendant = null;
            Utilities<Attendant>.Api = "/api/Attendant";
            Cursor = Cursors.WaitCursor;            
            attendants =await Utilities<Attendant >.Get();
            dgvEstudiante.DataSource = attendants .Select(x => new
            {
                x.Id,               
                x.Identification,
                x.CompleteName,
                x.BirthDate,
                x.Age,
                x.Address,                
                x.PhoneNumber,
                x.Email,
                Relationship = x.Relationship.Name ,
            }).ToList(); ;
            Cursor= Cursors.Default;
            txtNumDoc.Clear();
            txtPriNombre.Clear();
            txtPriApellido.Clear();
            txtFechaNacim.Value = DateTime.Now;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtNumDoc.Focus();
            cmbParentezco.SelectedIndex = -1;
        }

        private async void AcudienteUser_Load(object sender, EventArgs e)
        {
            NewAttendant();
            Utilities<Relationship>.Api = "/api/Attendant/Relationships";
            Utilities<Relationship>.FillCombo(await  Utilities<Relationship>.Get(), arr, cmbParentezco);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NewAttendant();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {        
            Utilities<Attendant>.Api = "/api/Attendant";
            if(attendant ==null)
            {
                attendant = new Attendant 
                {
                    Identification =txtNumDoc.Text,
                    FirstName =txtPriNombre.Text,
                    LastName =txtPriApellido.Text,
                    BirthDate=txtFechaNacim .Value,
                    Address=txtDireccion .Text  ,
                    PhoneNumber = txtTelefono.Text,
                    Email=txtEmail.Text,
                    RelationshipId=int.Parse ( cmbParentezco .SelectedValue.ToString ()) 
                    
                };
               await Utilities<Attendant>.Post(attendant);
            }
            else
            {
                attendant.Identification = txtNumDoc.Text;
                attendant.FirstName = txtPriNombre.Text;
                attendant.LastName = txtPriApellido.Text;
                attendant.BirthDate = txtFechaNacim.Value;
                attendant.Address = txtDireccion.Text;
                attendant.PhoneNumber = txtTelefono.Text;
                attendant.Email = txtEmail.Text;
                attendant.RelationshipId = int.Parse(cmbParentezco.SelectedValue.ToString());
                await Utilities <Attendant>.Put (attendant.Id ,attendant );
            }
            NewAttendant();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            Utilities<Attendant>.Api = "/api/Attendant";
            if (attendant ==null)
            {
                return;
            }
           await Utilities<Attendant>.Delete (attendant.Id);
            NewAttendant();

        }

        private void txtFechaNacim_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = Math.Round((DateTime.Now - txtFechaNacim.Value).TotalDays / 365).ToString();

        }

        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           int. TryParse(dgvEstudiante.Rows[e.RowIndex ].Cells["Id"].Value.ToString (),out int id) ;
           attendant= attendants.FirstOrDefault(x => x.Id == id);
            txtNumDoc.Text = attendant.Identification;
            txtPriNombre.Text=attendant.FirstName  ;
            txtPriApellido.Text = attendant.LastName;
            txtFechaNacim.Value = attendant.BirthDate;
            txtDireccion.Text = attendant.Address;
            txtTelefono.Text = attendant.PhoneNumber;
            txtEmail.Text = attendant.Email;
            cmbParentezco.SelectedValue= attendant.RelationshipId ;
        }
    }
}
