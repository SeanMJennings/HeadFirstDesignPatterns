using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Subject : ISubject
    {
        public string Present()
        {
            Thread.Sleep(10000);
            return "I\'m here!";
        }
    }
}
