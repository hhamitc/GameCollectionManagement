using GameCollectionManagement.Models;
using GameCollectionManagement.Services;

namespace GameCollectionManagement
{
    public partial class AddUser : UserControl
    {
        private IUserService _userService;

        private UserList _userList;

        private bool _fromLoginPage = false;

        public AddUser(bool fromLoginPage = false)
        {
            InitializeComponent();
            _userService = new UserService();
            _fromLoginPage = fromLoginPage;
        }

        public AddUser(UserList userList)
        {
            InitializeComponent();
            _userService = new UserService();
            _userList = userList;
        }
        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                User user = new User();
                user.UserName = txtUserName.Text.Trim();
                user.Email = txtEmail.Text.Trim();
                user.Password = txtPassword.Text.Trim();
                user.Role = txtRole.Text.Trim();

                try
                {
                    _userService.Add(user);
                    MessageBox.Show("Kullanıcı oluşturuldu");

                    if (_userList != null)
                    {
                        _userList.LoadUsers();
                        ((Form)Parent.Parent).Close();
                    }

                    if (_fromLoginPage)
                    {
                        ((Form)Parent.Parent).Close();
                    }

                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtRole.Clear();

        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Kullanıcı adı giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Şifre giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Rol giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


    }
}
