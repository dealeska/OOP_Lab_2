using System;

namespace OOP_Lab_1
{
    public abstract class MenuItem
    {
        protected static Int32 indexOfMenu;
        public float Cost { get; protected set; }
        public bool ExtraFood { get; set; }

        static MenuItem()
        {
            indexOfMenu = 0;
        }

        public MenuItem() { }

        protected void IncIdexMenu()
        {
            indexOfMenu++;
        }

        public abstract string WriteDescription();
        //public abstract void AskClient();
        public virtual string GetHierarchy()
        {
            IncIdexMenu();
            return indexOfMenu.ToString() + ".";            
        }
    }

}
