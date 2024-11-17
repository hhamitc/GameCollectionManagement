namespace GameCollectionManagement
{
    partial class EditGame
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
            btnOpenFileDialog = new Button();
            numericGamePlayTime = new NumericUpDown();
            dtpGameReleaseDate = new DateTimePicker();
            cbGamePlatform = new ComboBox();
            txtGameGenre = new TextBox();
            txtGameName = new TextBox();
            ofdCoverImage = new OpenFileDialog();
            txtGameCoverImage = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).BeginInit();
            SuspendLayout();
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(481, 218);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(75, 23);
            btnOpenFileDialog.TabIndex = 21;
            btnOpenFileDialog.Text = "...";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click_1;
            // 
            // numericGamePlayTime
            // 
            numericGamePlayTime.Location = new Point(164, 175);
            numericGamePlayTime.Name = "numericGamePlayTime";
            numericGamePlayTime.Size = new Size(392, 23);
            numericGamePlayTime.TabIndex = 20;
            // 
            // dtpGameReleaseDate
            // 
            dtpGameReleaseDate.Location = new Point(164, 132);
            dtpGameReleaseDate.Name = "dtpGameReleaseDate";
            dtpGameReleaseDate.Size = new Size(392, 23);
            dtpGameReleaseDate.TabIndex = 19;
            // 
            // cbGamePlatform
            // 
            cbGamePlatform.FormattingEnabled = true;
            cbGamePlatform.Items.AddRange(new object[] { "PC", "XBox", "Play Station", "Nintendo" });
            cbGamePlatform.Location = new Point(164, 90);
            cbGamePlatform.Name = "cbGamePlatform";
            cbGamePlatform.Size = new Size(392, 23);
            cbGamePlatform.TabIndex = 18;
            // 
            // txtGameGenre
            // 
            txtGameGenre.Location = new Point(164, 47);
            txtGameGenre.Name = "txtGameGenre";
            txtGameGenre.Size = new Size(392, 23);
            txtGameGenre.TabIndex = 17;
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(164, 6);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(392, 23);
            txtGameName.TabIndex = 16;
            // 
            // ofdCoverImage
            // 
            ofdCoverImage.FileName = "ofdCoverImage";
            // 
            // txtGameCoverImage
            // 
            txtGameCoverImage.Location = new Point(164, 219);
            txtGameCoverImage.Name = "txtGameCoverImage";
            txtGameCoverImage.Size = new Size(307, 23);
            txtGameCoverImage.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 222);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 27;
            label6.Text = "Kapak Resmi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 177);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 26;
            label5.Text = "Oynanış Süresi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 25;
            label4.Text = "Çıkış Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 24;
            label3.Text = "Oyun Platformu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 23;
            label2.Text = "Oyun Türü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 22;
            label1.Text = "Oyun Adı";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(481, 273);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // EditGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 333);
            Controls.Add(btnEdit);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(numericGamePlayTime);
            Controls.Add(dtpGameReleaseDate);
            Controls.Add(cbGamePlatform);
            Controls.Add(txtGameGenre);
            Controls.Add(txtGameName);
            Controls.Add(txtGameCoverImage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditGame";
            Text = "Oyun Güncelle";
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFileDialog;
        private NumericUpDown numericGamePlayTime;
        private DateTimePicker dtpGameReleaseDate;
        private ComboBox cbGamePlatform;
        private TextBox txtGameGenre;
        private TextBox txtGameName;
        private OpenFileDialog ofdCoverImage;
        private TextBox txtGameCoverImage;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEdit;
    }
}