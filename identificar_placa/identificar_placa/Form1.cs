using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace identificar_placa
{
    public partial class Form1 : Form
    {
        public Bitmap currentImage { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentImage = (Bitmap)Bitmap.FromFile(ofd.FileName);
                pictureBox1.Image = currentImage;
            }
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AForge.Imaging.Filters.Grayscale filter_gray = new AForge.Imaging.Filters.Grayscale(0.2125, 0.7154, 0.0721);
            currentImage = (Bitmap) filter_gray.Apply(currentImage);
            pictureBox1.Image = currentImage;
        }
    }
}
