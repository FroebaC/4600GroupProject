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
        Bitmap ReturnImage;
        public Bitmap returnImg
        {
            get { return ReturnImage; }
        }

        public CommandDriver(Bitmap original, Command cmd)
        {
            commands.Add(cmd);
            ReturnImage = cmd.Execute(original);
        }

        
        
        


    }
}
