using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject2;

internal class Bicycle : IVehicle
{
    //Dynamo dynamo;

    public void Start()
    {
        Console.WriteLine("ring ring");
    }

    public void Move()
    {
        Console.WriteLine("ik beweeg met 15km/h!");
    }
}
