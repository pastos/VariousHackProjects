namespace EmpiresAndPuzzles
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnScan = new System.Windows.Forms.Button();
            this.numMinutesPerEnergy = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numCurrentWorldEnergy = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numTotalWorldEnergy = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chkKeepAlive = new System.Windows.Forms.CheckBox();
            this.lblCountdownEnergy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCountdownNextAction = new System.Windows.Forms.Label();
            this.numSecondsToReplay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.txtWindowName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numEnergyPerFight = new System.Windows.Forms.NumericUpDown();
            this.numKeepAliveInterval = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkStartIn = new System.Windows.Forms.CheckBox();
            this.numStartInSeconds = new System.Windows.Forms.NumericUpDown();
            this.numStartInMinutes = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutesPerEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentWorldEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalWorldEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondsToReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnergyPerFight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeepAliveInterval)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartInSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartInMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.OliveDrab;
            this.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(9, 268);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(137, 75);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Farm it hard";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // numMinutesPerEnergy
            // 
            this.numMinutesPerEnergy.BackColor = System.Drawing.Color.GreenYellow;
            this.numMinutesPerEnergy.Location = new System.Drawing.Point(118, 88);
            this.numMinutesPerEnergy.Name = "numMinutesPerEnergy";
            this.numMinutesPerEnergy.Size = new System.Drawing.Size(50, 20);
            this.numMinutesPerEnergy.TabIndex = 29;
            this.numMinutesPerEnergy.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Minutes per energy";
            // 
            // numCurrentWorldEnergy
            // 
            this.numCurrentWorldEnergy.BackColor = System.Drawing.Color.GreenYellow;
            this.numCurrentWorldEnergy.Location = new System.Drawing.Point(118, 61);
            this.numCurrentWorldEnergy.Name = "numCurrentWorldEnergy";
            this.numCurrentWorldEnergy.Size = new System.Drawing.Size(50, 20);
            this.numCurrentWorldEnergy.TabIndex = 31;
            this.numCurrentWorldEnergy.Value = new decimal(new int[] {
            38,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "World Energy";
            // 
            // numTotalWorldEnergy
            // 
            this.numTotalWorldEnergy.BackColor = System.Drawing.Color.GreenYellow;
            this.numTotalWorldEnergy.Location = new System.Drawing.Point(180, 61);
            this.numTotalWorldEnergy.Name = "numTotalWorldEnergy";
            this.numTotalWorldEnergy.Size = new System.Drawing.Size(50, 20);
            this.numTotalWorldEnergy.TabIndex = 33;
            this.numTotalWorldEnergy.Value = new decimal(new int[] {
            38,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(3, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Keep Alive";
            // 
            // chkKeepAlive
            // 
            this.chkKeepAlive.AutoSize = true;
            this.chkKeepAlive.BackColor = System.Drawing.SystemColors.Control;
            this.chkKeepAlive.Checked = true;
            this.chkKeepAlive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepAlive.Location = new System.Drawing.Point(118, 161);
            this.chkKeepAlive.Name = "chkKeepAlive";
            this.chkKeepAlive.Size = new System.Drawing.Size(15, 14);
            this.chkKeepAlive.TabIndex = 35;
            this.chkKeepAlive.UseVisualStyleBackColor = false;
            // 
            // lblCountdownEnergy
            // 
            this.lblCountdownEnergy.AutoSize = true;
            this.lblCountdownEnergy.BackColor = System.Drawing.Color.GreenYellow;
            this.lblCountdownEnergy.Location = new System.Drawing.Point(177, 91);
            this.lblCountdownEnergy.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblCountdownEnergy.Name = "lblCountdownEnergy";
            this.lblCountdownEnergy.Size = new System.Drawing.Size(34, 13);
            this.lblCountdownEnergy.TabIndex = 36;
            this.lblCountdownEnergy.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(3, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Next Replay(seconds)";
            // 
            // lblCountdownNextAction
            // 
            this.lblCountdownNextAction.AutoSize = true;
            this.lblCountdownNextAction.BackColor = System.Drawing.Color.GreenYellow;
            this.lblCountdownNextAction.Location = new System.Drawing.Point(115, 210);
            this.lblCountdownNextAction.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblCountdownNextAction.Name = "lblCountdownNextAction";
            this.lblCountdownNextAction.Size = new System.Drawing.Size(34, 13);
            this.lblCountdownNextAction.TabIndex = 38;
            this.lblCountdownNextAction.Text = "00:00";
            // 
            // numSecondsToReplay
            // 
            this.numSecondsToReplay.BackColor = System.Drawing.Color.GreenYellow;
            this.numSecondsToReplay.Location = new System.Drawing.Point(118, 183);
            this.numSecondsToReplay.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numSecondsToReplay.Name = "numSecondsToReplay";
            this.numSecondsToReplay.Size = new System.Drawing.Size(50, 20);
            this.numSecondsToReplay.TabIndex = 39;
            this.numSecondsToReplay.Value = new decimal(new int[] {
            135,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(3, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Next action in";
            // 
            // btnStopAll
            // 
            this.btnStopAll.BackColor = System.Drawing.Color.Crimson;
            this.btnStopAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStopAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopAll.ForeColor = System.Drawing.Color.White;
            this.btnStopAll.Location = new System.Drawing.Point(203, 268);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(137, 75);
            this.btnStopAll.TabIndex = 41;
            this.btnStopAll.Text = "Enough. Let me play";
            this.btnStopAll.UseVisualStyleBackColor = false;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // txtWindowName
            // 
            this.txtWindowName.Location = new System.Drawing.Point(130, 12);
            this.txtWindowName.Name = "txtWindowName";
            this.txtWindowName.Size = new System.Drawing.Size(239, 20);
            this.txtWindowName.TabIndex = 42;
            this.txtWindowName.Text = "BlueStacks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Window name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.GreenYellow;
            this.label7.Location = new System.Drawing.Point(3, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Energy per Fight";
            // 
            // numEnergyPerFight
            // 
            this.numEnergyPerFight.BackColor = System.Drawing.Color.GreenYellow;
            this.numEnergyPerFight.Location = new System.Drawing.Point(118, 121);
            this.numEnergyPerFight.Name = "numEnergyPerFight";
            this.numEnergyPerFight.Size = new System.Drawing.Size(50, 20);
            this.numEnergyPerFight.TabIndex = 45;
            this.numEnergyPerFight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numKeepAliveInterval
            // 
            this.numKeepAliveInterval.BackColor = System.Drawing.Color.GreenYellow;
            this.numKeepAliveInterval.Location = new System.Drawing.Point(180, 159);
            this.numKeepAliveInterval.Name = "numKeepAliveInterval";
            this.numKeepAliveInterval.Size = new System.Drawing.Size(50, 20);
            this.numKeepAliveInterval.TabIndex = 46;
            this.numKeepAliveInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chkStartIn);
            this.panel1.Controls.Add(this.numStartInSeconds);
            this.panel1.Controls.Add(this.numStartInMinutes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numKeepAliveInterval);
            this.panel1.Controls.Add(this.numMinutesPerEnergy);
            this.panel1.Controls.Add(this.numEnergyPerFight);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numCurrentWorldEnergy);
            this.panel1.Controls.Add(this.numTotalWorldEnergy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkKeepAlive);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCountdownEnergy);
            this.panel1.Controls.Add(this.numSecondsToReplay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCountdownNextAction);
            this.panel1.Location = new System.Drawing.Point(9, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 224);
            this.panel1.TabIndex = 47;
            // 
            // chkStartIn
            // 
            this.chkStartIn.AutoSize = true;
            this.chkStartIn.BackColor = System.Drawing.SystemColors.Control;
            this.chkStartIn.Location = new System.Drawing.Point(234, 31);
            this.chkStartIn.Name = "chkStartIn";
            this.chkStartIn.Size = new System.Drawing.Size(15, 14);
            this.chkStartIn.TabIndex = 50;
            this.chkStartIn.UseVisualStyleBackColor = false;
            // 
            // numStartInSeconds
            // 
            this.numStartInSeconds.BackColor = System.Drawing.Color.GreenYellow;
            this.numStartInSeconds.Location = new System.Drawing.Point(177, 29);
            this.numStartInSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numStartInSeconds.Name = "numStartInSeconds";
            this.numStartInSeconds.Size = new System.Drawing.Size(50, 20);
            this.numStartInSeconds.TabIndex = 49;
            // 
            // numStartInMinutes
            // 
            this.numStartInMinutes.BackColor = System.Drawing.Color.GreenYellow;
            this.numStartInMinutes.Location = new System.Drawing.Point(121, 29);
            this.numStartInMinutes.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numStartInMinutes.Name = "numStartInMinutes";
            this.numStartInMinutes.Size = new System.Drawing.Size(47, 20);
            this.numStartInMinutes.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.GreenYellow;
            this.label8.Location = new System.Drawing.Point(3, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Start in";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::EmpiresAndPuzzles.Properties.Resources.eaz1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnStopAll;
            this.ClientSize = new System.Drawing.Size(490, 355);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWindowName);
            this.Controls.Add(this.btnStopAll);
            this.Controls.Add(this.btnScan);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Empires and Puzzles";
            ((System.ComponentModel.ISupportInitialize)(this.numMinutesPerEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentWorldEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalWorldEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondsToReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnergyPerFight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeepAliveInterval)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartInSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartInMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.NumericUpDown numMinutesPerEnergy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCurrentWorldEnergy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTotalWorldEnergy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkKeepAlive;
        private System.Windows.Forms.Label lblCountdownEnergy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCountdownNextAction;
        private System.Windows.Forms.NumericUpDown numSecondsToReplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.TextBox txtWindowName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numEnergyPerFight;
        private System.Windows.Forms.NumericUpDown numKeepAliveInterval;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numStartInSeconds;
        private System.Windows.Forms.NumericUpDown numStartInMinutes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkStartIn;
    }
}

