﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digital_image_processing
{
    internal class Processing
    {
        public Processing(Bitmap bmp) 
        {
        }
        public static Bitmap CreateCopy(Bitmap bmp)
        {
            Color pixel;
            Bitmap processed = new Bitmap(bmp.Width, bmp.Height);
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    pixel = bmp.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);

                }
            return processed;

        }
        public static Bitmap ConvertToGray(Bitmap bmp)
        {
            Color pixel;
            Bitmap processed = new Bitmap(bmp.Width, bmp.Height);
            int a, r, g, b, avg;
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    pixel = bmp.GetPixel(x, y);
                    a = pixel.A;
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;
                    avg = (r + g + b) / 3;
                    processed.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg)); 
                }
            return processed;

        }

        public static Bitmap ConvertToColorInversion(Bitmap bmp)
        {
            Color pixel;
            Bitmap processed = new Bitmap(bmp.Width, bmp.Height);
            int a, r, g, b;
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    pixel = bmp.GetPixel(x, y);
                    a = pixel.A;
                    r = 255 - pixel.R;
                    g = 255 - pixel.G;
                    b = 255 - pixel.B;
                    processed.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            return processed;

        }
        public static Bitmap ConvertToHistogram(Bitmap bmp)
        {
            Bitmap grayBitmap = ConvertToGray(bmp);
            int[] histdata = new int[256];


            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color sample = bmp.GetPixel(x, y);
                    int grayValue = sample.R; 
                    histdata[grayValue]++;
                }
            }

            //for the histogram display
            Bitmap histogramBitmap = new Bitmap(256, 240);
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);
                for (int i = 0; i < histdata.Length; i++)
                {
                    // Scale height to fit in the histogram image
                    int height = (int)(histdata[i] * 240.0 / bmp.Height); 
                    g.DrawLine(Pens.Black, i, 240, i, 240 - height); 
                }
            }

            return histogramBitmap; 

        }
        public static Bitmap ConvertToSepia(Bitmap bmp)
        {
            Color pixel;
            Bitmap processed = new Bitmap(bmp.Width, bmp.Height);
            int a, r, g, b, tr, tg, tb;
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    pixel = bmp.GetPixel(x, y);
                    a = pixel.A;
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;

                    tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    r = tr > 255 ? 255 : tr;
                    g = tg > 255 ? 255 : tg;
                    b = tb > 255 ? 255 : tb;

                    processed.SetPixel(x, y, Color.FromArgb(a, r, b, g));
                }
            return processed;

        }
    }
}