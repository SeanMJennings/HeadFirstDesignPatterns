namespace Adaptor
{
    public interface IAmATurkey
    {
        public void ShortFly();

        public void Gobble();
    }

    public class Turkey : IAmATurkey
    {
        public void ShortFly()
        {
            Console.WriteLine("Short flight");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}