namespace Composite
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        string name;
        string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void add(MenuComponent menuComponent) { menuComponents.Add(menuComponent); }

        public override void remove(MenuComponent menuComponent) { menuComponents.Remove(menuComponent); }

        public override MenuComponent getChild(int i) { return menuComponents[i]; }

        public override string getName() { return name; }
        public override string getDescription() { return description; }
        public override void print()
        {
            Console.WriteLine(getName() + " " + getDescription());
            Console.WriteLine("-------------");
            foreach(MenuComponent menuComponent in menuComponents)
            {
                menuComponent.print();
            }
        }
    }
}
