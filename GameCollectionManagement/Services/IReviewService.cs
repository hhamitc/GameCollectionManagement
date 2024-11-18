using GameCollectionManagement.Models;

namespace GameCollectionManagement.Services
{
    public interface IReviewService
    {
        List<Review> GetAll();
        Review GetById(int id);
        void Update(Review review);
        void Delete(int id);
        void Add(Review review);
        List<Review> GetAllWithDetails();
        Review GetByIdWithDetails(int id);
        List<Review> GetAllByRole(string role, int userId);
        void DeleteByRole(int reviewId, string role, int userId);

    }
}
