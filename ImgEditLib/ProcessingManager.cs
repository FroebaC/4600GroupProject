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
                    //just put magic numbers, 
                    //needs to be switched so user can pick what to crop, 
                    //will be done with mouse clicks on the canvas
                    transform.Crop(image,image.Width*.25, 
                        image.Height * .75, 
                        image.Width * .5, 
                        image.Height);
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
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
