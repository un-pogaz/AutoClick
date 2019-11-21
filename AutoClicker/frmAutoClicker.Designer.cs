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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoClicker));
            this.btnActivate = new System.Windows.Forms.Button();
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
            this.rdbScroll = new System.Windows.Forms.RadioButton();
            this.trkOpacity = new System.Windows.Forms.TrackBar();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.numTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTick)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.Location = new System.Drawing.Point(3, 3);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(193, 57);
            this.btnActivate.TabIndex = 0;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(202, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(193, 57);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // numTick
            // 
            this.numTick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTick.Location = new System.Drawing.Point(326, 44);
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
            this.trkTick.Location = new System.Drawing.Point(5, 8);
            this.trkTick.Maximum = 10000;
            this.trkTick.Minimum = 1;
            this.trkTick.Name = "trkTick";
            this.trkTick.Size = new System.Drawing.Size(399, 45);
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
            this.label1.Location = new System.Drawing.Point(387, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ms";
            // 
            // rdbCaps
            // 
            this.rdbCaps.AutoSize = true;
            this.rdbCaps.Checked = true;
            this.rdbCaps.Location = new System.Drawing.Point(9, 59);
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
            this.rdbNum.Location = new System.Drawing.Point(9, 82);
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
            this.chkToggle.Location = new System.Drawing.Point(315, 83);
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
            this.rdbAlt.Location = new System.Drawing.Point(192, 59);
            this.rdbAlt.Name = "rdbAlt";
            this.rdbAlt.Size = new System.Drawing.Size(37, 17);
            this.rdbAlt.TabIndex = 6;
            this.rdbAlt.Text = "Alt";
            this.rdbAlt.UseVisualStyleBackColor = true;
            // 
            // rdbCtrl
            // 
            this.rdbCtrl.AutoSize = true;
            this.rdbCtrl.Location = new System.Drawing.Point(192, 82);
            this.rdbCtrl.Name = "rdbCtrl";
            this.rdbCtrl.Size = new System.Drawing.Size(40, 17);
            this.rdbCtrl.TabIndex = 6;
            this.rdbCtrl.Text = "Ctrl";
            this.rdbCtrl.UseVisualStyleBackColor = true;
            // 
            // rdbShift
            // 
            this.rdbShift.AutoSize = true;
            this.rdbShift.Location = new System.Drawing.Point(235, 59);
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
            this.tableLayoutPanel1.Controls.Add(this.btnActivate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStop, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 63);
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
            this.rdbPause.Location = new System.Drawing.Point(235, 82);
            this.rdbPause.Name = "rdbPause";
            this.rdbPause.Size = new System.Drawing.Size(55, 17);
            this.rdbPause.TabIndex = 6;
            this.rdbPause.Text = "Pause";
            this.rdbPause.UseVisualStyleBackColor = true;
            // 
            // rdbScroll
            // 
            this.rdbScroll.AutoSize = true;
            this.rdbScroll.Location = new System.Drawing.Point(91, 59);
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
            this.trkOpacity.Location = new System.Drawing.Point(3, 8);
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
            this.chkTopMost.Location = new System.Drawing.Point(307, 21);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(100, 17);
            this.chkTopMost.TabIndex = 10;
            this.chkTopMost.Text = "Top of the most";
            this.chkTopMost.UseVisualStyleBackColor = true;
            this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
            // 
            // lblOpacity
            // 
            this.lblOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(102, 22);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(70, 13);
            this.lblOpacity.TabIndex = 4;
            this.lblOpacity.Text = "100% opacity";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.numTick);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.trkTick);
            this.splitContainer1.Panel1.Controls.Add(this.rdbCaps);
            this.splitContainer1.Panel1.Controls.Add(this.chkToggle);
            this.splitContainer1.Panel1.Controls.Add(this.rdbNum);
            this.splitContainer1.Panel1.Controls.Add(this.rdbShift);
            this.splitContainer1.Panel1.Controls.Add(this.rdbPause);
            this.splitContainer1.Panel1.Controls.Add(this.rdbScroll);
            this.splitContainer1.Panel1.Controls.Add(this.rdbCtrl);
            this.splitContainer1.Panel1.Controls.Add(this.rdbAlt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.lblOpacity);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.chkTopMost);
            this.splitContainer1.Panel2.Controls.Add(this.trkOpacity);
            this.splitContainer1.Size = new System.Drawing.Size(410, 220);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 11;
            // 
            // frmAutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 220);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActivate;
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
        private System.Windows.Forms.RadioButton rdbScroll;
        private System.Windows.Forms.TrackBar trkOpacity;
        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

