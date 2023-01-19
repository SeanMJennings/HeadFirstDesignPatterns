namespace Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float temp;
        private float pressure;
        private float humidity;
        private IWeatherData weatherData;

        public CurrentConditionsDisplay(IWeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            this.temp = weatherData.Temp;
            this.pressure = weatherData.Pressure;
            this.humidity = weatherData.Humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"The current conditions: temp {temp}, pressure {pressure}, humidity {humidity}");
        }
    }
}
