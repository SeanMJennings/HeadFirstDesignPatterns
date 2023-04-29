using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Timer = System.Timers.Timer;

namespace MVC.Model
{
    internal class BpmModel : IBpmModel, IBpmObservable, IReadOnlyBpmModel
    {
        private int Bpm;
        private Timer timer;
        private IList<IBpmObserver> observers;

        public BpmModel()
        {
            Bpm = 60;
            timer = new Timer();
            ChangeTimer(false); 
            timer.Elapsed += new ElapsedEventHandler(Beat);
            observers = new List<IBpmObserver>();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop() 
        {
            timer.Stop();
        }

        public void SetBpm(int bpm)
        {
            Bpm = bpm;
            ChangeTimer();
        }

        public int GetBpm()
        {
            return Bpm;
        }

        public void IncrementBpm()
        {
            Bpm++;
            ChangeTimer();
        }

        public void DecrementBpm()
        {
            Bpm--;
            ChangeTimer();
        }

        public void RegisterObserver(IBpmObserver bpmObserver)
        {
            observers.Add(bpmObserver);
        }

        public void NotifyObservers()
        {
            foreach(IBpmObserver observer in observers) 
            {
                observer.UpdateBpm(this);
            }
        }

        private void Beat(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"Beat");
            NotifyObservers();
        }

        private void ChangeTimer(bool start = true)
        {
            timer.Stop();
            timer.Interval = 60000 / Bpm;
            if (start ) { timer.Start(); }
        }
    }
}
