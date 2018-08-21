using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Midi;

namespace Midifighter64InputTest1.MidiDevice_Test1
{
    class MidiDeviceBase_Test1
    {
        protected InputDevice input;
        protected OutputDevice output;
        public Channel InputChannel
        {
            get; 
            protected set;
        }
        public Channel OutputChannel
        {
            get;
            protected set;
        }

        public void GetInput()
        {
            input.StartReceiving(null);
            output.SilenceAllNotes();
            input.NoteOn += Input_NoteOn;
            input.NoteOff += Input_NoteOff;
            Console.ReadKey();
        }

        protected virtual void Input_NoteOff(NoteOffMessage msg)
        {
            Console.WriteLine(msg.Pitch + "released");
        }

        protected virtual void Input_NoteOn(NoteOnMessage msg)
        {
            Console.WriteLine(msg.Pitch + "pressed");
        }

        ~MidiDeviceBase_Test1()
        {
            if (input != null) input.Close();
            if (output != null) output.Close();
        }

        public static class Build
        {
            public static Channel[] SelectMidiDevice()
            {
                Channel[] channel = new Channel[2] { 0, 0 };
                int inMidiChannelCount = InputDevice.InstalledDevices.Count;
                int outMidiChannelCount = OutputDevice.InstalledDevices.Count;
                string[] inChannelList = new string[inMidiChannelCount];
                string[] outChannelList = new string[outMidiChannelCount];

                for (int i = 0; i < inMidiChannelCount; i++)
                {
                    inChannelList[i] = InputDevice.InstalledDevices[i].Name;
                }

                using (SelectDeviceForm form = new SelectDeviceForm("Input Midi", inChannelList))
                {
                    var result = form.ShowDialog();
                    switch (result)
                    {
                        case DialogResult.None:
                            break;
                        case DialogResult.OK:
                            channel[0] = (Channel)form.index;
                            break;
                        default:
                            throw new Exception("Error : SelectMidiInputDevice");
                    }
                }

                for (int i = 0; i < outMidiChannelCount; i++)
                {
                    outChannelList[i] = OutputDevice.InstalledDevices[i].Name;
                }

                using (SelectDeviceForm form = new SelectDeviceForm("Output Midi", outChannelList))
                {
                    var result = form.ShowDialog();
                    switch (result)
                    {
                        case DialogResult.None:
                            break;
                        case DialogResult.OK:
                            channel[1] = (Channel)form.index;
                            break;
                        default:
                            throw new Exception("Error : SelectMidiInputDevice");
                    }
                }

                return channel;
            }
        }
    }
}
