
namespace IdleRpgActionWinForm.Buttons
{
    partial class ActionButtonWithOneChoiceAndDropdownChoiceAndOneChoice
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
            this.txtBet = new System.Windows.Forms.NumericUpDown();
            this.txtNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
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
            this.ddl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl.FormattingEnabled = true;
            this.ddl.Location = new System.Drawing.Point(179, 4);
            this.ddl.Name = "ddl";
            this.ddl.Size = new System.Drawing.Size(92, 23);
            this.ddl.TabIndex = 5;
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(81, 4);
            this.txtBet.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(92, 23);
            this.txtBet.TabIndex = 6;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(81, 33);
            this.txtNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(92, 23);
            this.txtNumber.TabIndex = 7;
            // 
            // ActionButtonWithOneChoiceAndDropdownChoiceAndOneChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.ddl);
            this.Controls.Add(this.btnAction);
            this.Name = "ActionButtonWithOneChoiceAndDropdownChoiceAndOneChoice";
            this.Size = new System.Drawing.Size(274, 63);
            ((System.ComponentModel.ISupportInitialize)(this.txtBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox ddl;
        private System.Windows.Forms.NumericUpDown txtBet;
        private System.Windows.Forms.NumericUpDown txtNumber;
    }
}
