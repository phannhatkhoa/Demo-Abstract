using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract
{
    internal class Cat : Animal,ICanRun,ICanClimbJump
    {
        public Cat(string name) : base(name)
        {
        }

        public void Climb()
        {
            Console.WriteLine("Cat can climb");
        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat rice, fish, and meat");
        }

        public void Jump()
        {
            Console.WriteLine("Cats can jump");
        }

        public void Run()
        {
            Console.WriteLine("Cats can run");
        }
    }
}
