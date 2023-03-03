namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var breakfastMenu = new PancakeHouseMenu();
            var lunchMenu = new DinerMenu();
            var waitress = new Waitress(breakfastMenu, lunchMenu);
            waitress.PrintMenu();
        }
    }
}