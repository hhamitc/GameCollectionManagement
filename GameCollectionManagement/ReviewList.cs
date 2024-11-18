using GameCollectionManagement.Models;
using GameCollectionManagement.Services;

namespace GameCollectionManagement
{
    public partial class ReviewList : UserControl
    {
        private readonly User _user;

        private readonly IReviewService _reviewService;
        public ReviewList(User user)
        {
            InitializeComponent();
            _user = user;
            _reviewService = new ReviewService();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {


            dgvReviews.DataSource = _reviewService.GetAllByRole(_user.Role, _user.Id);
        }
    }
}
