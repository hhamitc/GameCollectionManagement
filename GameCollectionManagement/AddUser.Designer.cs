﻿namespace GameCollectionManagement
{
    partial class AddUser
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
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddUser = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(143, 55);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(315, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(315, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(143, 236);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(315, 23);
            txtRole.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 58);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 119);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 180);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 239);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 7;
            label4.Text = "Rol:";
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(383, 313);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(75, 23);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Ekle";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRole);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Name = "AddUser";
            Size = new Size(514, 377);
            Load += AddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtRole;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddUser;
    }
}
