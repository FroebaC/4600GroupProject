using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEditLib
{
    public abstract class Command
    {
        private Bitmap original;
        private string pathName;
        public virtual Bitmap Execute(Bitmap input, string pathName)
        {
            original = input;
            return original;
        }

        
    }
}
