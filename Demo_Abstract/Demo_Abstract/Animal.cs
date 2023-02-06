﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract
{
    internal abstract class Animal
    {
        public string Name { get; set; }  
        public void Sleep()
        {
            Console.WriteLine("Animals want to sleep");
        }
        public abstract void Eat();

        protected Animal(string name)
        {
            Name = name;
        }
        

    }
}
