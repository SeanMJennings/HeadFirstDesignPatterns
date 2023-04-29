using MVC.Model;
using MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controller
{
    internal class BpmController : IBpmController
    {
        private IBpmView bpmView;
        private IBpmModel model;

        public BpmController(IBpmModel model) 
        {
            this.bpmView = new BpmView(this, (IReadOnlyBpmModel)model);
            this.model = model;
        }

        public void Start()
        {
            this.model.Start();
            this.bpmView.SetStart(false);
        }

        public void Stop()
        {
            this.model.Stop();
            this.bpmView.SetStop(false);
        }

        public void DecrementBpm()
        {
            this.model.DecrementBpm();
        }

        public void IncrementBpm()
        {
            this.model.IncrementBpm();
        }

        public void SetBpm(int bpm)
        {
            this.model.SetBpm(bpm);
        }

        //for testing purposes
        public IBpmView ExposeView()
        {
            return this.bpmView;
        }
    }
}
