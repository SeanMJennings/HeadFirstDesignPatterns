using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    public interface IBpmObserver
    {
        void UpdateBpm(IReadOnlyBpmModel bpmObservable);
    }
}
