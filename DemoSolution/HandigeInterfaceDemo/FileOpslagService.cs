using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandigeInterfaceDemo
{
    internal class FileOpslagService : IOpslagService
    {
        public void SlaOp()
        {
            File.AppendAllText("C:\\repos\\course-instances\\visionplanner-2025-07\\DemoSolution\\HandigeInterfaceDemo\\helebelangrijkedata.txt", "gelukt!");
            Console.WriteLine("file wegschrijven gelukt!");
        }
    }
}
