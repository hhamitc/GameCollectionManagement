namespace GameCollectionManagement
{
    partial class AddGameForm
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
            addGame1 = new AddGame();
            SuspendLayout();
            // 
            // addGame1
            // 
            addGame1.Dock = DockStyle.Fill;
            addGame1.Location = new Point(0, 0);
            addGame1.Name = "addGame1";
            addGame1.Size = new Size(594, 357);
            addGame1.TabIndex = 0;
            addGame1.Load += addGame1_Load;
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 357);
            Controls.Add(addGame1);
            Name = "AddGameForm";
            Text = "AddGameForm";
            ResumeLayout(false);
        }

        #endregion

        private AddGame addGame1;
    }
}