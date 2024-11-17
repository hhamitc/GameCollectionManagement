
namespace GameCollectionManagement
{
    partial class GameList
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
            panel1 = new Panel();
            btnGameDelete = new Button();
            btnGameList = new Button();
            btnEditGame = new Button();
            panel2 = new Panel();
            dgvGames = new DataGridView();
            btnAdd = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnGameDelete);
            panel1.Controls.Add(btnGameList);
            panel1.Controls.Add(btnEditGame);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 27);
            panel1.TabIndex = 1;
            // 
            // btnGameDelete
            // 
            btnGameDelete.BackColor = Color.Red;
            btnGameDelete.ForeColor = SystemColors.ControlLightLight;
            btnGameDelete.Location = new Point(478, 1);
            btnGameDelete.Name = "btnGameDelete";
            btnGameDelete.Size = new Size(121, 23);
            btnGameDelete.TabIndex = 2;
            btnGameDelete.Text = "Sil";
            btnGameDelete.UseVisualStyleBackColor = false;
            btnGameDelete.Click += btnGameDelete_Click;
            // 
            // btnGameList
            // 
            btnGameList.Location = new Point(375, 1);
            btnGameList.Name = "btnGameList";
            btnGameList.Size = new Size(97, 23);
            btnGameList.TabIndex = 1;
            btnGameList.Text = "Oyunları Listele";
            btnGameList.UseVisualStyleBackColor = true;
            btnGameList.Click += btnGameList_Click;
            // 
            // btnEditGame
            // 
            btnEditGame.Anchor = AnchorStyles.Right;
            btnEditGame.Location = new Point(605, 1);
            btnEditGame.Name = "btnEditGame";
            btnEditGame.Size = new Size(94, 23);
            btnEditGame.TabIndex = 0;
            btnEditGame.Text = "Oyun Güncelle";
            btnEditGame.UseVisualStyleBackColor = true;
            btnEditGame.Click += btnEditGame_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvGames);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 412);
            panel2.TabIndex = 2;
            // 
            // dgvGames
            // 
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Dock = DockStyle.Fill;
            dgvGames.Location = new Point(0, 0);
            dgvGames.Name = "dgvGames";
            dgvGames.Size = new Size(702, 412);
            dgvGames.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(284, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // GameList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GameList";
            Size = new Size(702, 439);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnEditGame;
        private DataGridView dgvGames;
        private Button btnGameList;
        private Button btnGameDelete;
        private Button btnAdd;
    }
}
