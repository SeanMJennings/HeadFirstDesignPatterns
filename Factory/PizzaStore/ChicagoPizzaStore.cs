using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Factory.Ingredients.Chicago;
using Factory.Ingredients.NY;
using Factory.Pizza;

namespace Factory.PizzaStore
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override void CreatePizza(Pizzas pizzaType)
        {
            switch (pizzaType)
            {
                case Pizzas.Clam:
                    this.Pizza = new ClamPizza(new ChicagoIngredientFactory());
                    this.Pizza.Name = "Chicago Style Clam Pizza";
                    break;
                case Pizzas.Cheese:
                    this.Pizza = new CheesePizza(new ChicagoIngredientFactory());
                    this.Pizza.Name = "Chicago Style Cheese Pizza";
                    break;
                case Pizzas.Pepperoni:
                    this.Pizza = new PepperoniPizza(new ChicagoIngredientFactory());
                    this.Pizza.Name = "Chicago Style Pepperoni Pizza";
                    break;
                case Pizzas.Veggie:
                    this.Pizza = new VeggiePizza(new ChicagoIngredientFactory());
                    this.Pizza.Name = "Chicago Style Veggie Pizza";
                    break;
                default:
                    throw new Exception();

            }
        }
    }
}

