namespace GameCollectionManagement
{
    partial class LoginForm
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
            Label label2;
            btnLogin = new Button();
            txtUserName = new TextBox();
            label1 = new Label();
            btnNewUser = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 89);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Parola";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(237, 144);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 45);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(132, 34);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(211, 23);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 37);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı";
            // 
            // btnNewUser
            // 
            btnNewUser.Location = new Point(108, 144);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(106, 45);
            btnNewUser.TabIndex = 5;
            btnNewUser.Text = "Yeni Kullanıcı";
            btnNewUser.UseVisualStyleBackColor = true;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(132, 86);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 23);
            txtPassword.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 237);
            Controls.Add(txtPassword);
            Controls.Add(btnNewUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "Giriş Ekranı";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUserName;
        private Label label1;
        private Button btnNewUser;
        private TextBox txtPassword;
    }
}