﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Parrot : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("squawk");
        }
    }
}
