namespace Observer
{
    public class ForecastDisplay : IObserver, IDisplay
    {
        private float temp;
        private float pressure;
        private float humidity;
        private IWeatherData weatherData;

        public ForecastDisplay(IWeatherData weatherData)
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
            Console.WriteLine($"The forecast: temp {temp + 1}, pressure {pressure + 1}, humidity {humidity + 1}");
        }
    }
}
