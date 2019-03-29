using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEditLib
{
    public class ProcessingManager
    {

        private Transform transform;
        private Draw draw;
        private Layer layer;
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

        public ProcessingManager()
        {
            Images = new List<Image>();

        }

        public ProcessingManager(List<Image> images)
        {
            Images = this.images;
        }


        public Image TransformImage(Image image)
        {
            return image;
        }

        public List<Image> LayerImages(List<Image> images)
        {
            return images;
        }

        public Image Drawing(Image image)
        {
            return image;
        }






    }
}
