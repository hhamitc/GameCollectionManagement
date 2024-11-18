﻿using GameCollectionManagement.Models;
using GameCollectionManagement.Services;

namespace GameCollectionManagement
{
    public partial class EditReview : Form
    {
        private readonly IReviewService _reviewService;
        private readonly IGameService _gameService;

        private readonly ReviewList _reviewList;

        private Review _review;

        public EditReview(int id, ReviewList reviewList)
        {
            InitializeComponent();

            _reviewService = new ReviewService();
            _gameService = new GameService();

            cbGames.DataSource = _gameService.GetAll();
            cbGames.DisplayMember = nameof(Game.Name);
            cbGames.ValueMember = nameof(Game.Id);

            _review = _reviewService.GetById(id);

            txtReview.Text = _review.ReviewText;
            nudRating.Value = _review.Rating;
            cbGames.SelectedValue = _review.GameId;
            _reviewList = reviewList;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (ValidateInput())
            {
                try
                {
                    Game selectedGame = cbGames.SelectedItem as Game;

                    if (selectedGame == null)
                    {
                        MessageBox.Show("Sistemsel bir hata oluştu");
                    }

                    _review.ReviewText = txtReview.Text.Trim();
                    _review.Rating = (int)nudRating.Value;
                    _review.GameId = selectedGame.Id;

                    _reviewService.Update(_review);

                    MessageBox.Show("Yorumunuz güncellendi");

                    _reviewList.LoadReviews();

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
            if (cbGames.SelectedItem == null)
            {
                MessageBox.Show("Oyun seçmelisiniz");
                return false;
            }

            if (nudRating.Value < 1 || nudRating.Value > 5)
            {
                MessageBox.Show("Rating aralığı 1-5 arasıdır");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtReview.Text))
            {
                MessageBox.Show("Yorum girmelisiniz");
                return false;
            }

            return true;
        }
    }
}
