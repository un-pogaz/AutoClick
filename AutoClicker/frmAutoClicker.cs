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

namespace AutoClicker
{
    public partial class frmAutoClicker : Form
    {
        public frmAutoClicker()
        {
            InitializeComponent();

            numTick.Maximum = trkTick.Maximum;
            numTick.Minimum = trkTick.Minimum;
            numTick.Value = trkTick.Value;

            timClock.Interval = trkTick.Value;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            btnStop.PerformClick();

            #region Args
            for (int i = 0; i < Settings.Args.Length; i++)
            {
                if (Settings.Args[i].Equals(StringComparison.InvariantCultureIgnoreCase, "-t", "--tick") && i + 1 < Settings.Args.Length)
                {
                    int parse;
                    if (int.TryParse(Settings.Args[i + 1], out parse))
                        trkTick.Value = parse;
                }

                if (Settings.Args[i].Equals("--toggle", StringComparison.InvariantCultureIgnoreCase) && i + 1 < Settings.Args.Length)
                {
                    chkToggle.Checked = true;
                }

                if ((Settings.Args[i].Equals(StringComparison.InvariantCultureIgnoreCase, "-k", "--key")) && i + 1 < Settings.Args.Length)
                {
                    #region Key
                    if (Settings.Args[i + 1].Equals(StringComparison.InvariantCultureIgnoreCase, "Caps", "CapsLock"))
                    {
                        rdbCaps.Checked = true;
                    }
                    else if (Settings.Args[i + 1].Equals(StringComparison.InvariantCultureIgnoreCase, "Num", "NumLock"))
                    {
                        rdbNum.Checked = true;
                    }
                    else if (Settings.Args[i + 1].Equals(StringComparison.InvariantCultureIgnoreCase, "Scroll", "ScrollLock"))
                    {
                        rdbScroll.Checked = true;
                    }

                    else if (Settings.Args[i + 1].Equals("Alt", StringComparison.InvariantCultureIgnoreCase))
                    {
                        rdbAlt.Checked = true;
                    }
                    else if (Settings.Args[i + 1].Equals("Ctrl", StringComparison.InvariantCultureIgnoreCase))
                    {
                        rdbCtrl.Checked = true;
                    }
                    else if (Settings.Args[i + 1].Equals("Shift", StringComparison.InvariantCultureIgnoreCase))
                    {
                        rdbShift.Checked = true;
                    }
                    else if (Settings.Args[i + 1].Equals("Pause", StringComparison.InvariantCultureIgnoreCase))
                    {
                        rdbPause.Checked = true;
                    }
                    #endregion
                }

                if (Settings.Args[i].Equals(StringComparison.InvariantCultureIgnoreCase, "-a", "--active"))
                    btnActivate.PerformClick();
                

                if (Settings.Args[i].Equals("--TopMost", StringComparison.InvariantCultureIgnoreCase))
                    chkTopMost.Checked = true;

                if ((Settings.Args[i].Equals("--opacity", StringComparison.InvariantCultureIgnoreCase)) && i + 1 < Settings.Args.Length)
                {
                    int parse;
                    if (int.TryParse(Settings.Args[i + 1], out parse))
                    {
                        if (parse > trkOpacity.Maximum)
                            parse = trkOpacity.Maximum;
                        if (parse < trkOpacity.Minimum)
                            parse = trkOpacity.Minimum;
                        
                        trkOpacity.Value = parse;
                        Opacity = 1;
                    }
                }
            }
            #endregion
        }

        private void trkTick_ValueChanged(object sender, EventArgs e)
        {
            timClock.Interval = trkTick.Value;
            numTick.Value = trkTick.Value;
        }

        private void numTick_ValueChanged(object sender, EventArgs e)
        {
            trkTick.Value = (int)numTick.Value;
        }


        private void timClock_Tick(object sender, EventArgs e)
        {
            if (rdbCaps.Checked && Keyboard.IsKeyToggled(Key.CapsLock) || rdbNum.Checked && Keyboard.IsKeyToggled(Key.NumLock) || rdbScroll.Checked && Keyboard.IsKeyToggled(Key.Scroll) ||
                AsToggleRdb() && ToggleKeyDown() || ToggleOn)
            {
                MouseActionInput.LeftClick();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timClock.Stop();
            timToggle.Stop();
            EnabledControl(true);
        }

        private void btnActivate_Click(object sender, EventArgs e)
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
            btnActivate.Enabled = enabled;
            trkTick.Enabled = enabled;
            numTick.Enabled = enabled;

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
            if (!ToggleKeyPressed && ToggleKeyDown())
            {
                ToggleKeyPressed = true;

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
            if (ToggleKeyPressed && !ToggleKeyDown())
                ToggleKeyPressed = false;
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
        
        bool ToggleOn;
        bool ToggleKeyPressed;


        #region Opacity

        private void trkOpacity_ValueChanged(object sender, EventArgs e)
        {
            Opacity = trkOpacity.Value/100d;
            lblOpacity.Text = trkOpacity.Value + "% opacity";
        }

        private void trkOpacity_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Opacity = trkOpacity.Value / 100d;
        }

        private void trkOpacity_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Opacity = 1;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Opacity = trkOpacity.Value / 100d;
        }

        #endregion

        private void chkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = chkTopMost.Checked;
        }
        
    }
}
