namespace Strategy
{
    public class Quacker : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("*silence*");
        }
    }

    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("*squeak*");
        }
    }

    public interface IQuackBehaviour
    {
        public void Quack();
    }
}
