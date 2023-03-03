namespace Iterator
{
    public class PancakeHouseMenu : Menu
    {
        private List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();
            AddItem("K&B's Pancake breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            AddItem("Regular Pancake breakfast", "Pancakes with fried eggs, sausage", true, 2.99);
            AddItem("Blueberry pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles wih your choice of blueberries or strawberries", true, 3.59);

        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public Iterator GetIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
