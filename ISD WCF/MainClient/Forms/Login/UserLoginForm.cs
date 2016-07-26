using System;
using System.Windows.Forms;

namespace MainClient
{
    public partial class UserLoginForm : Form, ILoginForm
    {
        #region Variables
        private LoginResult loginResult = LoginResult.None;
        public ConnectionType Connection
        {
            get
            {
                return (ConnectionType) comboBoxConnectionTypes.SelectedItem;
            }
        }
        public String Login
        {
            get
            {
                return textBoxLogin.Text;
            }
            set
            {
                textBoxLogin.Text = value;
            }
        }

        public String Password
        {
            get
            {
                return textBoxPass.Text;
            }
            set
            {
                textBoxPass.Text = value;
            }
        }
        public String CostumeIp
        {
            get
            {
                return textBoxHostIp.Text;
            }
        }

        public event EventHandler ButtLoginClicked;
        #endregion

        public UserLoginForm()
        {
            InitializeComponent();
            comboBoxConnectionTypes.DataSource = Enum.GetValues(typeof(ConnectionType));
            textBoxHostIp.Text = ServiceClient.RemoteAddress;
        }

        public void CloseLogin(LoginResult result)
        {
            loginResult = result;
            Close();
        }

        #region Forms' events
        private void butSingIn_Click(object sender, EventArgs e)
        {
            ButtLoginClicked?.Invoke(this, null);
        }
        private void UserLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loginResult != LoginResult.LoggedIn)
                System.Environment.Exit(0);
        }
        private void LoginKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                ButtLoginClicked?.Invoke(this, null);
            else if(e.KeyCode == Keys.Escape)
                System.Environment.Exit(0);
        }
        #endregion
    }
}
