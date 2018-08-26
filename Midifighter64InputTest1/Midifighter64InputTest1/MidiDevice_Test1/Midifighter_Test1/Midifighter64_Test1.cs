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
        public const string name = "Midi Fighter 64";
        protected const Channel ColorChannel = Channel.Channel3;
        protected const Channel PatternChannel = Channel.Channel4; // not only patterns, but also gives programmed stuffs

        protected override void Input_NoteOff(NoteOffMessage msg)
        {
            Console.WriteLine(msg.Pitch + "released");
            output.SendNoteOn(ColorChannel, msg.Pitch, 0);
        }

        protected override void Input_NoteOn(NoteOnMessage msg)
        {
            Console.WriteLine(msg.Pitch + "pressed");
            output.SendNoteOn(ColorChannel, msg.Pitch, 5);
        }

        public Midifighter64_Test1()
        {
            midifighterType = MidifighterType.Midifighter64;
            Channel[] channel = Build.SelectMidiDevice();
            input = InputDevice.InstalledDevices[(int)(InputChannel = channel[0])];
            output = OutputDevice.InstalledDevices[(int)(OutputChannel = channel[1])];

            input.Open();
            output.Open();
        }

        public Midifighter64_Test1(Channel inputChannel, Channel outputChannel)
        {
            midifighterType = MidifighterType.Midifighter64;
            input = InputDevice.InstalledDevices[(int)(InputChannel = inputChannel)];
            output = OutputDevice.InstalledDevices[(int)(OutputChannel = outputChannel)];

            if (input != null) input.Open();
            if (output != null) output.Open();
        }


    }
}
