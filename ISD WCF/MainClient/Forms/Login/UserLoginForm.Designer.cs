namespace MainClient
{
    partial class UserLoginForm
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.butSingIn = new System.Windows.Forms.Button();
            this.textBoxHostIp = new System.Windows.Forms.TextBox();
            this.comboBoxConnectionTypes = new System.Windows.Forms.ComboBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblConnectionType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(52, 60);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(157, 20);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginKeyDown);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(52, 108);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(157, 20);
            this.textBoxPass.TabIndex = 1;
            this.textBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginKeyDown);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(184, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(103, 28);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome!";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(49, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(49, 44);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login:";
            // 
            // butSingIn
            // 
            this.butSingIn.Location = new System.Drawing.Point(189, 134);
            this.butSingIn.Name = "butSingIn";
            this.butSingIn.Size = new System.Drawing.Size(75, 23);
            this.butSingIn.TabIndex = 5;
            this.butSingIn.Text = "Sing In";
            this.butSingIn.UseVisualStyleBackColor = true;
            this.butSingIn.Click += new System.EventHandler(this.butSingIn_Click);
            // 
            // textBoxHostIp
            // 
            this.textBoxHostIp.Location = new System.Drawing.Point(224, 60);
            this.textBoxHostIp.Name = "textBoxHostIp";
            this.textBoxHostIp.Size = new System.Drawing.Size(257, 20);
            this.textBoxHostIp.TabIndex = 6;
            this.textBoxHostIp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginKeyDown);
            // 
            // comboBoxConnectionTypes
            // 
            this.comboBoxConnectionTypes.FormattingEnabled = true;
            this.comboBoxConnectionTypes.Location = new System.Drawing.Point(265, 107);
            this.comboBoxConnectionTypes.Name = "comboBoxConnectionTypes";
            this.comboBoxConnectionTypes.Size = new System.Drawing.Size(175, 21);
            this.comboBoxConnectionTypes.TabIndex = 7;
            this.comboBoxConnectionTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginKeyDown);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(228, 44);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(48, 13);
            this.lblIP.TabIndex = 8;
            this.lblIP.Text = "Address:";
            // 
            // lblConnectionType
            // 
            this.lblConnectionType.AutoSize = true;
            this.lblConnectionType.Location = new System.Drawing.Point(262, 92);
            this.lblConnectionType.Name = "lblConnectionType";
            this.lblConnectionType.Size = new System.Drawing.Size(87, 13);
            this.lblConnectionType.TabIndex = 9;
            this.lblConnectionType.Text = "Connection type:";
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(493, 172);
            this.Controls.Add(this.lblConnectionType);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.comboBoxConnectionTypes);
            this.Controls.Add(this.textBoxHostIp);
            this.Controls.Add(this.butSingIn);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sing in";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserLoginForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button butSingIn;
        private System.Windows.Forms.TextBox textBoxHostIp;
        private System.Windows.Forms.ComboBox comboBoxConnectionTypes;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblConnectionType;
    }
}