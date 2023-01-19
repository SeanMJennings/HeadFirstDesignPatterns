using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object syncLock = new object();
        public int testValue = 0;
        private Singleton() { }

        public static Singleton GetInstance()
        {
            lock(syncLock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
