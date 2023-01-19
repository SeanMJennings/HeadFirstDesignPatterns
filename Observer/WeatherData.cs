namespace Observer
{
    public interface IWeatherData : ISubject
    {
        public float Temp { get; set; }

        public float Pressure { get; set; }

        public float Humidity { get; set; }
    }

    public class WeatherData : IWeatherData
    {
        private List<IObserver> observers;
        private float temp;
        private float pressure;
        private float humidity;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public float Temp
        {
            get => temp;
            set => temp = value;
        }

        public float Pressure
        {
            get => pressure;
            set => pressure = value;
        }

        public float Humidity
        {
            get => humidity;
            set => humidity = value;
        }
    }
}
