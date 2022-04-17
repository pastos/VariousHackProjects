
namespace IdleRpgActionWinForm.Buttons
{
    partial class ActionButtonWithTwoChoices
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
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId2)).BeginInit();
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
            // 
            // txtItemId2
            // 
            this.txtItemId2.Location = new System.Drawing.Point(83, 39);
            this.txtItemId2.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtItemId2.Name = "txtItemId2";
            this.txtItemId2.Size = new System.Drawing.Size(92, 23);
            this.txtItemId2.TabIndex = 5;
            // 
            // ActionButtonWithTwoChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtItemId2);
            this.Controls.Add(this.txtItemId1);
            this.Controls.Add(this.btnAction);
            this.Name = "ActionButtonWithTwoChoices";
            this.Size = new System.Drawing.Size(189, 65);
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtItemId1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.NumericUpDown txtItemId2;
    }
}
