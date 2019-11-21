﻿namespace AutoClick
{
    partial class Form1
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
            this.numNumeric = new System.Windows.Forms.NumericUpDown();
            this.trkTrackBar = new System.Windows.Forms.TrackBar();
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
            ((System.ComponentModel.ISupportInitialize)(this.numNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTrackBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // numNumeric
            // 
            this.numNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumeric.Location = new System.Drawing.Point(321, 48);
            this.numNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumeric.Name = "numNumeric";
            this.numNumeric.Size = new System.Drawing.Size(59, 20);
            this.numNumeric.TabIndex = 2;
            this.numNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numNumeric.ValueChanged += new System.EventHandler(this.numNumeric_ValueChanged);
            // 
            // trkTrackBar
            // 
            this.trkTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkTrackBar.Location = new System.Drawing.Point(12, 12);
            this.trkTrackBar.Maximum = 10000;
            this.trkTrackBar.Minimum = 1;
            this.trkTrackBar.Name = "trkTrackBar";
            this.trkTrackBar.Size = new System.Drawing.Size(386, 45);
            this.trkTrackBar.TabIndex = 3;
            this.trkTrackBar.Value = 100;
            this.trkTrackBar.ValueChanged += new System.EventHandler(this.trkTrackBar_ValueChanged);
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
            this.chkToggle.Location = new System.Drawing.Point(309, 87);
            this.chkToggle.Name = "chkToggle";
            this.chkToggle.Size = new System.Drawing.Size(89, 17);
            this.chkToggle.TabIndex = 7;
            this.chkToggle.Text = "Toggle Mode";
            this.ttiToggle.SetToolTip(this.chkToggle, "Enable the Toggle Mode for \"Ctrl\", \"Alt\" and \"Maj\".");
            this.chkToggle.UseVisualStyleBackColor = true;
            // 
            // rdbAlt
            // 
            this.rdbAlt.AutoSize = true;
            this.rdbAlt.Location = new System.Drawing.Point(109, 63);
            this.rdbAlt.Name = "rdbAlt";
            this.rdbAlt.Size = new System.Drawing.Size(37, 17);
            this.rdbAlt.TabIndex = 6;
            this.rdbAlt.Text = "Alt";
            this.rdbAlt.UseVisualStyleBackColor = true;
            // 
            // rdbCtrl
            // 
            this.rdbCtrl.AutoSize = true;
            this.rdbCtrl.Location = new System.Drawing.Point(109, 86);
            this.rdbCtrl.Name = "rdbCtrl";
            this.rdbCtrl.Size = new System.Drawing.Size(40, 17);
            this.rdbCtrl.TabIndex = 6;
            this.rdbCtrl.Text = "Ctrl";
            this.rdbCtrl.UseVisualStyleBackColor = true;
            // 
            // rdbShift
            // 
            this.rdbShift.AutoSize = true;
            this.rdbShift.Location = new System.Drawing.Point(152, 63);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 114);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 182);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chkToggle);
            this.Controls.Add(this.rdbShift);
            this.Controls.Add(this.rdbCtrl);
            this.Controls.Add(this.rdbAlt);
            this.Controls.Add(this.rdbNum);
            this.Controls.Add(this.rdbCaps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numNumeric);
            this.Controls.Add(this.trkTrackBar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTrackBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown numNumeric;
        private System.Windows.Forms.TrackBar trkTrackBar;
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
    }
}
