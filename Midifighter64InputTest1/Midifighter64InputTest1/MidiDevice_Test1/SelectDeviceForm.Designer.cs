﻿namespace Midifighter64InputTest1.MidiDevice_Test1
{
    partial class SelectDeviceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.midiDeviceCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // midiDeviceCheckedListBox
            // 
            this.midiDeviceCheckedListBox.FormattingEnabled = true;
            this.midiDeviceCheckedListBox.Location = new System.Drawing.Point(12, 52);
            this.midiDeviceCheckedListBox.Name = "midiDeviceCheckedListBox";
            this.midiDeviceCheckedListBox.Size = new System.Drawing.Size(296, 224);
            this.midiDeviceCheckedListBox.TabIndex = 0;
            this.midiDeviceCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.midiDeviceCheckedListBox_ItemCheck);
            this.midiDeviceCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.midiDeviceCheckedListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(314, 185);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(118, 91);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(445, 185);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(118, 91);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SelectDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 293);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.midiDeviceCheckedListBox);
            this.Name = "SelectDeviceForm";
            this.Text = "Select Device";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox midiDeviceCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cancelButton;
    }
}