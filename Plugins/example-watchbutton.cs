using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MissionPlanner.Utilities;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using MissionPlanner;

namespace Shortcuts
{
    public class ButtonPlugin : MissionPlanner.Plugin.Plugin
    {
        private Button customButton; // Declare a custom button

        public override string Name
        {
            get { return "Button change"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        public override string Author
        {
            get { return "EOSBandi"; }
        }

        public override bool Init()
        {
            // Initialize custom button
            customButton = new Button();
            customButton.Text = "Custom Button";
            customButton.Click += CustomButton_Click; // Attach event handler for button click
            Host.MainForm.Controls.Add(customButton); // Add button to the main form

            // Find TableLayoutPanel
            TableLayoutPanel actionLayout = Host.MainForm.FlightData.Controls.Find("tableLayoutPanel1", true).FirstOrDefault() as TableLayoutPanel;

            // Check if TableLayoutPanel is found
            if (actionLayout != null)
            {
                // Create and add MyButton to the TableLayoutPanel
                MyButton btn1 = new MyButton();
                btn1.Text = "Button1";
                actionLayout.Controls.Add(btn1, 0, 4);
            }

            // Initialize plugin
            return true;
        }

        public override bool Loaded()
        {
            Host.comPort.OnPacketReceived += MavOnOnPacketReceivedHandler;
            return true;
        }

        public override bool Loop()
        {
            // Plugin loop logic
            return true;
        }

        public override bool Exit()
        {
            // Clean up resources
            customButton.Click -= CustomButton_Click;
            Host.MainForm.Controls.Remove(customButton);
            customButton.Dispose();
            return true;
        }

        private void MavOnOnPacketReceivedHandler(object o, MAVLink.MAVLinkMessage linkMessage)
        {
            if ((MAVLink.MAVLINK_MSG_ID)linkMessage.msgid == MAVLink.MAVLINK_MSG_ID.BUTTON_CHANGE)
            {
                // Button change message received
                // Check and display message
                Console.WriteLine("BUTTON CHANGE message received");
            }
        }

        private void CustomButton_Click(object sender, EventArgs e)
        {
            // Handle custom button click event
            MessageBox.Show("Custom Button Clicked!");
        }
    }
}
