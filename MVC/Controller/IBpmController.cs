using MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controller
{
    public interface IBpmController
    {
        void Start();
        void Stop();
        void SetBpm(int Bpm);
        void IncrementBpm();
        void DecrementBpm();
        IBpmView ExposeView();
    }
}
