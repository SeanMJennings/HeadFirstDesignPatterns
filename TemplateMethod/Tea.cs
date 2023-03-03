using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Tea : Beverage
    {
        public Tea() { }

        public override void Brew()
        {
            Console.WriteLine("Adding teabag");
        }

        public override void AddCondiment()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
