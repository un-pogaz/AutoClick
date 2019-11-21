using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;

namespace AutoClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numNumeric.Maximum = trkTrackBar.Maximum;
            numNumeric.Minimum = trkTrackBar.Minimum;
            trkTrackBar.Value = timClock.Interval;

            for (int i = 0; i < Settings.Args.Length; i++)
            {
                if (Settings.Args[i].Equals(StringComparison.InvariantCultureIgnoreCase, "-t", "--tick") &&  i+1 < Settings.Args.Length)
                {
                    int parse;
                    if (int.TryParse(Settings.Args[i + 1], out parse))
                        trkTrackBar.Value = parse;
                }

                if (Settings.Args[i].Equals("   ", StringComparison.InvariantCultureIgnoreCase) && i + 1 < Settings.Args.Length)
                {
                    chkToggle.Checked = true;
                }

                if ((Settings.Args[i].Equals(StringComparison.InvariantCultureIgnoreCase, "-k", "--key")) && i + 1 < Settings.Args.Length)
                {
                    if (Settings.Args[i+1].Equals(StringComparison.InvariantCultureIgnoreCase, "Caps", "CapsLock"))
                    {
                        rdbCaps.Checked = true;
                    }
                    else if(Settings.Args[i+1].Equals(StringComparison.InvariantCultureIgnoreCase, "Num", "NumLock"))
                    {
                        rdbNum.Checked = true;
                    }
                    else if (Settings.Args[i + 1].Equals(StringComparison.InvariantCultureIgnoreCase, "Scroll", "ScrollLock"))
                    {
                        rdbScroll.Checked = true;
                    }
                    else if (Settings.Args[i+1].Equals("Alt", StringComparison.InvariantCultureIgnoreCase))
                    {
                        rdbAlt.Checked = true;
                    }
                    else if (Settings.Args[i+1].Equals("Ctrl", StringComparison.InvariantCultureIgnoreCase))
                    {
                        rdbCtrl.Checked = true;
                    }
                    else if (Settings.Args[i+1].Equals("Shift", StringComparison.InvariantCultureIgnoreCase))
                    {
                        rdbShift.Checked = true;
                    }
                }
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            btnStop.PerformClick();
            Refresh();

            for (int i = 0; i < Settings.Args.Length; i++)
            {
                if (Settings.Args[i].Equals(StringComparison.InvariantCultureIgnoreCase, "-r", "--active"))
                    btnActive.PerformClick();
            }
        }

        private void trkTrackBar_ValueChanged(object sender, EventArgs e)
        {
            timClock.Interval = trkTrackBar.Value;
            numNumeric.Value = trkTrackBar.Value;
        }

        private void numNumeric_ValueChanged(object sender, EventArgs e)
        {
            trkTrackBar.Value = (int)numNumeric.Value;
        }
        
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention= CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private void timClock_Tick(object sender, EventArgs e)
        {
            if (rdbCaps.Checked && Keyboard.IsKeyToggled(Key.CapsLock) || rdbNum.Checked && Keyboard.IsKeyToggled(Key.NumLock) || rdbScroll.Checked && Keyboard.IsKeyToggled(Key.Scroll) ||
                AsToggleRdb() && ToggleKeyDown() || ToggleOn)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timClock.Stop();
            timToggle.Stop();
            EnabledControl(true);
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            EnabledControl(false);
            SetToggleKey();
            if (chkToggle.Checked && AsToggleRdb())
                timToggle.Start();

            timClock.Start();
        }

        private void EnabledControl(bool enabled)
        {
            btnStop.Enabled = !enabled;
            btnActive.Enabled = enabled;
            trkTrackBar.Enabled = enabled;
            numNumeric.Enabled = enabled;
            trkTrackBar.Enabled = enabled;

            chkToggle.Enabled = enabled;

            rdbCaps.Enabled = enabled;
            rdbNum.Enabled = enabled;
            rdbScroll.Enabled = enabled;

            rdbAlt.Enabled = enabled;
            rdbCtrl.Enabled = enabled;
            rdbShift.Enabled = enabled;
            rdbPause.Enabled = enabled;
        }

        private void timToggle_Tick(object sender, EventArgs e)
        {
            if (!KeyTogglePressed && ToggleKeyDown())
            {
                KeyPressed = true;

                if (!ToggleOn)
                {
                    ToggleOn = true;
                    return;
                }

                if (ToggleOn)
                {
                    ToggleOn = false;
                    return;
                }
            }
            if (KeyPressed && !ToggleKeyDown())
                KeyPressed = false;
        }

        Key[] ToggleKey = new Key[] { Key.LeftShift, Key.RightShift, Key.LeftAlt, Key.RightAlt, Key.LeftCtrl, Key.RightCtrl };

        private void SetToggleKey()
        {
            if (rdbAlt.Checked)
                ToggleKey = new Key[] { Key.LeftAlt, Key.RightAlt };
            else if (rdbCtrl.Checked)
                ToggleKey = new Key[] { Key.LeftCtrl, Key.RightCtrl };
            else if (rdbShift.Checked)
                ToggleKey = new Key[] { Key.LeftShift, Key.RightShift };
            else if (rdbPause.Checked)
                ToggleKey = new Key[] { Key.Pause };
        }

        private bool AsToggleRdb()
        {
            return (rdbAlt.Checked || rdbCtrl.Checked || rdbShift.Checked || rdbPause.Checked);
        }


        private bool ToggleKeyDown()
        {
            foreach (Key item in ToggleKey)
                if (Keyboard.IsKeyDown(item))
                    return true;
            return false;
        }

        bool KeyPressed;
        bool ToggleOn;

        public bool KeyTogglePressed { get; private set; }

    }
}
