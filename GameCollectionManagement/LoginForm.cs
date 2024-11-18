using GameCollectionManagement.Models;
using GameCollectionManagement.Services;

namespace GameCollectionManagement
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        public bool IsAuthenticated { get; private set; }
        public User User { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre gerekli.");
            }
            else
            {
                var result = _userService.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                if (result.isAuthenticated)
                {
                    User user = _userService.GetById(result.userId.Value);

                    User = user;

                    IsAuthenticated = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre.");
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();
            form.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
