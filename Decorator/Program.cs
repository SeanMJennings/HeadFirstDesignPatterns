namespace Decorator
{
    public class Program
    {
        public static void Main()
        {
            Beverage drink = new Soy(new Mocha(new Mocha(new HouseBlend())));
            Console.WriteLine(drink.Cost());
            Console.WriteLine(drink.GetDescription());
        }
    }
}