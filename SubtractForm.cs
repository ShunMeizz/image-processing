using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digital_image_processing
{
    public partial class SubtractForm : Form
    {
        private Bitmap imageB, imageA;
        public SubtractForm()
        {
            InitializeComponent();
        }

        private void btnLoadImageB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.imageBBox.Image = new Bitmap(ofile.FileName);
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            this.imageResultBox.Image = Processing.ConvertToSubtraction((Bitmap)this.imageABox.Image, (Bitmap)this.imageBBox.Image);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save Image As";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap resultBitmap = new Bitmap(imageResultBox.Image);
                    resultBitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Image saved successfully!");
                }
            }
        }

        private void btnLoadImageA_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.imageABox.Image = new Bitmap(ofile.FileName);
            }

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            this.Owner.Show();
        }
    }
}
