namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var breakfastMenu = new PancakeHouseMenu();
            var lunchMenu = new DinerMenu();
            var waitress = new Waitress(new List<Menu> { breakfastMenu, lunchMenu });
            waitress.PrintMenu();
        }
    }
}