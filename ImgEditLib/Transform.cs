using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEditLib
{
    public class Transform
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

        public Transform()
        {

        }

        public Image Erase(Image image, int x, int y)
        {
            return image;
        }


        public Image Scale(Image image, int xScale, int yScale)
        {
            return image;
        }

        public Image Flip(Image image)
        {
            return image;
        }

        public Image Crop(Image image, double x1, double y1, double x2, double y2)
        {
            return image;
        }

        public Image Grayscale(Image image)
        {
            return image;
        }

        public Image Sapia(Image image)
        {
            return image;
        }

        public Image ColorCorrect(Image image)
        {
            return image;
        }

        public Image BrightnessCorrect(Image image)
        {
            return image;
        }









    }
}
