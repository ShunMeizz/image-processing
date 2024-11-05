using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;

namespace digital_image_processing
{
    public partial class Form1 : Form
    {
        private Form2 f2;
        Device []devices;

        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.picOriginalBox.Image = new Bitmap(ofile.FileName);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            
            this.picResultBox.Image = Processing.CreateCopy((Bitmap)this.picOriginalBox.Image);
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            this.picResultBox.Image = Processing.ConvertToGray((Bitmap)this.picOriginalBox.Image);
        }

        private void btnColorInvention_Click(object sender, EventArgs e)
        {
            this.picResultBox.Image = Processing.ConvertToColorInversion((Bitmap)this.picOriginalBox.Image);
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            this.picResultBox.Image = Processing.ConvertToHistogram((Bitmap)this.picOriginalBox.Image);

        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            this.picResultBox.Image = Processing.ConvertToSepia((Bitmap)this.picOriginalBox.Image);

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save Image As";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap resultBitmap = new Bitmap(picResultBox.Image);
                    resultBitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Image saved successfully!");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            devices = DeviceManager.GetAllDevices();
            if (devices == null)
            {
                MessageBox.Show("No camera devices found.");
            }
        }
        private void btnTurnOn_Click(object sender, EventArgs e)
        {
            devices[0].ShowWindow(picOriginalBox);
        }
        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            devices[0].Stop();
        }

        
    }
}
