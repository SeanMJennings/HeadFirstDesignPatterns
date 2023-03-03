using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Coffee : Beverage
    {
        public Coffee() { }

        public override void Brew()
        {
            Console.WriteLine("Adding coffee granules");
        }

        public override void AddCondiment()
        {
            Console.WriteLine("Adding sugar");
        }
    }
}
