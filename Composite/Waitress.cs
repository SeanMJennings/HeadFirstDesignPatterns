﻿namespace Composite
{
    public class Waitress
    {
        private MenuComponent menu;

        public Waitress(MenuComponent menu)
        {
            this.menu = menu;
        }

        public void PrintMenu()
        {
            menu.print();
        }
    }
}
