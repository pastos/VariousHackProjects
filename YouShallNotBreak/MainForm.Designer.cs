namespace YouShallNotBreak
{
    partial class MainForm
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
            this.numRunningTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtWindowName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCurrentMousePosition = new System.Windows.Forms.Label();
            this.ddlGridSize = new System.Windows.Forms.ComboBox();
            this.txtCodeGenerator = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.numInverseAbilityStartSecond = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numInverseDuration = new System.Windows.Forms.NumericUpDown();
            this.chkHasInverseAbility = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numInverseDuration2 = new System.Windows.Forms.NumericUpDown();
            this.numInverseAbilityStartSecond2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRunningTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverseAbilityStartSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverseDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverseDuration2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverseAbilityStartSecond2)).BeginInit();
            this.SuspendLayout();
            // 
            // numRunningTime
            // 
            this.numRunningTime.Location = new System.Drawing.Point(277, 63);
            this.numRunningTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRunningTime.Name = "numRunningTime";
            this.numRunningTime.Size = new System.Drawing.Size(120, 20);
            this.numRunningTime.TabIndex = 0;
            this.numRunningTime.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Running time";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(48, 240);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 84);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(230, 240);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(127, 84);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtWindowName
            // 
            this.txtWindowName.Location = new System.Drawing.Point(277, 13);
            this.txtWindowName.Name = "txtWindowName";
            this.txtWindowName.Size = new System.Drawing.Size(198, 20);
            this.txtWindowName.TabIndex = 4;
            this.txtWindowName.Text = "You Shall Not Break!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Window Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grid Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inverse Ability starts at:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Current Mouse Position";
            // 
            // lblCurrentMousePosition
            // 
            this.lblCurrentMousePosition.AutoSize = true;
            this.lblCurrentMousePosition.Location = new System.Drawing.Point(631, 70);
            this.lblCurrentMousePosition.Name = "lblCurrentMousePosition";
            this.lblCurrentMousePosition.Size = new System.Drawing.Size(20, 13);
            this.lblCurrentMousePosition.TabIndex = 17;
            this.lblCurrentMousePosition.Text = "x,y";
            // 
            // ddlGridSize
            // 
            this.ddlGridSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGridSize.FormattingEnabled = true;
            this.ddlGridSize.Items.AddRange(new object[] {
            "4x4",
            "5x5",
            "6x6",
            "7x7"});
            this.ddlGridSize.Location = new System.Drawing.Point(276, 98);
            this.ddlGridSize.Name = "ddlGridSize";
            this.ddlGridSize.Size = new System.Drawing.Size(121, 21);
            this.ddlGridSize.TabIndex = 18;
            this.ddlGridSize.SelectedIndexChanged += new System.EventHandler(this.ddlGridSize_SelectedIndexChanged);
            // 
            // txtCodeGenerator
            // 
            this.txtCodeGenerator.Location = new System.Drawing.Point(409, 138);
            this.txtCodeGenerator.Multiline = true;
            this.txtCodeGenerator.Name = "txtCodeGenerator";
            this.txtCodeGenerator.Size = new System.Drawing.Size(379, 271);
            this.txtCodeGenerator.TabIndex = 19;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(230, 330);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(127, 84);
            this.btnTrain.TabIndex = 20;
            this.btnTrain.Text = "Training Mode";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // numInverseAbilityStartSecond
            // 
            this.numInverseAbilityStartSecond.Location = new System.Drawing.Point(276, 169);
            this.numInverseAbilityStartSecond.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInverseAbilityStartSecond.Name = "numInverseAbilityStartSecond";
            this.numInverseAbilityStartSecond.Size = new System.Drawing.Size(37, 20);
            this.numInverseAbilityStartSecond.TabIndex = 21;
            this.numInverseAbilityStartSecond.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Inverse Ability duration:";
            // 
            // numInverseDuration
            // 
            this.numInverseDuration.Location = new System.Drawing.Point(276, 196);
            this.numInverseDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInverseDuration.Name = "numInverseDuration";
            this.numInverseDuration.Size = new System.Drawing.Size(37, 20);
            this.numInverseDuration.TabIndex = 23;
            this.numInverseDuration.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // chkHasInverseAbility
            // 
            this.chkHasInverseAbility.AutoSize = true;
            this.chkHasInverseAbility.Location = new System.Drawing.Point(276, 138);
            this.chkHasInverseAbility.Name = "chkHasInverseAbility";
            this.chkHasInverseAbility.Size = new System.Drawing.Size(15, 14);
            this.chkHasInverseAbility.TabIndex = 24;
            this.chkHasInverseAbility.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Inverse Ability";
            // 
            // numInverseDuration2
            // 
            this.numInverseDuration2.Location = new System.Drawing.Point(320, 196);
            this.numInverseDuration2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInverseDuration2.Name = "numInverseDuration2";
            this.numInverseDuration2.Size = new System.Drawing.Size(37, 20);
            this.numInverseDuration2.TabIndex = 27;
            this.numInverseDuration2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numInverseAbilityStartSecond2
            // 
            this.numInverseAbilityStartSecond2.Location = new System.Drawing.Point(320, 169);
            this.numInverseAbilityStartSecond2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInverseAbilityStartSecond2.Name = "numInverseAbilityStartSecond2";
            this.numInverseAbilityStartSecond2.Size = new System.Drawing.Size(37, 20);
            this.numInverseAbilityStartSecond2.TabIndex = 26;
            this.numInverseAbilityStartSecond2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numInverseDuration2);
            this.Controls.Add(this.numInverseAbilityStartSecond2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkHasInverseAbility);
            this.Controls.Add(this.numInverseDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numInverseAbilityStartSecond);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.txtCodeGenerator);
            this.Controls.Add(this.ddlGridSize);
            this.Controls.Add(this.lblCurrentMousePosition);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWindowName);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRunningTime);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numRunningTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverseAbilityStartSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverseDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverseDuration2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverseAbilityStartSecond2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numRunningTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtWindowName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurrentMousePosition;
        private System.Windows.Forms.ComboBox ddlGridSize;
        private System.Windows.Forms.TextBox txtCodeGenerator;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.NumericUpDown numInverseAbilityStartSecond;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numInverseDuration;
        private System.Windows.Forms.CheckBox chkHasInverseAbility;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numInverseDuration2;
        private System.Windows.Forms.NumericUpDown numInverseAbilityStartSecond2;
    }
}

