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
    public partial class ImagePreviewUser : UserControl
    {
        public Picture Picture { get; set; }
        public ImagePreviewUser()
        {
            InitializeComponent();
        }

        private void ImagePreviewUser_Load(object sender, EventArgs e)
        {
            pbImagenes.Image = Utilities<byte[]>.LoadImage(Picture.Data);
        }
    }
}
