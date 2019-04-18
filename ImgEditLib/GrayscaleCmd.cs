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
        public Bitmap Execute(Bitmap image, string filename)
        {
            Bitmap bitMapImage = new Bitmap(image);
            for(int i = 0; i < bitMapImage.Width; i++)
            {
                for(int j = 0; j < bitMapImage.Height; j++)
                {
                    Color pixelColor = bitMapImage.GetPixel(i, j);
                    Color newColor = Color.Gray;
                    //Color newColor = Color.FromArgb(pixelColor.R,0,0);
                    bitMapImage.SetPixel(i, j, newColor);
                    
                }
            }
            bitMapImage.Save(filename);
            
            
            return bitMapImage;
            
        }

        
    }
}
