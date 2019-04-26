using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEditLib
{
    public class SepiaCmd : Command
    {
        public override Bitmap Execute(Bitmap image)
        {
            Bitmap bitMapImage = new Bitmap(image);
            for (int i = 0; i < bitMapImage.Width; i++)
            {
                for (int j = 0; j < bitMapImage.Height; j++)
                {
                    Color pixelColor = bitMapImage.GetPixel(i, j);

                    int grayscale = (int)((pixelColor.R * .3) + (pixelColor.G * .59) + (pixelColor.B * .11));
                    //have to grayscale the image first
                    Color newColor = Color.FromArgb(pixelColor.A, grayscale, grayscale, grayscale);

                    //then color correct for sepia
                    Color sepia = Color.FromArgb((int)newColor.R*1, (int)(newColor.G * 0.95), (int)(newColor.B * 0.82)) ;
                    bitMapImage.SetPixel(i, j, sepia);

                }
            }

            return bitMapImage;

        }
    }
}
