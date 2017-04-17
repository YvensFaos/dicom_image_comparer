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
        private byte[] fileBytes;

        public MainForm()
        {
            InitializeComponent();

            string defaultFile = @"C:\Users\Yvens\Desktop\preview (1).png";
            try
            {
                bmp = (Bitmap)Image.FromFile(defaultFile);
                openFileAtPanel(defaultFile, panelImage, bmp);

                logMessage("Loaded file: " + defaultFile, true);
            }
            catch (FileNotFoundException)
            {
                logMessage("Error loading default file: " + defaultFile, true);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image:";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelFile.Text = openFileDialog.FileName;
                bmp = (Bitmap)Image.FromFile(openFileDialog.FileName);
                openFileAtPanel(openFileDialog.FileName, panelImage, bmp);

                logMessage("Loaded file: " + openFileDialog.FileName, true);
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

            logMessage("File processed!", true);
        }

        private byte calculateColor(short c, double wMin, double wMax, double WinCenter, double WinWidth)
        {
            if (c <= wMin)
            {
                return 0;
            }
            else if (c >= wMax)
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

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                processedBmp.Save(saveFileDialog.FileName);

                logMessage("File saved at: " + saveFileDialog.FileName, true);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image:";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                processedBmp = (Bitmap)Image.FromFile(openFileDialog.FileName);
                Rectangle bounds = panelProcessed.Bounds;
                panelProcessed.SetBounds(bounds.X, bounds.Y, processedBmp.Width, processedBmp.Height);
                panelProcessed.BackgroundImage = processedBmp;
                buttonSaveProcessed.Enabled = true;

                logMessage("Loaded file: " + openFileDialog.FileName, true);
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

            string log = "Compared files:\r\n" +
                "Mean [0-255]: " + mean.ToString() + "\r\n" +
                "Mean (0-255): " + meanS.ToString() + "\r\n";

            logMessage(log);
        }

        private void buttonLoadRaw_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a raw file:";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileBytes = File.ReadAllBytes(openFileDialog.FileName);
                logMessage("Raw file loaded: " + openFileDialog.FileName, true);
                logMessage("Raw loaded with " + textBoxCenter.Text + " " + textBoxWidth.Text, true);

                readRawFile();

                Rectangle bounds = panelProcessed.Bounds;
                panelProcessed.SetBounds(bounds.X, bounds.Y, processedBmp.Width, processedBmp.Height);
                panelProcessed.BackgroundImage = processedBmp;

                buttonSaveProcessed.Enabled = true;
            }
        }

        private void readRawFile()
        {
            int k = 0;
            int currentCenter = int.Parse(textBoxCenter.Text);
            int currentWidth = int.Parse(textBoxWidth.Text);

            var wMin = currentCenter - 0.5 - (currentWidth - 1) / 2;
            var wMax = currentCenter - 0.5 + (currentWidth - 1) / 2;
            Color color;

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
        }

        private void logMessage(string message, bool line = false)
        {
            string breakline = (line) ? "\r\n" : "";

            textBoxLog.Text = message + breakline + textBoxLog.Text;
        }

        private void buttonReloadRaw_Click(object sender, EventArgs e)
        {
            logMessage("Raw reloaded with " + textBoxCenter.Text + " " + textBoxWidth.Text, true);

            readRawFile();

            Rectangle bounds = panelProcessed.Bounds;
            panelProcessed.SetBounds(bounds.X, bounds.Y, processedBmp.Width, processedBmp.Height);
            panelProcessed.BackgroundImage = processedBmp;

            buttonSaveProcessed.Enabled = true;
        }

        private void buttonRawAsGrayscale_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a raw file:";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileBytes = File.ReadAllBytes(openFileDialog.FileName);
                logMessage("Raw file loaded: " + openFileDialog.FileName, true);

                int k = 0;

                short pixelPadding = short.Parse(textBoxPixelPadding.Text);
                short max = short.MinValue;
                short min = short.MaxValue;

                processedBmp = new Bitmap(bmp.Width, bmp.Height);
                for (int i = 0; i < bmp.Height; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        short s = (short)((fileBytes[k + 1] << 8) | fileBytes[k]);
                        k += 2;

                        if (s != pixelPadding)
                        {
                            max = Math.Max(max, s);
                            min = Math.Min(min, s);
                        }
                    }
                }

                Color color;
                short value;
                float normalized;
                k = 0;
                for (int i = 0; i < bmp.Height; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        short s = (short)((fileBytes[k + 1] << 8) | fileBytes[k]);
                        k += 2;

                        if (s == pixelPadding)
                        {
                            color = Color.FromArgb(0, 0, 0);
                        }
                        else
                        {
                            normalized = ((float)((float)(s - min) / (float)max)) * 255;
                            value = (short)Math.Floor(normalized);
                            value = (value > 255) ? (short)255 : value;
                            value = (value < 0) ? (short)0 : value;
                            color = Color.FromArgb(value, value, value);
                        }

                        processedBmp.SetPixel(j, i, color);
                    }
                }

                Rectangle bounds = panelProcessed.Bounds;
                panelProcessed.SetBounds(bounds.X, bounds.Y, processedBmp.Width, processedBmp.Height);
                panelProcessed.BackgroundImage = processedBmp;

                logMessage("Raw loaded as grayscale. Max and Min = " + max.ToString() + " " + min.ToString(), true);
                buttonSaveProcessed.Enabled = true;
            }
        }
    }
}