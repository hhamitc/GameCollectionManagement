namespace GameCollectionManagement
{
    partial class EditReview
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
            btnEdit = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtReview = new TextBox();
            nudRating = new NumericUpDown();
            cbGames = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(197, 219);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 23);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 12;
            label3.Text = "Yorum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 11;
            label2.Text = "Rating";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 10;
            label1.Text = "Oyun";
            // 
            // txtReview
            // 
            txtReview.Location = new Point(84, 115);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(230, 98);
            txtReview.TabIndex = 9;
            // 
            // nudRating
            // 
            nudRating.Location = new Point(84, 63);
            nudRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(230, 23);
            nudRating.TabIndex = 8;
            nudRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbGames
            // 
            cbGames.FormattingEnabled = true;
            cbGames.Location = new Point(84, 19);
            cbGames.Name = "cbGames";
            cbGames.Size = new Size(230, 23);
            cbGames.TabIndex = 7;
            // 
            // EditReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 264);
            Controls.Add(btnEdit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtReview);
            Controls.Add(nudRating);
            Controls.Add(cbGames);
            Name = "EditReview";
            Text = "EditReview";
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtReview;
        private NumericUpDown nudRating;
        private ComboBox cbGames;
    }
}