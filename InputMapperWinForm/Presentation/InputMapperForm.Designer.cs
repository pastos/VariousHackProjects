﻿
namespace InputMapperWinFormPresentation
{
    partial class InputMapperForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.uCtrlActionMapManager1 = new InputMapperWinForm.Presentation.CustomControls.UCtrlActionMapManager();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(589, 36);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(198, 450);
            this.txtOutput.TabIndex = 2;
            // 
            // uCtrlActionMapManager1
            // 
            this.uCtrlActionMapManager1.Location = new System.Drawing.Point(2, 2);
            this.uCtrlActionMapManager1.Name = "uCtrlActionMapManager1";
            this.uCtrlActionMapManager1.Size = new System.Drawing.Size(471, 52);
            this.uCtrlActionMapManager1.TabIndex = 3;
            // 
            // InputMapperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 507);
            this.Controls.Add(this.uCtrlActionMapManager1);
            this.Controls.Add(this.txtOutput);
            this.Name = "InputMapperForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOutput;
        private InputMapperWinForm.Presentation.CustomControls.UCtrlActionMapManager uCtrlActionMapManager1;
    }
}

