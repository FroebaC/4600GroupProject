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

        private static List<Command> commands;

        //private Bitmap image;

        //Command cmd;
        public CommandDriver(Bitmap original, Command cmd)
        {
            commands.Add(cmd);
            

        }

        
        
        


    }
}
