
namespace IdleRpgActionWinForm.Buttons
{
    partial class ActionButtonWithTwoChoicesAndText
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
            this.txtItemId2 = new System.Windows.Forms.NumericUpDown();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemId1
            // 
            this.txtItemId1.Location = new System.Drawing.Point(83, 3);
            this.txtItemId1.Maximum = new decimal(new int[] {
            8760,
            0,
            0,
            0});
            this.txtItemId1.Name = "txtItemId1";
            this.txtItemId1.Size = new System.Drawing.Size(49, 23);
            this.txtItemId1.TabIndex = 4;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(0, 0);
            this.btnAction.Margin = new System.Windows.Forms.Padding(0);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(80, 62);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Status";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtItemId2
            // 
            this.txtItemId2.Location = new System.Drawing.Point(190, 3);
            this.txtItemId2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtItemId2.Name = "txtItemId2";
            this.txtItemId2.Size = new System.Drawing.Size(49, 23);
            this.txtItemId2.TabIndex = 5;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(83, 32);
            this.txtNote.Name = "txtNote";
            this.txtNote.PlaceholderText = "Reason";
            this.txtNote.Size = new System.Drawing.Size(118, 23);
            this.txtNote.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "hour(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "min(s)";
            // 
            // ActionButtonWithTwoChoicesAndText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtItemId2);
            this.Controls.Add(this.txtItemId1);
            this.Controls.Add(this.btnAction);
            this.Name = "ActionButtonWithTwoChoicesAndText";
            this.Size = new System.Drawing.Size(299, 65);
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtItemId1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.NumericUpDown txtItemId2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
