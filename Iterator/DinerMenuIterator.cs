namespace Iterator
{
    public class DinerMenuIterator : Iterator
    {
        private MenuItem[] menuItems;
        private int position = 0;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext()
        {
            return position < menuItems.Length;
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
