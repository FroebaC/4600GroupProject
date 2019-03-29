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
            Console.WriteLine("Please select an option (1-9): ");

            //asks the user which option they want to transform
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    transform.BrightnessCorrect(image);
                    break;
                case 2:
                    transform.ColorCorrect(image);
                    break;
                case 3:
                    //just put default values, not enough time to get user to pick that will be something that needs to be fixed
                    transform.Crop(image,image.Width*.25, image.Height * .75, image.Width * .5, image.Height);
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                default: throw new ArgumentOutOfRangeException("Please use a propper case.");
                    
                    
            }
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
