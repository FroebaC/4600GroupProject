using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEditLib
{
    public class CropCmd : Command
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public CropCmd(Bitmap image)
        {
            x1 = 0;
            y1 = 0;

            x2 = image.Height;
            x2 = image.Width;
            
        }
        Bitmap Execute(Bitmap image)
        {

            return image;
        }

    }
}
