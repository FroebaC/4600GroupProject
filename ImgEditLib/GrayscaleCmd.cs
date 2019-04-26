using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;



namespace ImgEditLib
{
    public class GrayscaleCmd : Command
    {
        public override Bitmap Execute(Bitmap image)
        {
            Bitmap bitMapImage = new Bitmap(image);
            for(int i = 0; i < bitMapImage.Width; i++)
            {
                for(int j = 0; j < bitMapImage.Height; j++)
                {
                    Color pixelColor = bitMapImage.GetPixel(i, j);
                    //calculation for grayscale
                    int grayscale = (int)((pixelColor.R * .3) + (pixelColor.G * .59) + (pixelColor.B * .11));
                    Color newColor = Color.FromArgb(pixelColor.A, grayscale, grayscale, grayscale);
                    bitMapImage.SetPixel(i, j, newColor);
                    
                }
            }
            
            return bitMapImage;
            
        }

        
    }
}
