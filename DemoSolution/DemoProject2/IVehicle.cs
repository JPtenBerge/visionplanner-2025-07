using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject2;

public interface IVehicle
{
    void Start();
    void Move();

    // zo klein mogelijk
    // SOLID  Interface segregation
}

public interface ICanFly
{
    void Fly();
}