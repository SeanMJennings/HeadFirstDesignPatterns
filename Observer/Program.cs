namespace Observer
{
    public class Program
    {
        public static void Main()
        {
            WeatherData weatherData = new WeatherData();
            weatherData.Temp = 10;
            weatherData.Pressure = 15;
            weatherData.Humidity = 20;

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.NotifyObservers();
            weatherData.RemoveObserver(currentConditionsDisplay);
            weatherData.NotifyObservers();
        }
    }
}