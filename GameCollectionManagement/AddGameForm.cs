namespace GameCollectionManagement
{
    public partial class AddGameForm : Form
    {
        private GameList _gameList;
        public AddGameForm(GameList gameList)
        {
            InitializeComponent();
            _gameList = gameList;
        }

        private void addGame1_Load(object sender, EventArgs e)
        {

        }

        private void AddGameForm_Load(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame(_gameList);
            panelContainer.Controls.Add(addGame);
        }
    }
}
