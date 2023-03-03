namespace Iterator
{
    public class DinerMenu : Menu
    {
        private static readonly int MAX_ITEMS = 6;
        private int numberofItems = 0;
        private MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            AddItem("Veggie BLT", "Veggie Bacon, lettuce, tomato", true, 3.00);
            AddItem("BLT", "Bacon, lettuce, tomato", false, 3.00);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberofItems >= MAX_ITEMS)
            {
                throw new Exception("Menu is full!");
            }
            else
            {
                menuItems[numberofItems] = menuItem;
                numberofItems++;
            }
        }

        public Iterator GetIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
