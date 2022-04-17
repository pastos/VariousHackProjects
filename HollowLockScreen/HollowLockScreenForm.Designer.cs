namespace HollowLockScreen
{
    partial class HollowLockScreenForm
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
            this.components = new System.ComponentModel.Container();
            this.btnSetPassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblHotzone = new System.Windows.Forms.Label();
            this.lblConfirmHotzone = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errIcon = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetPassword
            // 
            this.btnSetPassword.Location = new System.Drawing.Point(308, 3);
            this.btnSetPassword.Name = "btnSetPassword";
            this.btnSetPassword.Size = new System.Drawing.Size(98, 42);
            this.btnSetPassword.TabIndex = 0;
            this.btnSetPassword.Text = "Set New Password";
            this.btnSetPassword.UseVisualStyleBackColor = true;
            this.btnSetPassword.Click += new System.EventHandler(this.btnSetPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.errIcon.SetIconPadding(this.txtPassword, -20);
            this.txtPassword.Location = new System.Drawing.Point(12, 25);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(186, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Enabled = false;
            this.errIcon.SetIconPadding(this.txtConfirmPassword, -20);
            this.txtConfirmPassword.Location = new System.Drawing.Point(12, 69);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(186, 20);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(13, 3);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(77, 13);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "New password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(13, 51);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(90, 13);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirm password";
            // 
            // lblHotzone
            // 
            this.lblHotzone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHotzone.Enabled = false;
            this.lblHotzone.ForeColor = System.Drawing.Color.Black;
            this.lblHotzone.Location = new System.Drawing.Point(204, 4);
            this.lblHotzone.Name = "lblHotzone";
            this.lblHotzone.Size = new System.Drawing.Size(98, 41);
            this.lblHotzone.TabIndex = 6;
            this.lblHotzone.Text = "Mouse Hotzone";
            this.lblHotzone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHotzone.Click += new System.EventHandler(this.lblHotzone_Click);
            // 
            // lblConfirmHotzone
            // 
            this.lblConfirmHotzone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblConfirmHotzone.Enabled = false;
            this.lblConfirmHotzone.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmHotzone.Location = new System.Drawing.Point(204, 58);
            this.lblConfirmHotzone.Name = "lblConfirmHotzone";
            this.lblConfirmHotzone.Size = new System.Drawing.Size(98, 41);
            this.lblConfirmHotzone.TabIndex = 7;
            this.lblConfirmHotzone.Text = "Confirm Mouse Hotzone";
            this.lblConfirmHotzone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfirmHotzone.Click += new System.EventHandler(this.lblConfirmHotzone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(308, 57);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 42);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errIcon
            // 
            this.errIcon.ContainerControl = this;
            // 
            // HollowLockScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 101);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblConfirmHotzone);
            this.Controls.Add(this.lblHotzone);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSetPassword);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 140);
            this.Name = "HollowLockScreenForm";
            this.Text = "Hollow Lock Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HollowLockScreenForm_FormClosing);
            this.Resize += new System.EventHandler(this.HollowLockScreenForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.errIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblHotzone;
        private System.Windows.Forms.Label lblConfirmHotzone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errIcon;
    }
}

