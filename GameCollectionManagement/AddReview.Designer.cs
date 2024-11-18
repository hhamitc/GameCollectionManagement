namespace GameCollectionManagement
{
    partial class AddReview
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
            cbGames = new ComboBox();
            nudRating = new NumericUpDown();
            txtReview = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // cbGames
            // 
            cbGames.FormattingEnabled = true;
            cbGames.Location = new Point(85, 24);
            cbGames.Name = "cbGames";
            cbGames.Size = new Size(230, 23);
            cbGames.TabIndex = 0;
            // 
            // nudRating
            // 
            nudRating.Location = new Point(85, 68);
            nudRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(230, 23);
            nudRating.TabIndex = 1;
            nudRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtReview
            // 
            txtReview.Location = new Point(85, 120);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(230, 98);
            txtReview.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 27);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Oyun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 70);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Rating";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 123);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Yorum";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(198, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtReview);
            Controls.Add(nudRating);
            Controls.Add(cbGames);
            Name = "AddReview";
            Size = new Size(342, 266);
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbGames;
        private NumericUpDown nudRating;
        private TextBox txtReview;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
    }
}
