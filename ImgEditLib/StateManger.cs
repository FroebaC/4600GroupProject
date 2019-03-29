using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEditLib
{
    class StateManger
    {

        private Stack<ImageManager> undoStack;
        private Stack<ImageManager> redoStack;
        private List<string> recentProjects;
        private Image image;



        public Stack<ImageManager> UndoStack
        {
            get
            {
                return undoStack;
            }

            set
            {
                undoStack = value;
            }
        }

        public Stack<ImageManager> RedoStack
        {
            get
            {
                return redoStack;
            }

            set
            {
                redoStack = value;
            }
        }

        public List<string> RecentProjects
        {
            get
            {
                return recentProjects;
            }

            set
            {
                recentProjects = value;
            }
        }

        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public StateManger()
        {
            Stack<ImageManager> undoStack = new Stack<ImageManager>();
            Stack<ImageManager> redoStack = new Stack<ImageManager>();
        }

        public void Undo()
        {
            
        }

        public void Redo()
        {

        }

        public void Save()
        {
            Console.WriteLine("Please enter a file name to save as: ");

            //this should be done better, should check for alot of things so errors dont occur.
            Image.Save(Console.ReadLine());
        }


        public Image Load()
        {
            Console.WriteLine("Please enter a file name to open");

            //this is bad, it needs to be checked
            Image = Image.FromFile(Console.ReadLine());

            return Image;
        }

        public void AddToRecentProjects(string projectToAdd)
        {
            RecentProjects.Add(projectToAdd);
        }




    }
}
