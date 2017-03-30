using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ReadImageTester
{
    public class Program
    {
        [STAThread]
        private static void Main()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select an image:";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap bmp = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                Dictionary<int, int> histogram = new Dictionary<int, int>();
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color pixel = bmp.GetPixel(i, j);
                        
                        if(histogram.ContainsKey(pixel.R))
                        {
                            histogram[pixel.R]++;
                        }
                        else
                        {
                            histogram.Add(pixel.R, 1);
                        }

                    }
                }

                List<int> keys = new List<int>(histogram.Keys);
                keys.Sort();
                foreach(int key in keys)
                {
                    string text = "";
                    text += "[" + key + "] = " + histogram[key];
                    Console.WriteLine(text);
                }
                Console.ReadLine();
            }
        }
    }
}