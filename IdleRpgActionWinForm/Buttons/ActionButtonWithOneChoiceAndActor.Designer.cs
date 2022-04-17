
namespace IdleRpgActionWinForm.Buttons
{
    partial class ActionButtonWithOneChoiceAndActor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtItemId1 = new System.Windows.Forms.NumericUpDown();
            this.btnAction = new System.Windows.Forms.Button();
            this.cmbActor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemId1
            // 
            this.txtItemId1.Location = new System.Drawing.Point(83, 3);
            this.txtItemId1.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtItemId1.Name = "txtItemId1";
            this.txtItemId1.Size = new System.Drawing.Size(92, 23);
            this.txtItemId1.TabIndex = 7;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(0, 0);
            this.btnAction.Margin = new System.Windows.Forms.Padding(0);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(80, 62);
            this.btnAction.TabIndex = 6;
            this.btnAction.Text = "Status";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // cmbActor
            // 
            this.cmbActor.FormattingEnabled = true;
            this.cmbActor.Location = new System.Drawing.Point(83, 38);
            this.cmbActor.Name = "cmbActor";
            this.cmbActor.Size = new System.Drawing.Size(92, 23);
            this.cmbActor.TabIndex = 8;
            // 
            // ActionButtonWithOneChoiceAndActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbActor);
            this.Controls.Add(this.txtItemId1);
            this.Controls.Add(this.btnAction);
            this.Name = "ActionButtonWithOneChoiceAndActor";
            this.Size = new System.Drawing.Size(179, 64);
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtItemId1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox cmbActor;
    }
}
