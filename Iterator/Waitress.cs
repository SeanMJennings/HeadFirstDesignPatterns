namespace Iterator
{
    public class Waitress
    {
        private List<Menu> menuList;

        public Waitress(List<Menu> menus)
        {
            this.menuList = menus;
        }

        public void PrintMenu()
        {
            foreach(Menu menu in menuList)
            {
                PrintMenu(menu);
            }
        }

        public void PrintMenu(Menu menu)
        {
            var iterator = menu.GetIterator();
            while(iterator.HasNext())
            {
                var menuItem = iterator.Next();
                Console.WriteLine(menuItem);
            }
        }
    }
}
