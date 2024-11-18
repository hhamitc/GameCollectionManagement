namespace GameCollectionManagement
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            fileTsmi = new ToolStripMenuItem();
            exitTsmi = new ToolStripMenuItem();
            userTsmi = new ToolStripMenuItem();
            registerTsmi = new ToolStripMenuItem();
            userListTsmi = new ToolStripMenuItem();
            kullanıcıToolStripMenuItem = new ToolStripMenuItem();
            gameTsmi = new ToolStripMenuItem();
            newGameTsmi = new ToolStripMenuItem();
            gameListTsmi = new ToolStripMenuItem();
            reviewTsmi = new ToolStripMenuItem();
            addReviewTsmi = new ToolStripMenuItem();
            reviewListTsmi = new ToolStripMenuItem();
            aboutTsmi = new ToolStripMenuItem();
            panelContent = new Panel();
            statusStrip1 = new StatusStrip();
            tsslUserName = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            panelContent.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileTsmi, userTsmi, gameTsmi, reviewTsmi, aboutTsmi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileTsmi
            // 
            fileTsmi.DropDownItems.AddRange(new ToolStripItem[] { exitTsmi });
            fileTsmi.Name = "fileTsmi";
            fileTsmi.Size = new Size(51, 20);
            fileTsmi.Text = "Dosya";
            fileTsmi.Click += dosyaToolStripMenuItem_Click;
            // 
            // exitTsmi
            // 
            exitTsmi.Name = "exitTsmi";
            exitTsmi.Size = new Size(99, 22);
            exitTsmi.Text = "Çıkış";
            // 
            // userTsmi
            // 
            userTsmi.DropDownItems.AddRange(new ToolStripItem[] { registerTsmi, userListTsmi, kullanıcıToolStripMenuItem });
            userTsmi.Name = "userTsmi";
            userTsmi.Size = new Size(64, 20);
            userTsmi.Text = "Kullanıcı";
            // 
            // registerTsmi
            // 
            registerTsmi.Name = "registerTsmi";
            registerTsmi.Size = new Size(159, 22);
            registerTsmi.Text = "Kayıt Ol";
            registerTsmi.Click += registerTsmi_Click;
            // 
            // userListTsmi
            // 
            userListTsmi.Name = "userListTsmi";
            userListTsmi.Size = new Size(159, 22);
            userListTsmi.Text = "Tüm Kullanıcılar";
            userListTsmi.Click += userListTsmi_Click;
            // 
            // kullanıcıToolStripMenuItem
            // 
            kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            kullanıcıToolStripMenuItem.Size = new Size(159, 22);
            kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // gameTsmi
            // 
            gameTsmi.DropDownItems.AddRange(new ToolStripItem[] { newGameTsmi, gameListTsmi });
            gameTsmi.Name = "gameTsmi";
            gameTsmi.Size = new Size(48, 20);
            gameTsmi.Text = "Oyun";
            // 
            // newGameTsmi
            // 
            newGameTsmi.Name = "newGameTsmi";
            newGameTsmi.Size = new Size(143, 22);
            newGameTsmi.Text = "Oyun Ekle";
            newGameTsmi.Click += newGameTsmi_Click;
            // 
            // gameListTsmi
            // 
            gameListTsmi.Name = "gameListTsmi";
            gameListTsmi.Size = new Size(143, 22);
            gameListTsmi.Text = "Tüm Oyunlar";
            gameListTsmi.Click += gameListTsmi_Click;
            // 
            // reviewTsmi
            // 
            reviewTsmi.DropDownItems.AddRange(new ToolStripItem[] { addReviewTsmi, reviewListTsmi });
            reviewTsmi.Name = "reviewTsmi";
            reviewTsmi.Size = new Size(54, 20);
            reviewTsmi.Text = "Yorum";
            // 
            // addReviewTsmi
            // 
            addReviewTsmi.Name = "addReviewTsmi";
            addReviewTsmi.Size = new Size(180, 22);
            addReviewTsmi.Text = "Yorum Ekle";
            addReviewTsmi.Click += addReviewTsmi_Click;
            // 
            // reviewListTsmi
            // 
            reviewListTsmi.Name = "reviewListTsmi";
            reviewListTsmi.Size = new Size(180, 22);
            reviewListTsmi.Text = "Tüm Yorumlar";
            reviewListTsmi.Click += reviewListTsmi_Click;
            // 
            // aboutTsmi
            // 
            aboutTsmi.Name = "aboutTsmi";
            aboutTsmi.Size = new Size(69, 20);
            aboutTsmi.Text = "Hakkında";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(statusStrip1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 24);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(800, 426);
            panelContent.TabIndex = 1;
            panelContent.Paint += panel1_Paint;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslUserName });
            statusStrip1.Location = new Point(0, 404);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslUserName
            // 
            tsslUserName.Name = "tsslUserName";
            tsslUserName.Size = new Size(0, 17);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Oyun Koleksiyon Yönetim Sistemi";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileTsmi;
        private ToolStripMenuItem exitTsmi;
        private ToolStripMenuItem userTsmi;
        private ToolStripMenuItem registerTsmi;
        private ToolStripMenuItem userListTsmi;
        private ToolStripMenuItem gameTsmi;
        private ToolStripMenuItem newGameTsmi;
        private ToolStripMenuItem gameListTsmi;
        private ToolStripMenuItem reviewTsmi;
        private ToolStripMenuItem addReviewTsmi;
        private ToolStripMenuItem reviewListTsmi;
        private ToolStripMenuItem aboutTsmi;
        private Panel panelContent;
        private ToolStripMenuItem kullanıcıToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslUserName;
    }
}
