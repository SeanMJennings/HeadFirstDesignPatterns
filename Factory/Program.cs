using Factory.PizzaStore;

namespace Factory
{
    public class Program
    {
        public static void Main()
        {
            var nyPizzaStore = new NYPizzaStore();
            var chicagoPizzaStore = new ChicagoPizzaStore();

            var nyCheesePizza = nyPizzaStore.ServePizza(Pizza.Pizzas.Cheese);
            Console.WriteLine(nyCheesePizza.Name);


            var chicagoClamPizza = chicagoPizzaStore.ServePizza(Pizza.Pizzas.Clam);
            Console.WriteLine(chicagoClamPizza.Name);
        }
    }
}
