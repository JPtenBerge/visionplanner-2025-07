using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUitwerking;

public interface IKortingService
{
    int GeefKortingBedrag(int bedrag, decimal korting);
}
