
namespace IdleRpgActionWinForm.Buttons
{
    partial class ActionButtonWithDropdownChoice
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
            this.btnAction = new System.Windows.Forms.Button();
            this.ddl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(0, 0);
            this.btnAction.Margin = new System.Windows.Forms.Padding(0);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(80, 62);
            this.btnAction.TabIndex = 4;
            this.btnAction.Text = "Status";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // ddl
            // 
            this.ddl.FormattingEnabled = true;
            this.ddl.Location = new System.Drawing.Point(83, 21);
            this.ddl.Name = "ddl";
            this.ddl.Size = new System.Drawing.Size(92, 23);
            this.ddl.TabIndex = 5;
            // 
            // ActionButtonWithDropdownChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ddl);
            this.Controls.Add(this.btnAction);
            this.Name = "ActionButtonWithDropdownChoice";
            this.Size = new System.Drawing.Size(178, 63);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox ddl;
    }
}
