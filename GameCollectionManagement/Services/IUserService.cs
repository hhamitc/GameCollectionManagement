using GameCollectionManagement.Models;

namespace GameCollectionManagement.Services
{
    public interface IUserService
    {

        List<User> GetAll();
        User GetById(int id);
        void Update(User user);
        void Delete(int id);
        void Add(User user);
        bool Login(string userName, string password);

    }
}
