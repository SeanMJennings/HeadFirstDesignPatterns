using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class VirtualProxy : ISubject
    {
        private string result;
        private bool processed;
        private ISubject subject;
        private Thread processingThread;

        public VirtualProxy() 
        {
            this.processingThread = new Thread(new ThreadStart(SetupSubject));
        }

        public string Present()
        {
            if (string.IsNullOrEmpty(result))
            {
                processingThread.Start();
                return "waiting";
            }
            else
            {
                return result;
            }
        }

        public void SetupSubject()
        {
            this.subject = new Subject();
            this.result = subject.Present();
        }
    }
}
