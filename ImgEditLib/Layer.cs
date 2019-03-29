using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEditLib
{
    public class Layer
    {
        private List<Image> images;

        public List<Image> Images
        {
            get
            {
                return images;
            }

            set
            {
                images = value;
            }
        }

        public Layer()
        {

        }


        public List<Image> SendToFront(List<Image> images)
        {
            return images;
        }


        public List<Image> SendToBack(List<Image> images)
        {
            return images;
        }















    }
}
