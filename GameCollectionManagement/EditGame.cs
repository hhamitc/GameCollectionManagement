using GameCollectionManagement.Models;
using GameCollectionManagement.Services;

namespace GameCollectionManagement
{
    public partial class EditGame : Form
    {
        private readonly IGameService _gameService;

        private Game _game;

        private GameList _gameList;

        public EditGame(int Id, GameList gameList)
        {
            InitializeComponent();
            _gameService = new GameService();

            _game = _gameService.GetById(Id);

            txtGameName.Text = _game.Name;
            txtGameGenre.Text = _game.Genre;
            cbGamePlatform.SelectedItem = _game.Platform;
            numericGamePlayTime.Value = (decimal)_game.PlayTime;
            dtpGameReleaseDate.Value = _game.ReleaseDate ?? DateTime.Now;

            _gameList = gameList;
        }

        private void addGame1_Load(object sender, EventArgs e)
        {

        }

        private byte[] _selectedCoverImage = null;

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (ValidateInput())
            {
                _game.Name = txtGameName.Text.Trim();
                _game.Genre = txtGameGenre.Text.Trim();
                _game.Platform = cbGamePlatform.SelectedItem?.ToString();
                _game.ReleaseDate = dtpGameReleaseDate.Value;
                _game.PlayTime = (int)numericGamePlayTime.Value;
                _game.CoverImage = _selectedCoverImage;
                try
                {
                    _gameService.Update(_game);

                    MessageBox.Show("Oyun Güncellendi.");

                    _gameList.LoadGames();

                    Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtGameName.Text))
            {
                MessageBox.Show("Oyun adı giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGameGenre.Text))
            {
                MessageBox.Show("Tür adı giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbGamePlatform.SelectedItem is null)
            {
                MessageBox.Show("Platform seçiniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            if (ofdCoverImage.ShowDialog() == DialogResult.OK)
            {
                string imagePath = ofdCoverImage.FileName;
                _selectedCoverImage = File.ReadAllBytes(imagePath);
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        private void btnOpenFileDialog_Click_1(object sender, EventArgs e)
        {
            if (ofdCoverImage.ShowDialog() == DialogResult.OK)
            {
                string imagePath = ofdCoverImage.FileName;
                _selectedCoverImage = File.ReadAllBytes(imagePath);
            }
        }


    }
}