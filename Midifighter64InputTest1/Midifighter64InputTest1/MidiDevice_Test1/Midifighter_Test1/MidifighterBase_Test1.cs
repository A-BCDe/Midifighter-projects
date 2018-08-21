using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midifighter64InputTest1.MidiDevice_Test1.Midifighter_Test1
{
    class MidifighterBase_Test1 : MidiDeviceBase_Test1
    {
        public enum MidifighterType
        {
            None,
            Midifighter3d,
            Midifighter64,
            MidifighterTwister
        }
        public MidifighterType midifighterType
        {
            get;
            protected set;
        }
    }
}
