using MVC.Controller;
using MVC.Model;

namespace MVC.View
{
    internal class BpmView : IBpmView, IBpmObserver
    {
        private IBpmController bpmController;
        private IReadOnlyBpmModel model;
        private bool CanStart;
        private bool CanStop;

        /* 
         * View is ideally UI that acts as a composite to hold internal controls. markup counts as composite
        */
        public BpmView(IBpmController bpmController, IReadOnlyBpmModel model)
        {
            this.model = model;
            ((IBpmObservable)this.model).RegisterObserver(this);
            this.bpmController = bpmController;
            this.CanStart = true;
        }

        public void Display()
        {
            Console.WriteLine($"High tech BPM display for BPM: {model.GetBpm()}");
        }

        public void Start()
        {
            if(this.CanStart)
            {
                this.bpmController.Start();
                Console.WriteLine("Starting");
                return;
            }
            Console.WriteLine("Start disabled");
        }

        public void Stop()
        {
            if(this.CanStop)
            {
                this.bpmController.Stop();
                Console.WriteLine("Stopping");
                return;
            }
            Console.WriteLine("Stop disabled");
        }

        public void SetStart(bool start)
        {
            this.CanStart = start;
            this.CanStop = !start;
        }

        public void SetStop(bool stop)
        {
            this.CanStop = stop;
            this.CanStart = !stop;
        }

        public void DecrementBpmButton()
        {
            bpmController.DecrementBpm();
        }

        public void IncrementBpmButton()
        {
            bpmController.IncrementBpm();
        }

        public void SetBpm(int bpm)
        {
            bpmController.SetBpm(bpm);
        }

        public void UpdateBpm(IReadOnlyBpmModel readOnlyBpmModel)
        {
            Console.WriteLine($"Bpm Update: {readOnlyBpmModel.GetBpm()}");
        }
    }
}
