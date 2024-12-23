﻿namespace GameCollectionManagement
{
    partial class AddGame
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
            txtGameName = new TextBox();
            txtGameGenre = new TextBox();
            cbGamePlatform = new ComboBox();
            dtpGameReleaseDate = new DateTimePicker();
            numericGamePlayTime = new NumericUpDown();
            btnOpenFileDialog = new Button();
            ofdCoverImage = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnGameSave = new Button();
            txtGameCoverImage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).BeginInit();
            SuspendLayout();
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(173, 26);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(392, 23);
            txtGameName.TabIndex = 0;
            // 
            // txtGameGenre
            // 
            txtGameGenre.Location = new Point(173, 67);
            txtGameGenre.Name = "txtGameGenre";
            txtGameGenre.Size = new Size(392, 23);
            txtGameGenre.TabIndex = 1;
            // 
            // cbGamePlatform
            // 
            cbGamePlatform.FormattingEnabled = true;
            cbGamePlatform.Items.AddRange(new object[] { "PC", "XBox", "Play Station", "Nintendo" });
            cbGamePlatform.Location = new Point(173, 110);
            cbGamePlatform.Name = "cbGamePlatform";
            cbGamePlatform.Size = new Size(392, 23);
            cbGamePlatform.TabIndex = 2;
            // 
            // dtpGameReleaseDate
            // 
            dtpGameReleaseDate.Location = new Point(173, 152);
            dtpGameReleaseDate.Name = "dtpGameReleaseDate";
            dtpGameReleaseDate.Size = new Size(392, 23);
            dtpGameReleaseDate.TabIndex = 3;
            // 
            // numericGamePlayTime
            // 
            numericGamePlayTime.Location = new Point(173, 195);
            numericGamePlayTime.Name = "numericGamePlayTime";
            numericGamePlayTime.Size = new Size(392, 23);
            numericGamePlayTime.TabIndex = 4;
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(490, 238);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(75, 23);
            btnOpenFileDialog.TabIndex = 6;
            btnOpenFileDialog.Text = "...";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // ofdCoverImage
            // 
            ofdCoverImage.FileName = "ofdCoverImage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 7;
            label1.Text = "Oyun Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 70);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 8;
            label2.Text = "Oyun Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 113);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 9;
            label3.Text = "Oyun Platformu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 158);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 10;
            label4.Text = "Çıkış Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 197);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 11;
            label5.Text = "Oynanış Süresi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 242);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 12;
            label6.Text = "Kapak Resmi";
            // 
            // btnGameSave
            // 
            btnGameSave.Location = new Point(490, 296);
            btnGameSave.Name = "btnGameSave";
            btnGameSave.Size = new Size(75, 23);
            btnGameSave.TabIndex = 13;
            btnGameSave.Text = "Oyun Ekle";
            btnGameSave.UseVisualStyleBackColor = true;
            btnGameSave.Click += btnGameSave_Click;
            // 
            // txtGameCoverImage
            // 
            txtGameCoverImage.Location = new Point(173, 239);
            txtGameCoverImage.Name = "txtGameCoverImage";
            txtGameCoverImage.Size = new Size(307, 23);
            txtGameCoverImage.TabIndex = 15;
            // 
            // AddGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtGameCoverImage);
            Controls.Add(btnGameSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(numericGamePlayTime);
            Controls.Add(dtpGameReleaseDate);
            Controls.Add(cbGamePlatform);
            Controls.Add(txtGameGenre);
            Controls.Add(txtGameName);
            Name = "AddGame";
            Size = new Size(593, 347);
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGameName;
        private TextBox txtGameGenre;
        private ComboBox cbGamePlatform;
        private DateTimePicker dtpGameReleaseDate;
        private NumericUpDown numericGamePlayTime;
        private Button btnOpenFileDialog;
        private OpenFileDialog ofdCoverImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnGameSave;
        private TextBox txtGameCoverImage;
    }
}
