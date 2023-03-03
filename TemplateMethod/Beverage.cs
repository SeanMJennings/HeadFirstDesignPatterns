namespace TemplateMethod
{
    public abstract class Beverage
    {
        public Beverage() { }

        public void Recipe()
        {
            BoilWater();
            PourInCup();
            Brew();
            AddCondiment();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boil water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pour in cup");
        }

        public abstract void Brew();

        public abstract void AddCondiment();
    }
}
