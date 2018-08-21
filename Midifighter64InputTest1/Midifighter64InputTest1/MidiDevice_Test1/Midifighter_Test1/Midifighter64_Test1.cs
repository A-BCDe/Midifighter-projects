using Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midifighter64InputTest1.MidiDevice_Test1.Midifighter_Test1
{
    class Midifighter64_Test1 : MidifighterBase_Test1
    {
        public static string name = "Midi Fighter 64";

        public Midifighter64_Test1()
        {
            midifighterType = MidifighterType.Midifighter64;
            Build.SelectMidiDevice();
            input = InputDevice.InstalledDevices[(int)InputChannel];
            output = OutputDevice.InstalledDevices[(int)OutputChannel];

            input.Open();
            output.Open();
        }

        public Midifighter64_Test1(Channel inputChannel,Channel outputChannel)
        {
            midifighterType = MidifighterType.Midifighter64;
            input = InputDevice.InstalledDevices[(int)(InputChannel = inputChannel)];
            output = OutputDevice.InstalledDevices[(int)(OutputChannel = outputChannel)];

            if (input != null) input.Open();
            if (output != null) output.Open();
        }
        /*
        ~Midifighter64_Test1()
        {
            input.Close();
            output.Close();
        }
        */
    }
}
