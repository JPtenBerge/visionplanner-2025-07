using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Dog : Animal
    {
        public string Vachtkleur { get; set; }

        public override void MakeNoise()
        {
            Console.WriteLine("woof mijn vacht is " + Vachtkleur);
        }
    }
}
