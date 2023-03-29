namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus");
            allMenus.add(pancakeHouseMenu);
            allMenus.add(dinerMenu);

            pancakeHouseMenu.add(new MenuItem("Pancake", "Floppy", true, 7));
            dinerMenu.add(new MenuItem("Spaghetti", "Pasta", false, 10));
            dinerMenu.add(dessertMenu);
            dessertMenu.add(new MenuItem("Cake", "Sponge", true, 5));

            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();
        }
    }
}