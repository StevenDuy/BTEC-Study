namespace TechnologyAccessories
{
    partial class frmLogin
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
            lbUsername = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lbPassword = new Label();
            btLogin = new Button();
            llbSignUp = new LinkLabel();
            lbTitle = new Label();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(209, 173);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(209, 196);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(340, 27);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(209, 297);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(340, 27);
            tbPassword.TabIndex = 3;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(209, 274);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // btLogin
            // 
            btLogin.Location = new Point(327, 390);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(100, 70);
            btLogin.TabIndex = 4;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // llbSignUp
            // 
            llbSignUp.AutoSize = true;
            llbSignUp.Location = new Point(268, 498);
            llbSignUp.Name = "llbSignUp";
            llbSignUp.Size = new Size(226, 20);
            llbSignUp.TabIndex = 5;
            llbSignUp.TabStop = true;
            llbSignUp.Text = "Haven't an account? Create here!";
            llbSignUp.LinkClicked += llbSignUp_LinkClicked;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(280, 34);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(171, 62);
            lbTitle.TabIndex = 6;
            lbTitle.Text = "Sign In";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(lbTitle);
            Controls.Add(llbSignUp);
            Controls.Add(btLogin);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lbUsername);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Technology Accessories";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lbPassword;
        private Button btLogin;
        private LinkLabel llbSignUp;
        private Label lbTitle;
    }
}