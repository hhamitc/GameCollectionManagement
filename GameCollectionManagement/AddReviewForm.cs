using GameCollectionManagement.Models;
using GameCollectionManagement.Services;

namespace GameCollectionManagement
{
    public partial class AddReviewForm : Form
    {
        private readonly IReviewService _reviewService;
        private readonly User _user;
        private readonly ReviewList _reviewList;
        public AddReviewForm(User user, ReviewList reviewList)
        {
            InitializeComponent();
            _user = user;
            _reviewService = new ReviewService();
            _reviewList = reviewList;
        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {
            AddReview review = new AddReview(_user, _reviewList);
            panelContainer.Controls.Add(review);
        }
    }
}
