namespace Adaptor
{
    public interface IAmADuck
    {
        public void Fly();

        public void Quack();
    }

    public class Duck : IAmADuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm a flying duck");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}