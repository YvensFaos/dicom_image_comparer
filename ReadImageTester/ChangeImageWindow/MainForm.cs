using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ChangeImageWindow
{
    public partial class MainForm : Form
    {
        private Bitmap bmp;
        private Bitmap processedBmp;

        public MainForm()
        {
            InitializeComponent();

            string defaultFile = @"C:\Users\yvens\Desktop\preview (1).png";
            bmp = (Bitmap)Image.FromFile(defaultFile);
            openFileAtPanel(defaultFile, panelImage, bmp);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image:";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                labelFile.Text = openFileDialog.FileName;
                bmp = (Bitmap)Image.FromFile(openFileDialog.FileName);
                openFileAtPanel(openFileDialog.FileName, panelImage, bmp);
            }
        }

        private void openFileAtPanel(string fileName, Panel panel, Bitmap bmp)
        {
            Rectangle bounds = panel.Bounds;
            panel.SetBounds(bounds.X, bounds.Y, bmp.Width, bmp.Height);
            panel.BackgroundImage = (Bitmap)Image.FromFile(fileName); ;
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            processedBmp = new Bitmap(bmp.Width, bmp.Height);
            int currentCenter = int.Parse(textBoxCenter.Text);
            int currentWidth = int.Parse(textBoxWidth.Text);

            double difCenter = currentCenter - 40;
            double difWidth = currentWidth - 400;
            int WinCenter = 127 + (int)difCenter;
            int WinWidth = 255 + (int)difWidth;

            var wMin = WinCenter - 0.5 - (WinWidth - 1) / 2;
            var wMax = WinCenter - 0.5 + (WinWidth - 1) / 2;
            Color color;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    color = bmp.GetPixel(i, j);
                    color = Color.FromArgb(
                        calculateColor(color.R, wMin, wMax, WinCenter, WinWidth),
                        calculateColor(color.G, wMin, wMax, WinCenter, WinWidth),
                        calculateColor(color.B, wMin, wMax, WinCenter, WinWidth));

                    processedBmp.SetPixel(i, j, color);
                }
            }

            Rectangle bounds = panelProcessed.Bounds;
            panelProcessed.SetBounds(bounds.X, bounds.Y, bmp.Width, bmp.Height);
            panelProcessed.BackgroundImage = processedBmp;
            buttonSaveProcessed.Enabled = true;
        }

        private byte calculateColor(short c, double wMin, double wMax, double WinCenter, double WinWidth)
        {
            if (c <= wMin)
            {
                return 0;
            }
            else if (c > wMax)
            {
                return 255;
            }
            else
            {
                return (byte)(((c - (WinCenter - 0.5)) / (WinWidth - 1) + 0.5) * 255);
            }
        }

        private void buttonSaveProcessed_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save image:";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                processedBmp.Save(saveFileDialog.FileName);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image:";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                processedBmp = (Bitmap)Image.FromFile(openFileDialog.FileName);
                Rectangle bounds = panelProcessed.Bounds;
                panelProcessed.SetBounds(bounds.X, bounds.Y, processedBmp.Width, processedBmp.Height);
                panelProcessed.BackgroundImage = processedBmp;
                buttonSaveProcessed.Enabled = true;
            }
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            float mean = 0;
            float meanS = 0;
            int countS = 0;
            int red = 0;
            int sum = 0;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    red = bmp.GetPixel(i, j).R;
                    sum = red - processedBmp.GetPixel(i, j).R;
                    mean += sum;
                    if (red != 0 && red != 255)
                    {
                        meanS += sum;
                        countS++;
                    }
                }
            }

            mean /= (bmp.Width * bmp.Height);
            meanS /= countS;

            textBoxMean.Text = mean.ToString();
            textBoxMeanS.Text = meanS.ToString();
        }

        private void buttonLoadRaw_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a raw file:";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                byte[] fileBytes = File.ReadAllBytes(openFileDialog.FileName);
                int k = 0;
                int currentCenter = int.Parse(textBoxCenter.Text);
                int currentWidth = int.Parse(textBoxWidth.Text);

                var wMin = currentCenter - 0.5 - (currentWidth - 1) / 2;
                var wMax = currentCenter - 0.5 + (currentWidth - 1) / 2;
                Color color;

                uint pixelPadding = uint.Parse(textBoxPixelPadding.Text);

                processedBmp = new Bitmap(bmp.Width, bmp.Height);

                for (int i = 0; i < bmp.Height; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        short s = (short)((fileBytes[k + 1] << 8) | fileBytes[k]);
                        k += 2;

                        color = Color.FromArgb(
                        calculateColor(s, wMin, wMax, currentCenter, currentWidth),
                        calculateColor(s, wMin, wMax, currentCenter, currentWidth),
                        calculateColor(s, wMin, wMax, currentCenter, currentWidth));

                        processedBmp.SetPixel(j, i, color);
                    }
                }

                Rectangle bounds = panelProcessed.Bounds;
                panelProcessed.SetBounds(bounds.X, bounds.Y, processedBmp.Width, processedBmp.Height);
                panelProcessed.BackgroundImage = processedBmp;
            }
        }
    }
}