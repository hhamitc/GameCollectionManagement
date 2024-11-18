using GameCollectionManagement.Models;
using GameCollectionManagement.Repositories;

namespace GameCollectionManagement.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public void Add(User user)
        {
            if (string.IsNullOrWhiteSpace(user.UserName))
            {
                throw new ArgumentException("Kullanıcı adı boş olamaz");
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {
                throw new ArgumentException("E-posta adresi boş olamaz");
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("Şifre boş olamaz");
            }

            _userRepository.Add(user);
        }

        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Geçersiz kullanıcı id");
            }

            var user = GetById(id);

            if (user != null)
            {
                _userRepository.Delete(user);
            }
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public (bool isAuthenticated, int? userId) Login(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Kullanıcı adı veya şifre boş olamaz");
            }

            return _userRepository.Login(userName, password);
        }

        public void Update(User user)
        {
            if (user.Id <= 0)
            {
                throw new ArgumentException("Geçersiz kullanıcı id");
            }

            var currentUser = GetById(user.Id);

            if (currentUser != null)
            {
                //currentUser.Email = user.Email;
                //currentUser.Password = user.Password;
                //currentUser.UserName = user.UserName;
                //currentUser.Role = user.Role;
                _userRepository.Update(user);
            }
        }

        public List<User> Search(string searchTerm)
        {
            return GetAll().Where(u => u.UserName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) || u.Email.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
        }

    }
}
