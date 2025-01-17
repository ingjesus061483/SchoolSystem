using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.Models;

namespace UserControls
{
    public partial class EstudiantesUser : UserControl
    {
        List<Student> students;
        public EstudiantesUser()
        {
            InitializeComponent();
        }
        private async void EstudiantesUser_Load(object sender, EventArgs e)
        {
            Utilities<Student >.Api = "api/Students";
            students= await Utilities<Student>.Get();
            dgvEstudiante.DataSource = students.Select(x => new
            {
                x.Id,
                IdentificationType = x.IdentificationType.Name,
                x.Identification,
                x.CompleteName,
                x.BirthDate,
                x.Age,
                x.Address,
                Sex = x.Sex.Name,
                x.PhoneNumber,
                x.Email,
            }).ToList();

        }
    }
}
