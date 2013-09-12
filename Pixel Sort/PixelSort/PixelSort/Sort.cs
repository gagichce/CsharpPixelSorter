﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelSort
{
    class Sort
    {
        Bitmap tempBitmap;
        Image originalImage;
        public Sort(Image thisImage)
        {
            tempBitmap = new Bitmap(thisImage);
            originalImage = thisImage;
        }

        public Image SortImage(float tolerance)
        {
            for (int y = 1; y < tempBitmap.Height - 1; y++)
            {
                List<Color> similarPixels = new List<Color>();
                Color lastUniquePixel = tempBitmap.GetPixel(0, y);
                similarPixels.Add(lastUniquePixel);
                for (int x = 1; x < tempBitmap.Width; x++)
                {
                    Color thisPixel = tempBitmap.GetPixel(x, y);
                    if (ComparePixel(thisPixel, lastUniquePixel, tolerance) && ComparePixel(tempBitmap.GetPixel(x, y + 1), lastUniquePixel, tolerance) && ComparePixel(tempBitmap.GetPixel(x - 1, y + 1), lastUniquePixel, tolerance))
                    {
                        similarPixels.Add(thisPixel);
                        tempBitmap.SetPixel(x, y, lastUniquePixel);
                    }
                    else
                    {
                        similarPixels.Clear();
                        lastUniquePixel = thisPixel;
                        similarPixels.Add(thisPixel);
                    }
                }
            }

            return (Image)tempBitmap;
        }
        public Image SortImage2(float tolerance)
        {
            for (int y = 1; y < tempBitmap.Height - 1; y++)
            {
                List<Color> similarPixels = new List<Color>();
                Color lastUniquePixel = tempBitmap.GetPixel(0, y);
                similarPixels.Add(lastUniquePixel);
                for (int x = 1; x < tempBitmap.Width; x++)
                {
                    Color thisPixel = tempBitmap.GetPixel(x, y);
                    if (ComparePixel(thisPixel, lastUniquePixel, tolerance) && ComparePixel(tempBitmap.GetPixel(x, y + 1), lastUniquePixel, tolerance) && ComparePixel(tempBitmap.GetPixel(x - 1, y + 1), lastUniquePixel, tolerance))
                    {
                        similarPixels.Add(thisPixel);
                        tempBitmap.SetPixel(x, y, lastUniquePixel);
                    }
                    else
                    {
                        Color averagePixel = AverageColour(similarPixels);
                        for (int xMod = 0; xMod < similarPixels.Count; xMod++)
                        {
                            tempBitmap.SetPixel(x - xMod, y, averagePixel);
                        }
                        similarPixels.Clear();
                        lastUniquePixel = thisPixel;
                        similarPixels.Add(thisPixel);
                    }
                }
            }

            return (Image)tempBitmap;
        }
        private Color AverageColour(List<Color> inputColors)
        {
            int red = 0;
            int blue = 0;
            int green = 0;
            int alpha = 0;

            foreach (Color thisColour in inputColors)
            {
                red += thisColour.R;
                blue += thisColour.B;
                green += thisColour.G;
                alpha += thisColour.A;
            }
            return Color.FromArgb(alpha / inputColors.Count, red / inputColors.Count, green / inputColors.Count, blue / inputColors.Count);
        }
        private bool ComparePixel(Color pixel1, Color pixel2, float tolerance)
        {
            //if ((new Random()).Next(0, 4) == 0)
            //{
            //    return false;
            //}
            if (withinRange(pixel1.A, pixel2.A, tolerance * 1.4f) && withinRange(pixel1.B, pixel2.B, tolerance) && withinRange(pixel1.G, pixel2.G, tolerance) && withinRange(pixel1.R, pixel2.R, tolerance))
                return true;
            return false;
        }

        private bool withinRange(int first, int second, float tolerance)
        {
            return ((float)Math.Abs(first - second)) / 256 < tolerance;
        }
    }
}