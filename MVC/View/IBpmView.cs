using MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.View
{
    public interface IBpmView
    {
        void Display();
        void SetStart(bool start);
        void SetStop(bool stop);
        void Start();
        void Stop();
        void SetBpm(int bpm);
        void IncrementBpmButton();
        void DecrementBpmButton();

    }
}
