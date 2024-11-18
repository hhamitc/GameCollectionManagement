namespace GameCollectionManagement
{
    partial class UserList
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
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            panelContainer = new Panel();
            dgvUsers = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnLoad);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 93);
            panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(515, 60);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(78, 27);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(431, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 27);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(345, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 27);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(224, 60);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(115, 27);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Kullanıcıları Listele";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(dgvUsers);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 93);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(611, 310);
            panelContainer.TabIndex = 1;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(611, 310);
            dgvUsers.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(31, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(150, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(443, 23);
            txtSearch.TabIndex = 5;
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Name = "UserList";
            Size = new Size(611, 403);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelContainer;
        private DataGridView dgvUsers;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}
