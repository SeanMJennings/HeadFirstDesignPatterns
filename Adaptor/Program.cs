namespace Adaptor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var duck = new TurkeyAdaptor(new Turkey());
            ActionDuck(duck);
        }

        static void ActionDuck(IAmADuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}