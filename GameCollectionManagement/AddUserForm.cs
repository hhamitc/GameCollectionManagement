namespace GameCollectionManagement
{
    public partial class AddUserForm : Form
    {
        private UserList _userList = null;
        public AddUserForm(UserList userList)
        {
            InitializeComponent();
            _userList = userList;
        }

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            AddUser addUser = null;

            if (_userList != null)
                addUser = new AddUser(_userList);
            else
                addUser = new AddUser(fromLoginPage: true);

            panelContainer.Controls.Add(addUser);
        }
    }
}
