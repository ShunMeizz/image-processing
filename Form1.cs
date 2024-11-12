using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ImageProcess2;

namespace digital_image_processing
{
    public enum FilterType
    {
        GreyScale,
        Sepia,
        Inverted,
        Histogram
    }

    public partial class Form1 : Form
    {
        private Form2 f2;
        private bool isVideoOn = false;
        private FilterType currentFilter;
        private Timer filterTimer;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private readonly object imageLock = new object();

        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
            InitializeFilterTimer();
        }

        //  Load Available Video Devices
        private void Form1_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No camera detected.");
            }
        }

        private void InitializeFilterTimer()
        {
            filterTimer = new Timer
            {
                Interval = 500 
            };
            filterTimer.Tick += (s, e) => ProcessVideoFrame();
        }

        // Start Video Stream
        private void btnTurnOn_Click(object sender, EventArgs e)
        {
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
                isVideoOn = true;
            }
            else
            {
                MessageBox.Show("No video device available.");
            }
        }

        // Stop Video Stream, together with the filterTimer
        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
                isVideoOn = false;
                filterTimer.Stop();
            }
            picOriginalBox.Image?.Dispose();
            picOriginalBox.Image = null;
            picResultBox.Image?.Dispose();
            picResultBox.Image = null;
        }

        // Process Each New Frame
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs e)
        {
            Bitmap frame;
            lock (imageLock)
            {
                frame = (Bitmap)e.Frame.Clone();
            }

            picOriginalBox.Image?.Dispose();
            picOriginalBox.Image = frame;

            if (filterTimer.Enabled)
            {
                ProcessVideoFrame(); 
            }
        }

        // Process Frame with selected filter
        private void ProcessVideoFrame()
        {
            if (picOriginalBox.Image == null) return;

            Bitmap frame = (Bitmap)picOriginalBox.Image.Clone();

            switch (currentFilter)
            {
                case FilterType.GreyScale:
                    BitmapFilter.GrayScale(frame);
                    break;
                case FilterType.Sepia:
                    BitmapFilter.Sepia(frame);
                    break;
                case FilterType.Inverted:
                    BitmapFilter.Invert(frame);
                    break;
                case FilterType.Histogram:
                    Bitmap histogramImage = null;
                    BasicDIP.Histogram(ref frame, ref histogramImage); 
                    frame = histogramImage;
                    break;
                default:
                    break;
            }

            picResultBox.Image?.Dispose();
            picResultBox.Image = frame;
        }

        private void ApplyImageFilter(FilterType filterType)
        {
            Bitmap image = (Bitmap)picOriginalBox.Image.Clone();

            switch (filterType)
            {
                case FilterType.GreyScale:
                    picResultBox.Image = Processing.ConvertToGray(image);
                    break;
                case FilterType.Sepia:
                    picResultBox.Image = Processing.ConvertToSepia(image);
                    break;
                case FilterType.Inverted:
                    picResultBox.Image = Processing.ConvertToColorInversion(image);
                    break;
                case FilterType.Histogram:
                    picResultBox.Image = Processing.ConvertToHistogram(image);
                    break;
                default:
                    break;
            }

            SetFilter(filterType);
        }


        private void SetFilter(FilterType filterType)
        {
            currentFilter = filterType;

            if (isVideoOn)
            {
                if (!filterTimer.Enabled)
                {
                    filterTimer.Start();
                }
            }
        }

        // Open Image File
        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnTurnOff_Click(sender, e);
            using (OpenFileDialog ofile = new OpenFileDialog
            {
                Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png"
            })
            {
                if (ofile.ShowDialog() == DialogResult.OK)
                {
                    picOriginalBox.Image = new Bitmap(ofile.FileName);
                }
            }
        }

        // Save Result Image or a Frame from a Video
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Bitmap imageToSave = isVideoOn ? CloneCurrentFrame() : (Bitmap)picResultBox.Image;

            if (imageToSave != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PNG Image|*.png",
                    Title = "Save Image As"
                })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        imageToSave.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Image saved successfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No image available to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method for saving an image from a video
        private Bitmap CloneCurrentFrame()
        {
            if (picResultBox.Image != null)
            {
                return new Bitmap(picResultBox.Image); 
            }
            return null; 
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (isVideoOn)
            {
                MessageBox.Show("The 'Copy' feature is not available while the video stream is active.",
                                "Feature Not Available",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                picResultBox.Image = Processing.CreateCopy((Bitmap)picOriginalBox.Image.Clone());
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            ApplyImageFilter(FilterType.GreyScale);
        }

        private void btnColorInversion_Click(object sender, EventArgs e)
        {
            ApplyImageFilter(FilterType.Inverted);
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            ApplyImageFilter(FilterType.Histogram);
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            ApplyImageFilter(FilterType.Sepia);
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            btnTurnOff_Click(sender, e);
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }
    }
}
