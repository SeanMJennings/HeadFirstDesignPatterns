namespace Composite
{
    public class MenuItem : MenuComponent
    {
        string name;
        string description;
        bool vegetarian;
        double price;

        public MenuItem(
            string name,
            string description,
            bool vegetarian,
            double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override string getName() { return name; }
        public override string getDescription() { return description; }
        public override double getPrice() { return price; }
        public override bool isVegetarian() { return vegetarian; }
        public override void print()
        {
            Console.WriteLine(getName() + " " + (isVegetarian() ? "(v)" + " " : string.Empty) + " " + getPrice() + " " + getDescription());
        }
    }
}
