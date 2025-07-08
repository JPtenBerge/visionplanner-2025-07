using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal abstract class Animal : Object
    {

        // GetType()
        // ToString()
        

        public string Name { get; set; }

        public abstract void MakeNoise();
    }
}
