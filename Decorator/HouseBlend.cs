namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() { }

        public override string GetDescription()
        {
            return "House Blend";
        }


        public override double Cost()
        {
            return 0.89;
        }
    }
}
