using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GammaCorrectionCsDLL;


namespace GammaCorrection
{
    public partial class Form1 : Form
    {
        private ASMCorrection AsemblerCorrection;
        private byte[] rgbValues;
        private Stopwatch sw;
        private static float gamma;

        public Form1()
        {
            //byte[] x = {255,255,255 };
            InitializeComponent();
            sw = new Stopwatch();
            //GammaCorrectionCode(x ,4);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selcect File";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Images (*.jpg)|*.jpg|Images (*.png)|*.png";
            ofd.FilterIndex = 1;
            ofd.ShowDialog();

            if(ofd.FileName != "")
            {
                //Wczytywanie zdjęcia do podlgądu 
                sourceTextArea.Text = ofd.FileName;
                pictureBoxDefault.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxDefault.ImageLocation = ofd.FileName;
                pictureBoxModified.SizeMode = PictureBoxSizeMode.StretchImage;
                ButtonModify.Enabled = true;
            }
            else
            {
                sourceTextArea.Text = "No image";
            }
        }

        //change photo using c#
        private void PixelManipulation(PictureBox pBox, String path, int numberOfThreads, bool ASM)
        {
            // Create a new bitmap.
            Bitmap bmp = new Bitmap(path);

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0,0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;

            rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            if (ASM == false)
            {
                rgbValues = GammaDLL.CalculateGammaParallel(rgbValues, numberOfThreads);      
            }
            else if (ASM == true)
            {  
                rgbValues = UnwrapArray(CalculateGammaParallelASM(PreparePixel(rgbValues), numberOfThreads));
            }

            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, rgbValues.Length);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);

            // Draw the modified image.
            pBox.Image = bmp;
        }

        private float[][] CalculateGammaParallelASM(float[][] pixelsss, int numberOfThreads)
        {
            gamma = (float)Math.Pow(gamma, -1);

            Parallel.For(0, pixelsss.Length, new ParallelOptions { MaxDegreeOfParallelism = numberOfThreads }, i =>
            {
                AsemblerCorrection = new ASMCorrection(pixelsss[i], Convert.ToInt32(gamma));
                AsemblerCorrection.GammaCorr(pixelsss[i]);
            });

            return pixelsss;
        }

        private float[][] PreparePixel(byte[] allValues)
        {
            int numberOfPixels = allValues.Length; // / 3; //chyba ze jest tez aplha to 4

            float[][] pixels = new float[numberOfPixels][];
            int pixelPos = 0;

            for (int i = 0; i <= numberOfPixels; i += 3)
            {
                if (i < numberOfPixels)
                {
                    float[] normalizedPixel = new float[3];

                    normalizedPixel[0] = (float)allValues[i] / 255;
                    normalizedPixel[1] = (float)allValues[i + 1] / 255;
                    normalizedPixel[2] = (float)allValues[i + 2] / 255;

                    pixels[pixelPos] = normalizedPixel;
                    pixelPos++;
                }
            }

            pixels = pixels.Where(x => x != null).ToArray();

            return pixels;
        }

        private byte[] UnwrapArray(float[][] data)
        {
            List<byte> flattenedPixels = new List<byte>();
            float normalized = 0;

            for (int i = 0; i < data.Length - 1; i++)// <- TUTAJ
            {
                for (int j = 0; j < 3; j++)
                {
                    normalized = data[i][j];
                    normalized *= 255.0f;

                    flattenedPixels.Add(Convert.ToByte(normalized));
                }
            }

            return flattenedPixels.ToArray();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            gamma = SetGamma();

            GammaDLL.gamma = gamma;

            sw.Restart();

            if (radioCsLib.Checked == true)
            {
                sw.Start();
                PixelManipulation(pictureBoxModified, pictureBoxDefault.ImageLocation, sliderThread.Value, false);
                sw.Stop();
            }
            else if(radioAsemblyLib.Checked == true)
            {
                sw.Start();
                PixelManipulation(pictureBoxModified, pictureBoxDefault.ImageLocation, sliderThread.Value, true);
                sw.Stop();
            }

            ButtonSave.Enabled = true;

            labelTime.Text = "Time: " + sw.Elapsed.TotalMilliseconds.ToString("0.00") + " ms";
        }

        private float SetGamma()
        {
            if (sliderGamma.Value.Equals(1)) // 1/4
            {
                return 0.25f;
            }
            else if (sliderGamma.Value.Equals(2)) // 1/3
            {
                return 0.33f;
            }
            else if (sliderGamma.Value.Equals(3)) // 1/2
            {
                return 0.5f;
            }
            else if (sliderGamma.Value.Equals(4)) // 1
            {
                return 1.0f;
            }
            else if (sliderGamma.Value.Equals(5)) // 2
            {
                return 4.0f;
            }
            else
            {
                return 1.0f;
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            labelThreadUsed.Text = "Threads Used: " + sliderThread.Value.ToString();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png|JPEG|*.jpg" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxModified.Image.Save(saveFileDialog.FileName);
                }
            }         
        }

        private void pictureBoxDefault_Click(object sender, EventArgs e)
        {

        }
    } 
}
