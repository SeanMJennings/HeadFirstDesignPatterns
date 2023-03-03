namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            var coffee = new Coffee();

            tea.Recipe();
            coffee.Recipe();
        }
    }
}