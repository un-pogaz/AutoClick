namespace AutoClicker
{
    partial class frmAutoClicker
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.numTick = new System.Windows.Forms.NumericUpDown();
            this.trkTick = new System.Windows.Forms.TrackBar();
            this.timClock = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rdbCaps = new System.Windows.Forms.RadioButton();
            this.rdbNum = new System.Windows.Forms.RadioButton();
            this.chkToggle = new System.Windows.Forms.CheckBox();
            this.rdbAlt = new System.Windows.Forms.RadioButton();
            this.rdbCtrl = new System.Windows.Forms.RadioButton();
            this.rdbShift = new System.Windows.Forms.RadioButton();
            this.ttiToggle = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timToggle = new System.Windows.Forms.Timer(this.components);
            this.rdbPause = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbScroll = new System.Windows.Forms.RadioButton();
            this.trkOpacity = new System.Windows.Forms.TrackBar();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTick)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActive
            // 
            this.btnActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.Location = new System.Drawing.Point(3, 3);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(193, 57);
            this.btnActive.TabIndex = 0;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(202, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(194, 57);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // numTick
            // 
            this.numTick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTick.Location = new System.Drawing.Point(321, 48);
            this.numTick.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTick.Name = "numTick";
            this.numTick.Size = new System.Drawing.Size(59, 20);
            this.numTick.TabIndex = 2;
            this.numTick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTick.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTick.ValueChanged += new System.EventHandler(this.numTick_ValueChanged);
            // 
            // trkTick
            // 
            this.trkTick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkTick.Location = new System.Drawing.Point(12, 12);
            this.trkTick.Maximum = 10000;
            this.trkTick.Minimum = 1;
            this.trkTick.Name = "trkTick";
            this.trkTick.Size = new System.Drawing.Size(386, 45);
            this.trkTick.TabIndex = 3;
            this.trkTick.Value = 100;
            this.trkTick.ValueChanged += new System.EventHandler(this.trkTick_ValueChanged);
            // 
            // timClock
            // 
            this.timClock.Tick += new System.EventHandler(this.timClock_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ms";
            // 
            // rdbCaps
            // 
            this.rdbCaps.AutoSize = true;
            this.rdbCaps.Checked = true;
            this.rdbCaps.Location = new System.Drawing.Point(12, 63);
            this.rdbCaps.Name = "rdbCaps";
            this.rdbCaps.Size = new System.Drawing.Size(76, 17);
            this.rdbCaps.TabIndex = 5;
            this.rdbCaps.TabStop = true;
            this.rdbCaps.Text = "Caps Lock";
            this.rdbCaps.UseVisualStyleBackColor = true;
            // 
            // rdbNum
            // 
            this.rdbNum.AutoSize = true;
            this.rdbNum.Location = new System.Drawing.Point(12, 86);
            this.rdbNum.Name = "rdbNum";
            this.rdbNum.Size = new System.Drawing.Size(74, 17);
            this.rdbNum.TabIndex = 6;
            this.rdbNum.Text = "Num Lock";
            this.rdbNum.UseVisualStyleBackColor = true;
            // 
            // chkToggle
            // 
            this.chkToggle.AccessibleDescription = "";
            this.chkToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkToggle.AutoSize = true;
            this.chkToggle.Location = new System.Drawing.Point(315, 87);
            this.chkToggle.Name = "chkToggle";
            this.chkToggle.Size = new System.Drawing.Size(89, 17);
            this.chkToggle.TabIndex = 7;
            this.chkToggle.Text = "Toggle Mode";
            this.ttiToggle.SetToolTip(this.chkToggle, "Enable the Toggle Mode for \"Ctrl\", \"Alt\", \"Maj\" and \"Pause\".");
            this.chkToggle.UseVisualStyleBackColor = true;
            // 
            // rdbAlt
            // 
            this.rdbAlt.AutoSize = true;
            this.rdbAlt.Location = new System.Drawing.Point(195, 63);
            this.rdbAlt.Name = "rdbAlt";
            this.rdbAlt.Size = new System.Drawing.Size(37, 17);
            this.rdbAlt.TabIndex = 6;
            this.rdbAlt.Text = "Alt";
            this.rdbAlt.UseVisualStyleBackColor = true;
            // 
            // rdbCtrl
            // 
            this.rdbCtrl.AutoSize = true;
            this.rdbCtrl.Location = new System.Drawing.Point(195, 86);
            this.rdbCtrl.Name = "rdbCtrl";
            this.rdbCtrl.Size = new System.Drawing.Size(40, 17);
            this.rdbCtrl.TabIndex = 6;
            this.rdbCtrl.Text = "Ctrl";
            this.rdbCtrl.UseVisualStyleBackColor = true;
            // 
            // rdbShift
            // 
            this.rdbShift.AutoSize = true;
            this.rdbShift.Location = new System.Drawing.Point(238, 63);
            this.rdbShift.Name = "rdbShift";
            this.rdbShift.Size = new System.Drawing.Size(46, 17);
            this.rdbShift.TabIndex = 6;
            this.rdbShift.Text = "Shift";
            this.rdbShift.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnActive, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStop, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 63);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // timToggle
            // 
            this.timToggle.Interval = 10;
            this.timToggle.Tick += new System.EventHandler(this.timToggle_Tick);
            // 
            // rdbPause
            // 
            this.rdbPause.AutoSize = true;
            this.rdbPause.Location = new System.Drawing.Point(238, 86);
            this.rdbPause.Name = "rdbPause";
            this.rdbPause.Size = new System.Drawing.Size(55, 17);
            this.rdbPause.TabIndex = 6;
            this.rdbPause.Text = "Pause";
            this.rdbPause.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(94, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Scroll Lock";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbScroll
            // 
            this.rdbScroll.AutoSize = true;
            this.rdbScroll.Location = new System.Drawing.Point(94, 63);
            this.rdbScroll.Name = "rdbScroll";
            this.rdbScroll.Size = new System.Drawing.Size(78, 17);
            this.rdbScroll.TabIndex = 6;
            this.rdbScroll.Text = "Scroll Lock";
            this.rdbScroll.UseVisualStyleBackColor = true;
            // 
            // trkOpacity
            // 
            this.trkOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trkOpacity.Cursor = System.Windows.Forms.Cursors.Default;
            this.trkOpacity.Location = new System.Drawing.Point(3, 115);
            this.trkOpacity.Maximum = 100;
            this.trkOpacity.Minimum = 30;
            this.trkOpacity.Name = "trkOpacity";
            this.trkOpacity.Size = new System.Drawing.Size(104, 45);
            this.trkOpacity.TabIndex = 9;
            this.trkOpacity.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkOpacity.Value = 100;
            this.trkOpacity.ValueChanged += new System.EventHandler(this.trkOpacity_ValueChanged);
            this.trkOpacity.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trkOpacity_MouseDown);
            this.trkOpacity.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trkOpacity_MouseUp);
            // 
            // chkTopMost
            // 
            this.chkTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.Location = new System.Drawing.Point(304, 126);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(100, 17);
            this.chkTopMost.TabIndex = 10;
            this.chkTopMost.Text = "Top of the most";
            this.chkTopMost.UseVisualStyleBackColor = true;
            this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
            // 
            // numOpacity
            // 
            this.numOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numOpacity.Location = new System.Drawing.Point(104, 125);
            this.numOpacity.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numOpacity.Name = "numOpacity";
            this.numOpacity.Size = new System.Drawing.Size(39, 20);
            this.numOpacity.TabIndex = 11;
            this.numOpacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOpacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numOpacity.ValueChanged += new System.EventHandler(this.numOpacity_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "% opacity";
            // 
            // frmAutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 216);
            this.Controls.Add(this.numOpacity);
            this.Controls.Add(this.chkTopMost);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chkToggle);
            this.Controls.Add(this.rdbShift);
            this.Controls.Add(this.rdbPause);
            this.Controls.Add(this.rdbCtrl);
            this.Controls.Add(this.rdbAlt);
            this.Controls.Add(this.rdbScroll);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdbNum);
            this.Controls.Add(this.rdbCaps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTick);
            this.Controls.Add(this.trkTick);
            this.Controls.Add(this.trkOpacity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAutoClicker";
            this.Text = "AutoClicker";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTick)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown numTick;
        private System.Windows.Forms.TrackBar trkTick;
        private System.Windows.Forms.Timer timClock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCaps;
        private System.Windows.Forms.RadioButton rdbNum;
        private System.Windows.Forms.CheckBox chkToggle;
        private System.Windows.Forms.RadioButton rdbAlt;
        private System.Windows.Forms.RadioButton rdbCtrl;
        private System.Windows.Forms.RadioButton rdbShift;
        private System.Windows.Forms.ToolTip ttiToggle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timToggle;
        private System.Windows.Forms.RadioButton rdbPause;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdbScroll;
        private System.Windows.Forms.TrackBar trkOpacity;
        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.NumericUpDown numOpacity;
        private System.Windows.Forms.Label label2;
    }
}

