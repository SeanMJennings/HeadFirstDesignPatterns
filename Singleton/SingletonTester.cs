namespace Singleton
{
    public class SingletonTester
    {
        public SingletonTester() 
        {
            var instance = Singleton.GetInstance();
            instance.testValue++;
            Console.WriteLine(instance.testValue);
        }
    }
}
