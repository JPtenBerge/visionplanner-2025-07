using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandigeInterfaceDemo
{
    internal class MijnWebPagina
    {
        internal IOpslagService _service;

        // "low coupling, high cohesion"


        public void SlaOp()
        {
            _service.SlaOp();
        }
    }
}
