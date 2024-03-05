//using System;
//using System.Windows.Forms;
//using MissionPlanner.Plugin;
//using MissionPlanner.Controls;
//using MissionPlanner;

//namespace PersistentSimpleActions
//{
//    public class PersistentSimpleActions : Plugin
//    {
//        private string _Name = "Persistent Simple Actions";
//        private string _Version = "0.1";
//        private string _Author = "Bob Long";

//        public override string Name { get { return _Name; } }
//        public override string Version { get { return _Version; } }
//        public override string Author { get { return _Author; } }

//        public override bool Init() { return true; }

//        public override bool Loaded()
//        {
//            MyButton button1 = new MyButton();
//            ToolTip toolTip1 = new ToolTip();

//            button1.Text = "Click me";
//            button1.Location = new System.Drawing.Point(4, 4);
//            button1.Size = new System.Drawing.Size(75, 23);
//            toolTip1.SetToolTip(button1, "This is a simple button");
//            button1.Click += new EventHandler(but_mode_Click);

//            MainV2.instance.FlightData.panel_persistent.MinimumSize = new System.Drawing.Size(0, 35);

//            MainV2.instance.FlightData.panel_persistent.Controls.Add(button1);

//            return true;
//        }

//        public override bool Exit() { return true; }

//        private void but_mode_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                ((Control)sender).Enabled = false;
//                Add your button click logic here
//                 For example, display a message
//                MessageBox.Show("Button clicked!");
//            }
//            catch
//            {
//                CustomMessageBox.Show("Command failed", "ERROR");
//            }
//            finally
//            {
//                ((Control)sender).Enabled = true;
//            }
//        }
//    }
//}
/*using System;
using System.Windows.Forms;
using MissionPlanner.Plugin;
using MissionPlanner.Controls;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.IO;
using System.Text;
using MissionPlanner;

namespace PersistentSimpleActions
{
    public class PersistentSimpleActions : Plugin
    {
        private string _Name = "Persistent Simple Actions";
        private string _Version = "0.1";
        private string _Author = "Bob Long";

        public override string Name { get { return _Name; } }
        public override string Version { get { return _Version; } }
        public override string Author { get { return _Author; } }

        public override bool Init() { return true; }

        public override bool Loaded()
        {
            MyButton button1 = new MyButton();
            ToolTip toolTip1 = new ToolTip();

            button1.Text = "Click me";
            button1.Location = new System.Drawing.Point(4, 4);
            button1.Size = new System.Drawing.Size(75, 23);
            toolTip1.SetToolTip(button1, "This is a simple button");
            button1.Click += new EventHandler(but_mode_Click);

            MainV2.instance.FlightData.panel_persistent.MinimumSize = new System.Drawing.Size(0, 35);

            MainV2.instance.FlightData.panel_persistent.Controls.Add(button1);

            return true;
        }

        public override bool Exit() { return true; }

        private void but_mode_Click(object sender, EventArgs e)
        {
            try
            {
                ((Control)sender).Enabled = false;

                // Use IronPython to execute a Python script
                ExecutePythonScript("import datetime\r\n\r\n# Get the current date\r\ncurrent_date = datetime.datetime.now().date()\r\n\r\n# Display the current date\r\nprint(\"Current Date:\", current_date)\r\n");

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Command failed: {ex.Message}", "ERROR");
            }
            finally
            {
                ((Control)sender).Enabled = true;
            }
        }

        private void ExecutePythonScript(string script)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            MemoryStream outputStream = new MemoryStream();
            engine.Runtime.IO.SetOutput(outputStream, Encoding.UTF8);

            try
            {
                engine.Execute(script, scope);
                outputStream.Seek(0, SeekOrigin.Begin);
                using (StreamReader reader = new StreamReader(outputStream))
                {
                    string output = reader.ReadToEnd();
                    MessageBox.Show(output, "Python Output");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing Python script: {ex.Message}", "Python Error");
            }
        }
    }

}
*/

using System;
using System.Windows.Forms;
using MissionPlanner.Plugin;
using MissionPlanner.Controls;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.IO;
using System.Text;
using MissionPlanner;

namespace PersistentSimpleActions
{
    public class PersistentSimpleActions : Plugin
    {
        private string _Name = "Persistent Simple Actions";
        private string _Version = "0.1";
        private string _Author = "Bob Long";

        public override string Name { get { return _Name; } }
        public override string Version { get { return _Version; } }
        public override string Author { get { return _Author; } }

        public override bool Init() { return true; }

        public override bool Loaded()
        {
            MyButton button1 = new MyButton();
            ToolTip toolTip1 = new ToolTip();

            button1.Text = "Click me";
            button1.Location = new System.Drawing.Point(4, 4);
            button1.Size = new System.Drawing.Size(75, 23);
            toolTip1.SetToolTip(button1, "This is a simple button");
            button1.Click += new EventHandler(but_mode_Click);

            MainV2.instance.FlightData.panel_persistent.MinimumSize = new System.Drawing.Size(0, 35);

            MainV2.instance.FlightData.panel_persistent.Controls.Add(button1);

            return true;
        }

        public override bool Exit() { return true; }

        private void but_mode_Click(object sender, EventArgs e)
        {
            try
            {
                ((Control)sender).Enabled = false;

                // Use IronPython to execute a Python script
                ExecutePythonScript("import datetime\r\n\r\n# Get the current date\r\ncurrent_date = datetime.datetime.now().date()\r\n\r\n# Display the current date\r\nprint(\"Current Date:\", current_date)\r\n");

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Command failed: {ex.Message}", "ERROR");
            }
            finally
            {
                ((Control)sender).Enabled = true;
            }
        }

        private void ExecutePythonScript(string script)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            MemoryStream outputStream = new MemoryStream();
            engine.Runtime.IO.SetOutput(outputStream, Encoding.UTF8);

            try
            {
                engine.Execute(script, scope);
                outputStream.Seek(0, SeekOrigin.Begin);
                using (StreamReader reader = new StreamReader(outputStream))
                {
                    string output = reader.ReadToEnd();
                    MessageBox.Show(output, "Python Output");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing Python script: {ex.Message}", "Python Error");
            }
        }
    }

}
