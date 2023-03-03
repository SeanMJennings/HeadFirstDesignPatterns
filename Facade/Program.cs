namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var homeTheatre = new HomeTheatreFacade(new Amplifier(), new Projector(), new Screen());
            homeTheatre.StartHomeTheatre();
            homeTheatre.EndHomeTheatre();
        }
    }
}