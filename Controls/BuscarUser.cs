﻿
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
using Controls.Models;

namespace Controls
{
    public partial class BuscarUser : UserControl
    {
        List<Course> courses;
        List<Student > students ;
        List<Attendant> attendants;
        List<Teacher> teachers;
        List<SchoolSubject> schoolSubjects;
        List<Period> periods;
        public int Id {  get; set; }
        public  object List {  get; set; }
        public Form Form { get; set; }
        public BuscarUser()
        {
            InitializeComponent();
        }
        void LoadGrid(object obj)
        {
            if (obj is List<Course>)
            {
                courses = obj as List<Course>;
                dgVer.DataSource = courses.Select(x => new
                {
                    x.Id,
                    Referencia = x.Reference,
                    Descripcion = x.Description,
                    CapicidadMax = x.Amount,
                }).ToList();
            }
            else if (obj is List<Student>)
            {
                students = obj as List<Student>;
                dgVer.DataSource = students.Select(x => new
                {
                    x.Id,
                    TipoIdentificacion = x.IdentificationType.Name,
                    Identificacion = x.Identification,
                    NombreCompleto = x.CompleteName,
                    FechaNacimiento = x.BirthDate,
                    Edad = x.Age,
                    Direccion = x.Address,
                    Sexo = x.Sex.Name,
                    Telefono = x.PhoneNumber,
                    x.Email,
                    //                  Estado = x.Status.Name,
                }).ToList();
            }
            else if (obj is List<Attendant>)
            {
                attendants = obj as List<Attendant>;
                dgVer.DataSource = attendants.Select(x => new
                {
                    x.Id,
                    Identificacion = x.Identification,
                    NombreCompleto = x.CompleteName,
                    FechaNacimiento = x.BirthDate,
                    Edad = x.Age,
                    Direccion = x.Address,
                    Telefono = x.PhoneNumber,
                    x.Email,
                }).ToList();
            }
            else if (obj is List<Teacher>)
            {
                teachers = obj as List<Teacher>;
                dgVer.DataSource = teachers.Select(x => new
                {
                    x.Id,
                    TipoIdentificacion = x.IdentificationType.Name,
                    Identificacion = x.Identification,
                    NombreCompleto = x.CompleteName,
                    FechaNacimiento = x.BirthDate,
                    Edad = x.Age,
                    Direccion = x.Address,
                    Sexo = x.Sex.Name,
                    Telefono = x.PhoneNumber,
                    x.Email,
                }).ToList();
            }
            else if (List is List<SchoolSubject>)
            {
                schoolSubjects = obj as List<SchoolSubject>;
                dgVer.DataSource = schoolSubjects.Select(x => new
                {
                    x.Id,
                    Codigo = x.Code,
                    Nombre = x.Name,
                    Descripcion = x.Description,
                    CantidadHoras = x.HourAmount
                }).ToList();
            }
            else if(List is List<Period>)
            {
                periods = obj as List<Period>;
                dgVer .DataSource = periods.Select(x => new
                {
                    x.Id,
                    x.Title,
                    x.Since,
                    x.Untill,
                    x.Description
                }).ToList();
            }
        }        
        void LoadGrid(object obj, string filtro, string valor)
        {
            if (obj is List<Course>)
            {
                courses = obj as List<Course>;
                dgVer.DataSource = courses.Select(x => new
                {
                    x.Id,
                    Referencia = x.Reference,
                    Descripcion = x.Description,
                    CapicidadMax = x.Amount,
                }).ToList().Where(z => Utilities<object>.GetValue(z, filtro, valor)).ToList();
            }
            else if (obj is List<Student>)
            {
                students = obj as List<Student>;
                dgVer.DataSource = students.Select(x => new
                {
                    x.Id,
                    TipoIdentificacion = x.IdentificationType.Name,
                    Identificacion = x.Identification,
                    NombreCompleto = x.CompleteName,
                    FechaNacimiento = x.BirthDate,
                    Edad = x.Age,
                    Direccion = x.Address,
                    Sexo = x.Sex.Name,
                    Telefono = x.PhoneNumber,
                    x.Email,
                    //      Estado = x.Status.Name,
                }).ToList().Where(z => Utilities<object>.GetValue(z, filtro, valor)).ToList();
            }
            else if (obj is List<Attendant>)
            {
                attendants = obj as List<Attendant>;
                dgVer.DataSource = attendants.Select(x => new
                {
                    x.Id,
                    Identificacion = x.Identification,
                    NombreCompleto = x.CompleteName,
                    FechaNacimiento = x.BirthDate,
                    Edad = x.Age,
                    Direccion = x.Address,
                    Telefono = x.PhoneNumber,
                    x.Email,
                }).ToList().Where(z => Utilities<object>.GetValue(z, filtro, valor)).ToList();
            }
            else if (obj is List<Teacher>)
            {
                teachers = obj as List<Teacher>;
                dgVer.DataSource = teachers.Select(x => new
                {
                    x.Id,
                    TipoIdentificacion = x.IdentificationType.Name,
                    Identificacion = x.Identification,
                    NombreCompleto = x.CompleteName,
                    FechaNacimiento = x.BirthDate,
                    Edad = x.Age,
                    Direccion = x.Address,
                    Sexo = x.Sex.Name,
                    Telefono = x.PhoneNumber,
                    x.Email,
                }).ToList().Where(z => Utilities<object>.GetValue(z, filtro, valor)).ToList();
            }
            else if (List is List<SchoolSubject>)
            {
                schoolSubjects = obj as List<SchoolSubject>;
                dgVer.DataSource = schoolSubjects.Select(x => new
                {
                    x.Id,
                    Codigo = x.Code,
                    Nombre = x.Name,
                    Descripcion = x.Description,
                    CantidadHoras = x.HourAmount
                }).ToList().Where(z => Utilities<object>.GetValue(z, filtro, valor)).ToList();
            }
            else if (List is List<Period>)
            {
                periods = obj as List<Period>;
                dgVer.DataSource = periods.Select(x => new
                {
                    x.Id,
                    x.Title,
                    x.Since,
                    x.Untill,
                    x.Description
                }).ToList().Where(z => Utilities<object>.GetValue(z, filtro, valor)).ToList();
            }
        }

        private void BuscarUser_Load(object sender, EventArgs e)
        {
            LoadGrid(List );
            var cols = Utilities<DataGridViewColumn>.GetValues(dgVer);
            Utilities<DataGridViewColumn>.FillCombo(cols, cbofiltro);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Id = int.Parse(dgVer.CurrentRow.Cells["id"].Value.ToString());
            Form .Close();
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            LoadGrid (List,cbofiltro .Text ,txtfiltro .Text );
        }

        private void dgVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <0)
            {
                return;
            }
            Id = int.Parse(dgVer.Rows[e.RowIndex].Cells["id"].Value.ToString());
            Form.Close();
        }
    }
}
