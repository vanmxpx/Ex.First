using System;
using System.ServiceModel;

namespace MainClient
{
    public class LoginPresenter
    {
        private ILoginForm _loginForm;
        public LoginPresenter(ILoginForm _loginForm)
        {
            this._loginForm = _loginForm;
            _loginForm.ButtLoginClicked += Login;
        }

        #region Application's logic
        private void Login (object sender, EventArgs e)
        {
            try
            {
                ServiceClient.RemoteAddress = _loginForm.CostumeIp;
                ServiceClient.Connection = _loginForm.Connection;
                ServiceClient.GetServiceClient.ClientCredentials.UserName.UserName = _loginForm.Login;
                ServiceClient.GetServiceClient.ClientCredentials.UserName.Password = _loginForm.Password;
                ServiceClient.GetServiceClient.IsConnected();
                MessageService.ShowMassage("Login succsess.");
                _loginForm.CloseLogin(LoginResult.LoggedIn);
            }
            catch (Exception _ex)
            {
                MessageService.ShowError(_ex.Message);
            }
        }
        #endregion
    }
}
