using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEditLib
{
    public class BrushCommand : Command
    {
        Bitmap Execute(Bitmap image)
        {
            return image;
        }
    }
}
