using GameCollectionManagement.Services;

namespace GameCollectionManagement
{
    public partial class GameList : UserControl
    {
        private readonly IGameService _gameService;
        public GameList()
        {
            InitializeComponent();

            _gameService = new GameService();
        }

        public void LoadGames()
        {
            var games = _gameService.GetAll();

            dgvGames.DataSource = games;
            dgvGames.Columns["Id"].Visible = false;
        }



        private void btnGameList_Click(object sender, EventArgs e)
        {
            LoadGames();
        }

        private void btnGameDelete_Click(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                int id = (int)dgvGames.SelectedRows[0].Cells["Id"].Value;
                string name = dgvGames.SelectedRows[0].Cells["Name"].Value.ToString();

                if (MessageBox.Show($"{name} adlı oyunu silmek istediğinizden emin misiniz?", "Silme Onayı",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _gameService.Delete(id);
                        LoadGames();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Oyun Seçmelisiniz.");
            }
        }


        private void btnEditGame_Click(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                int id = (int)dgvGames.SelectedRows[0].Cells["Id"].Value;

                EditGame editGame = new EditGame(id, this);

                editGame.ShowDialog();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm(this);
            addGameForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = string.Empty;

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                searchTerm = txtSearch.Text;
            }

            if (cbPlatform.SelectedItem != null)
            {
                searchTerm = cbPlatform.SelectedItem.ToString();
            }

            if (cbGenre.SelectedItem != null)
            {
                searchTerm = cbGenre.SelectedItem.ToString();
            }

            var games = _gameService.Search(searchTerm);

            dgvGames.DataSource = games;
        }

        public void LoadGenres()
        {
            var genres = _gameService.GetGenres();
            cbGenre.Items.Clear();
            cbGenre.Items.AddRange(genres.ToArray());
        }

        private void GameList_Load(object sender, EventArgs e)
        {
            //var genres = _gameService.GetGenres();
            //cbGenre.Items.AddRange(genres.ToArray());

            LoadGenres();

        }
    }
}
