using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midifighter64InputTest1.MidiDevice_Test1;
using Midifighter64InputTest1.MidiDevice_Test1.Midifighter_Test1;

namespace Midifighter64InputTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Midifighter64_Test1 midifighter64 = new Midifighter64_Test1();
            midifighter64.GetInput();
        }
    }
}
