namespace GameCollectionManagement
{
    partial class EditUser
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtRole = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 218);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 16;
            label4.Text = "Rol:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 159);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 15;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 98);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 14;
            label2.Text = "E-Mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 37);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 13;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(143, 215);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(315, 23);
            txtRole.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 23);
            txtPassword.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(315, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(143, 34);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(315, 23);
            txtUserName.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(377, 278);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(81, 27);
            btnSave.TabIndex = 17;
            btnSave.Text = "Güncelle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 352);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRole);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Name = "EditUser";
            Text = "EditUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtRole;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private Button btnSave;
    }
}