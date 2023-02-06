using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract
{
    internal class Cow : Animal,ICanRun
    {
        public Cow(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Cows eat grass");
        }

        public void Run()
        {
            Console.WriteLine("Cows can run slowly");
        }
    }
}
