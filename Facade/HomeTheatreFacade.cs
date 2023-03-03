namespace Facade
{
    public class HomeTheatreFacade
    {
        private Amplifier amplifier;
        private Projector projector;
        private Screen screen;

        public HomeTheatreFacade(Amplifier amplifier, Projector projector, Screen screen)
        {
            this.amplifier = amplifier;
            this.projector = projector;
            this.screen = screen;
        }

        public void StartHomeTheatre()
        {
            this.amplifier.TurnOnAmplifier();
            this.projector.TurnOnProjector();
            this.screen.TurnOnScreen();
        }

        public void EndHomeTheatre()
        {
            this.amplifier.TurnOffAmplifier();
            this.projector.TurnOffProjector();
            this.screen.TurnOffScreen();
        }
    }
}
