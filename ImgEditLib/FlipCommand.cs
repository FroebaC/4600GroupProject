﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEditLib
{
    public class FlipCommand : Command
    {
        Bitmap Execute(Bitmap image, string filename)
        {
            return image;
        }
    }
}
