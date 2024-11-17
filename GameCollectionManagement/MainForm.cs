namespace GameCollectionManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kayıtOlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddControl(UserControl control)
        {
            panelContent.Controls.Clear();

            panelContent.Controls.Add(control);
        }

        private void newGameTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new AddGame());
        }

        private void gameListTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new GameList());
        }
    }
}
