using Midi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midifighter64InputTest1.MidiDevice_Test1
{
    public partial class SelectDeviceForm : Form
    {
        public int index { get; private set; }

        public SelectDeviceForm(string s = "", string[] channelList = null)
        {
            InitializeComponent();
            label1.Text = s;
            for(int i = 0; i < channelList.Count(); i++)
            {
                midiDeviceCheckedListBox.Items.Insert(i, channelList[i]);
            }
        }

        private void midiDeviceCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void midiDeviceCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for(int i = 0; i < midiDeviceCheckedListBox.Items.Count; i++)
                {
                    if (e.Index != i)
                    {
                        midiDeviceCheckedListBox.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (midiDeviceCheckedListBox.CheckedItems.Count == 1)
            {
                index = midiDeviceCheckedListBox.Items.IndexOf(midiDeviceCheckedListBox.CheckedItems[0]);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
            return;
        }
    }
}
