
namespace InputMapperWinForm.Presentation.CustomControls
{
    partial class UCtrlActionMapPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new UCtrlButton();
            this.lblNewAction = new System.Windows.Forms.Label();
            this.ddlOriginalAction = new System.Windows.Forms.ComboBox();
            this.ddlNewAction = new System.Windows.Forms.ComboBox();
            this.lblOriginalAction = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.lblNewAction);
            this.panel1.Controls.Add(this.ddlOriginalAction);
            this.panel1.Controls.Add(this.ddlNewAction);
            this.panel1.Controls.Add(this.lblOriginalAction);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 48);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "-->";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(356, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(412, 18);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // lblNewAction
            // 
            this.lblNewAction.AutoSize = true;
            this.lblNewAction.Location = new System.Drawing.Point(199, 0);
            this.lblNewAction.Name = "lblNewAction";
            this.lblNewAction.Size = new System.Drawing.Size(69, 15);
            this.lblNewAction.TabIndex = 5;
            this.lblNewAction.Text = "New Action";
            // 
            // ddlOriginalAction
            // 
            this.ddlOriginalAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOriginalAction.FormattingEnabled = true;
            this.ddlOriginalAction.Location = new System.Drawing.Point(3, 18);
            this.ddlOriginalAction.MaxDropDownItems = 26;
            this.ddlOriginalAction.Name = "ddlOriginalAction";
            this.ddlOriginalAction.Size = new System.Drawing.Size(143, 23);
            this.ddlOriginalAction.TabIndex = 4;
            // 
            // ddlNewAction
            // 
            this.ddlNewAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlNewAction.FormattingEnabled = true;
            this.ddlNewAction.Location = new System.Drawing.Point(187, 17);
            this.ddlNewAction.MaxDropDownItems = 26;
            this.ddlNewAction.Name = "ddlNewAction";
            this.ddlNewAction.Size = new System.Drawing.Size(143, 23);
            this.ddlNewAction.TabIndex = 3;
            // 
            // lblOriginalAction
            // 
            this.lblOriginalAction.AutoSize = true;
            this.lblOriginalAction.Location = new System.Drawing.Point(3, 0);
            this.lblOriginalAction.Name = "lblOriginalAction";
            this.lblOriginalAction.Size = new System.Drawing.Size(87, 15);
            this.lblOriginalAction.TabIndex = 0;
            this.lblOriginalAction.Text = "Original Action";
            // 
            // UCtrlActionMapPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCtrlActionMapPanel";
            this.Size = new System.Drawing.Size(471, 54);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNewAction;
        private System.Windows.Forms.ComboBox ddlOriginalAction;
        private System.Windows.Forms.ComboBox ddlNewAction;
        private System.Windows.Forms.Label lblOriginalAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private UCtrlButton btnDel;
    }
}
