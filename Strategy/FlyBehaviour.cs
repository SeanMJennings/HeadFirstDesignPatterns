namespace Strategy
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }

    public class FlyWithRockets : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with rockets");
        }
    }

    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

    public interface IFlyBehaviour
    {
        public void Fly();
    }
}
