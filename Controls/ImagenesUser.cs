using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Controls.Models;

namespace Controls
{
    public partial class ImagenesUser : UserControl
    {
        public Form Form {  get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        List<PicturePerson> PicturePeople { get; set; }
        public ImagenesUser()
        {
            InitializeComponent();
        }

        string getSplit(char separator, string s)
        {
            string[] strings = s.Split(separator);
            return strings[strings.Length - 1];
        }

        void NewPicture()
        {
            txtImagenes.Clear();
            if (Student != null)
            {
                dgAsignaturas.DataSource = PicturePeople.Select(x => new
                {
                    x.Id,
                    x.PictureId,
                    x.StudentId,
                    imagen = x.Picture.Code + " " + x.Picture.Title + "." + x.Picture.Type,
                    estudiante = x.Student,
                }).ToList();
                dgAsignaturas.Columns["Profesor"].Visible = false;
            }
            else if (Teacher != null)
            {
                dgAsignaturas.DataSource = PicturePeople.Select(x => new
                {
                    x.Id,
                    x.PictureId,
                    x.TeacherId,
                    imagen = x.Picture.Code + " " + x.Picture.Title + "." + x.Picture.Type,
                    profesor = x.Teacher,
                }).ToList();
                dgAsignaturas.Columns["Estudiante"].Visible = false;

            }

            PicturePerson picturePerson =PicturePeople. FirstOrDefault();
            if (picturePerson == null) 
            {
                return;
            }
        }

        private void ImagenesUser_Load(object sender, EventArgs e)
        {
            if (Student != null)
            {
                lblCaption.Text = "Estudiante";
                txtIdentificacion.Text = Student.Identification;
                txtNombre.Text = Student.CompleteName;
                PicturePeople = Student.picturePeople;
            }
            else if(Teacher != null)
            {
                lblCaption.Text = "Profesor";
                txtIdentificacion.Text = Teacher.Identification;
                txtNombre.Text = Teacher.CompleteName;
                PicturePeople = Teacher.PicturePeople;
            }
            NewPicture();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form .Close();
        }

        private async void btnImagenes_Click(object sender, EventArgs e)
        {
            string path = "";
            if (Utilities<bool>.OpenDialog("Imagenes (JPG)|*.jpg", ref path))
            {
                string title = getSplit('\\', path); 
                txtImagenes .Text = title;
                string[] names = title.Split('.');
                title = names[0];
                string type = names[1];
                byte[] ImageData = Utilities<byte[]>.GetBytes (path);
                Picture picture = new Picture 
                {
                    Code = DateTime.Now.ToOADate().ToString(),
                    Title  = title,
                    Type = type,
                    Data = ImageData
                };
                Utilities<Picture>.Api = "api/Picture";
               await  Utilities <Picture >.Post (picture );
                List<Picture > images =await Utilities <Picture>.Get();
                if (Student != null)
                {
                    PicturePeople.Add(new PicturePerson
                    {
                        Picture = images.FirstOrDefault(x => x.Code == picture.Code),
                        PictureId = images.FirstOrDefault(x => x.Code == picture.Code).Id,
                        Student = Student.CompleteName,
                        StudentId = Student.Id
                    });
                }
                else if (Teacher !=null)
                {
                    PicturePeople.Add(new PicturePerson
                    {
                        Picture = images.FirstOrDefault(x => x.Code == picture.Code),
                        PictureId = images.FirstOrDefault(x => x.Code == picture.Code).Id,
                      Teacher  = Teacher .CompleteName,
                        TeacherId = Teacher .Id
                    });
                }
                NewPicture();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Utilities<List<PicturePerson>>.Api = "api/PicturePerson";
            if (Student != null)
            {


                await Utilities<List<PicturePerson>>.Post(PicturePeople.Select(x => new PicturePerson
                {
                    PictureId = x.PictureId,
                    StudentId = x.StudentId,
                    TeacherId =null,
                }).ToList());
            }
            else if (Teacher != null)
            {
                await Utilities<List<PicturePerson>>.Post(PicturePeople.Select(x => new PicturePerson
                {
                    PictureId = x.PictureId,
                    StudentId=null ,
                    TeacherId  = x.TeacherId,
                }).ToList());
            }
                btnSalir.PerformClick ();
        }

        private async void dgAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int.TryParse(dgAsignaturas.Rows[e.RowIndex].Cells["PictureId"].Value.ToString(), out int pictureid);
            switch (e.ColumnIndex)
            {
                case 2://ver
                    {    
                        var picture = PicturePeople.FirstOrDefault(x => x.PictureId == pictureid).Picture; 
                        ImagePreviewUser imagePreviewUser = new ImagePreviewUser 
                        {
                            Picture=picture,
                            Dock=DockStyle .Fill 
                        };
                        frmSecundario frmSecundario = new frmSecundario { UserControl =imagePreviewUser };
                        frmSecundario .ShowDialog();                   
                        break;
                      
                    }
                case 3: //Eliminar
                    {
                        DialogResult resp;
                        resp = MessageBox.Show("Eliminar imagen", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resp == DialogResult.No)
                        {
                            return ;
                        }
                        Utilities<Picture>.Api = "api/Picture";
                        await Utilities<Picture>.Delete(pictureid);
                        btnSalir.PerformClick();
                        break;                        
                    }


            }
        }
    }
}
