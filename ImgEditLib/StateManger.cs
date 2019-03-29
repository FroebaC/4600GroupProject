using System;
using System.Collections.Generic;
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

        }


        public void Load()
        {

        }

        public void AddToRecentProjects(string projectToAdd)
        {

        }




    }
}
