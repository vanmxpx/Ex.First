using System;
using System.Windows.Forms;

namespace MainClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserLoginForm _login = new UserLoginForm();
            LoginPresenter _loginPresenter = new LoginPresenter(_login);
            _login.ShowDialog();

            ClientsForm _mainForm = new ClientsForm();
            ClientPresenter _mainPresenter = new ClientPresenter(_mainForm);
            Application.Run(_mainForm);
        }
    }
}
