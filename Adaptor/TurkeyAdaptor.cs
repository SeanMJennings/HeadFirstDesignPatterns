namespace Adaptor
{
    public class TurkeyAdaptor : IAmADuck
    {
        private IAmATurkey turkey;

        public TurkeyAdaptor(IAmATurkey turkey) 
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            var random = new Random(5);
            if (random.Next() == 3)
            {
                this.turkey.ShortFly();
            }
        }

        public void Quack()
        {
            this.turkey.Gobble();
        }
    }
}
