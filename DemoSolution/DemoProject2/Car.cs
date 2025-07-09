using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject2;

internal class Car : IVehicle
{
    Motor _engine;

    public void Start()
    {
        Console.WriteLine("vroem");
    }

    public void Move()
    {
        Console.WriteLine("ik beweeg met 250km/uur");
    }
}
