namespace TechnologyAccessories
{
    partial class frmRegister
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
            btSignUp = new Button();
            llbLogin = new LinkLabel();
            tbEmNa = new TextBox();
            lbTitle = new Label();
            lbEmNa = new Label();
            lbEmRo = new Label();
            lbEmAdd = new Label();
            lbPass = new Label();
            lbEmPh = new Label();
            lbEmUser = new Label();
            tbUsername = new TextBox();
            tbEmAdd = new TextBox();
            tbEmPh = new TextBox();
            tbPass = new TextBox();
            cbbEmRo = new ComboBox();
            SuspendLayout();
            // 
            // btSignUp
            // 
            btSignUp.Location = new Point(332, 378);
            btSignUp.Name = "btSignUp";
            btSignUp.Size = new Size(100, 50);
            btSignUp.TabIndex = 0;
            btSignUp.Text = "Sign Up";
            btSignUp.UseVisualStyleBackColor = true;
            btSignUp.Click += btSignUp_Click;
            // 
            // llbLogin
            // 
            llbLogin.AutoSize = true;
            llbLogin.Location = new Point(278, 490);
            llbLogin.Name = "llbLogin";
            llbLogin.Size = new Size(212, 20);
            llbLogin.TabIndex = 1;
            llbLogin.TabStop = true;
            llbLogin.Text = "Have an account? Sign in here!";
            llbLogin.LinkClicked += llbLogin_LinkClicked;
            // 
            // tbEmNa
            // 
            tbEmNa.Location = new Point(22, 146);
            tbEmNa.Name = "tbEmNa";
            tbEmNa.Size = new Size(342, 27);
            tbEmNa.TabIndex = 2;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(267, 18);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(195, 62);
            lbTitle.TabIndex = 3;
            lbTitle.Text = "Register";
            // 
            // lbEmNa
            // 
            lbEmNa.AutoSize = true;
            lbEmNa.Location = new Point(22, 123);
            lbEmNa.Name = "lbEmNa";
            lbEmNa.Size = new Size(119, 20);
            lbEmNa.TabIndex = 4;
            lbEmNa.Text = "Employee Name";
            // 
            // lbEmRo
            // 
            lbEmRo.AutoSize = true;
            lbEmRo.Location = new Point(22, 192);
            lbEmRo.Name = "lbEmRo";
            lbEmRo.Size = new Size(109, 20);
            lbEmRo.TabIndex = 5;
            lbEmRo.Text = "Employee Role";
            // 
            // lbEmAdd
            // 
            lbEmAdd.AutoSize = true;
            lbEmAdd.Location = new Point(22, 273);
            lbEmAdd.Name = "lbEmAdd";
            lbEmAdd.Size = new Size(132, 20);
            lbEmAdd.TabIndex = 6;
            lbEmAdd.Text = "Employee Address";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(416, 273);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(70, 20);
            lbPass.TabIndex = 7;
            lbPass.Text = "Password";
            // 
            // lbEmPh
            // 
            lbEmPh.AutoSize = true;
            lbEmPh.Location = new Point(416, 123);
            lbEmPh.Name = "lbEmPh";
            lbEmPh.Size = new Size(120, 20);
            lbEmPh.TabIndex = 8;
            lbEmPh.Text = "Employee Phone";
            // 
            // lbEmUser
            // 
            lbEmUser.AutoSize = true;
            lbEmUser.Location = new Point(416, 192);
            lbEmUser.Name = "lbEmUser";
            lbEmUser.Size = new Size(75, 20);
            lbEmUser.TabIndex = 9;
            lbEmUser.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(416, 215);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(342, 27);
            tbUsername.TabIndex = 10;
            // 
            // tbEmAdd
            // 
            tbEmAdd.Location = new Point(22, 296);
            tbEmAdd.Name = "tbEmAdd";
            tbEmAdd.Size = new Size(342, 27);
            tbEmAdd.TabIndex = 11;
            // 
            // tbEmPh
            // 
            tbEmPh.Location = new Point(416, 146);
            tbEmPh.Name = "tbEmPh";
            tbEmPh.Size = new Size(342, 27);
            tbEmPh.TabIndex = 12;
            tbEmPh.KeyPress += tbEmPh_KeyPress;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(416, 296);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(342, 27);
            tbPass.TabIndex = 13;
            // 
            // cbbEmRo
            // 
            cbbEmRo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEmRo.FormattingEnabled = true;
            cbbEmRo.Items.AddRange(new object[] { "Admin", "Warehouse", "Sale" });
            cbbEmRo.Location = new Point(22, 215);
            cbbEmRo.Name = "cbbEmRo";
            cbbEmRo.Size = new Size(342, 28);
            cbbEmRo.TabIndex = 15;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(cbbEmRo);
            Controls.Add(tbPass);
            Controls.Add(tbEmPh);
            Controls.Add(tbEmAdd);
            Controls.Add(tbUsername);
            Controls.Add(lbEmUser);
            Controls.Add(lbEmPh);
            Controls.Add(lbPass);
            Controls.Add(lbEmAdd);
            Controls.Add(lbEmRo);
            Controls.Add(lbEmNa);
            Controls.Add(lbTitle);
            Controls.Add(tbEmNa);
            Controls.Add(llbLogin);
            Controls.Add(btSignUp);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Technology Accessories";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSignUp;
        private LinkLabel llbLogin;
        private TextBox tbEmNa;
        private Label lbTitle;
        private Label lbEmNa;
        private Label lbEmRo;
        private Label lbEmAdd;
        private Label lbPass;
        private Label lbEmPh;
        private Label lbEmUser;
        private TextBox tbUsername;
        private TextBox tbEmAdd;
        private TextBox tbEmPh;
        private TextBox tbPass;
        private ComboBox cbbEmRo;
    }
}