namespace WFNovo
{
    partial class FrmLogin
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
            Username = new Label();
            Password = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(60, 75);
            Username.Name = "Username";
            Username.Size = new Size(63, 15);
            Username.TabIndex = 3;
            Username.Text = "Username:";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(60, 122);
            Password.Name = "Password";
            Password.Size = new Size(60, 15);
            Password.TabIndex = 4;
            Password.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(148, 75);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(148, 119);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(159, 160);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 255);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Username;
        private Label Password;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
