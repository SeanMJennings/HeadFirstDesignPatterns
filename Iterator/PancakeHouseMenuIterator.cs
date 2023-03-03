namespace Iterator
{
    public class PancakeHouseMenuIterator : Iterator
    {
        private List<MenuItem> menuItems;
        private int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext()
        {
            return position < menuItems.Count;
        }

        public MenuItem Next()
        {
            if (!HasNext()) 
            {
                throw new Exception("No more items!");
            }
            var menuItem = menuItems[position];
            position++;
            return menuItem;
        }
    }
}
