using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ImgEditLib
{
    public class ImageManager
    {
        private List<Image> images;
        private StateManger stateManager;
        private ProcessingManager processingManager;

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

        public ImageManager()
        {
            StateManger StateManager = new StateManger();
            List<Image> Images = new List<Image>();
            ProcessingManager ProcessingManager = new ProcessingManager();
        }

        public Image InvokeProcessingManager(Image image)
        {
            return image;
        }

        public void InvokeStateManager()
        {

        }


    }
}
