using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAscii
{
    public class BitmapAscii
    {
        public static string Asciitize(Bitmap bmp, int kernelHeight, int kernelWidth)
        {
            
            List<Color> colors = new();
            string asciiImage = "";

            try
            {
                if (bmp != null)
                {
                    if (kernelHeight >= 1 && kernelWidth >= 1)
                    {
                        //iterate through bitmap pixel columns & rows
                        for (int h = 0; h < bmp.Height; h += kernelHeight)
                        {
                            for (int w = 0; w < bmp.Width; w += kernelWidth)
                            {
                                //loops through columns & rows of kernels
                                for (int kernelY = 0; kernelY < kernelHeight; kernelY++)
                                {
                                    for (int kernelX = 0; kernelX < kernelWidth; kernelX++)
                                    {
                                        //get current color of each pixel and add to the list
                                        Color curColor = bmp.GetPixel(w, h);
                                        colors.Add(curColor);

                                        //adds relevant ascii character to string
                                        asciiImage += GrayToString(AveragePixel(bmp.GetPixel(w, h)));
                                    }
                                }

                                //converts to grayscale and clears the list
                                double grayScale = AverageColor(colors);
                                colors.Clear();
                                //string characters = GrayToString(grayScale);
                                //asciiImage += characters;

                            }

                            asciiImage += "\n";

                        }

                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose an image to convert.");
            }

            return asciiImage;
        }//end function

        private static double AveragePixel(int R, int G, int B)
        {
            //pixel color average & returns value
            double avg = (R + G + B) / 3;
            return avg;

        }//end function

        private static double AveragePixel(Color current)
        {
            //calculates normalized value of grayscale from RGB values & returns value
            double avg = 0;
            avg = current.R + current.G + current.B / 3;
            return avg;

        }//end function

        private static double AverageColor(List<Color> colors)
        {
            int red = 0;
            int green = 0;
            int blue = 0;

            for (int i = 0; i < colors.Count; i++)
            {
                //add the amount of each of the colors to the color variables
                red += colors[i].R;
                green += colors[i].G;
                blue += colors[i].B;

            }//end for loop

            //divides the color variables by the number of times those color elements are present in the list
            red = red / colors.Count;
            green = green / colors.Count;
            blue = blue / colors.Count;

            //return average of each color
            return AveragePixel(red, green, blue);

        }//end function

        private static string GrayToString(double grayScale)
        {
            //accepts the grayscale value & adds an ascii character (based on the range the value falls in)
            //to a new variable & returns it

            string characters = "";

            //determining which char to use in grayscale
            if (grayScale >= 0.0 && grayScale < 42.5)
            {
                characters = ".";
            }
            else if (grayScale >= 42.5 && grayScale < 85)
            {
                characters = ":";
            }
            else if (grayScale >= 85 && grayScale < 127.5)
            {
                characters = "*";
            }
            else if (grayScale >= 127.5 && grayScale < 170)
            {
                characters = "B";
            }
            else if (grayScale >= 170 && grayScale < 212.5)
            {
                characters = "$";
            }
            else { characters = " "; }
            
            return characters;

        }//end function

        public string ToString(string characters)
        {
            //returns ascii string
            return characters; 

        }

    }
}    


