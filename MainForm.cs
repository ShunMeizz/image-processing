using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ImageProcess2;
using Microsoft.VisualBasic;
using static digital_image_processing.Processing;

namespace digital_image_processing
{
    public enum FilterType
    {
        GreyScale,
        Sepia,
        Inverted,
        Histogram
    }
    public enum EffectType
    {
        Smoothing,
        GaussianBlur,
        Sharpening,
        MeanRemoval,
        EmbossLaplascian,
        EmbossHorizVert,
        EmbossAllDir,
        EmbossLossy,
        EmbossHoriz,
        EmbossVert, 
    }


    public partial class MainForm : Form
    {
        private SubtractForm f2; 
        private bool isVideoOn = false;
        private FilterType currentFilter;
        private EffectType currentEffect;
        private Timer filterTimer;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private readonly object imageLock = new object();

        public MainForm()
        {
            InitializeComponent();
            f2 = new SubtractForm();
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

            Bitmap frame;
            lock (imageLock)
            {
                frame = (Bitmap)this.picOriginalBox.Image.Clone();
            }

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

        private void ApplyImageFilter()
        {
            Bitmap image = (Bitmap)picOriginalBox.Image.Clone();

            switch (currentFilter)
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

            SetFilter();
        }


        private void SetFilter()
        {
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

        // PART 1: For DIP - Copy, GrayScale, Inversion, Histogram, Sepia
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
                this.picResultBox.Image = Processing.CreateCopy((Bitmap)this.picOriginalBox.Image);
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            currentFilter = FilterType.GreyScale;
            ApplyImageFilter();
        }

        private void btnColorInversion_Click(object sender, EventArgs e)
        {
            currentFilter = FilterType.Inverted;
            ApplyImageFilter();
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            currentFilter = FilterType.Histogram;
            ApplyImageFilter();
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            currentFilter = FilterType.Sepia;
            ApplyImageFilter();
        }

        // PART 2: For DIP - Subtraction
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            btnTurnOff_Click(sender, e);
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }

        // PART 3: For Convolution Matrix Processes

        public static int GetEffectWeight(string prompt, string title, int defaultValue)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(prompt, title, defaultValue.ToString());

            if (int.TryParse(input, out int nWeight))
            {
                return nWeight;
            }
            else
            {
                MessageBox.Show("Invalid input. Using default value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return defaultValue;
            }
        }


        private void ApplyImageEffects()
        {
            if (picOriginalBox.Image == null)
            {
                MessageBox.Show("Please load an image first.", "No Image Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap image = (Bitmap)picOriginalBox.Image.Clone();
            int weight;

            switch (currentEffect)
            {
                case EffectType.Smoothing:
                    BitmapFilter.Smooth(image, 1);  
                    break;

                case EffectType.GaussianBlur:
                    weight = GetEffectWeight("Enter center value for Gaussian Blur:", "Gaussian Blur Weight", 4);
                    BitmapFilter.GaussianBlur(image, weight);
                    break;

                case EffectType.Sharpening:
                    weight = GetEffectWeight("Enter center value for Sharpening:", "Sharpening Weight", 11);
                    BitmapFilter.Sharpen(image, weight);
                    break;

                case EffectType.MeanRemoval:
                    weight = GetEffectWeight("Enter center value for Mean Removal:", "Mean Removal Weight", 9);
                    BitmapFilter.MeanRemoval(image, weight);
                    break;

                case EffectType.EmbossLaplascian:
                case EffectType.EmbossHorizVert:
                case EffectType.EmbossAllDir:
                case EffectType.EmbossLossy:
                case EffectType.EmbossHoriz:
                case EffectType.EmbossVert:
                    EMBOSS embossType = GetEmbossType();
                    Emboss(image, embossType);
                    break;
                default:
                    break;
            }

            picResultBox.Image = image;
        }


        private void btnSmoothing_Click(object sender, EventArgs e)
        {
            currentEffect = EffectType.Smoothing;
            ApplyImageEffects();
        }
        private void btnGaussian_Click(object sender, EventArgs e)
        {
            currentEffect = EffectType.GaussianBlur;
            ApplyImageEffects();
        }

        private void btnSharpen_Click(object sender, EventArgs e)
        {
            currentEffect = EffectType.Sharpening;
            ApplyImageEffects();
        }

        private void btnMeanRemoval_Click(object sender, EventArgs e)
        {
            currentEffect = EffectType.MeanRemoval;
            ApplyImageEffects();
        }
        private EMBOSS GetEmbossType()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Select Emboss Type:\n" +
                "1: Laplascian\n" +
                "2: Horizontal Vertical\n" +
                "3: All Direction\n" +
                "4: Lossy\n" +
                "5: Horizontal Only\n" +
                "6: Vertical Only",
                "Emboss Type",
                "1");

            switch (input)
            {
                case "1":
                    return EMBOSS.LAPLASCIAN;
                case "2":
                    return EMBOSS.HORIZONTAL_VERTICAL;
                case "3":
                    return EMBOSS.ALL_DIRECTION;
                case "4":
                    return EMBOSS.LOSSY;
                case "5":
                    return EMBOSS.HORIZONTAL_ONLY;
                case "6":
                    return EMBOSS.VERTICAL_ONLY;
                default:
                    return EMBOSS.LAPLASCIAN;
            }
        }
        private void btnEmbossing_Click(object sender, EventArgs e)
        {
            currentEffect = EffectType.EmbossLaplascian;
            ApplyImageEffects();
        }

        private void btnCoinCounter_Click(object sender, EventArgs e)
        {
        }
    }
}
