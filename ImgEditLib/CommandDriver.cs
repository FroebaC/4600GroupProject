using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImgEditLib
{
    public class CommandDriver
    {

        private List<Command> commands;

        private Bitmap image;

        Command cmd = null;
        public CommandDriver()
        {
            commands = new List<Command>();
            image = new Bitmap("");

        }

        
        
        


    }
}
