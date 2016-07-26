using System;

namespace MainClient
{
    public interface ILoginForm
    {
        ConnectionType Connection { get; }
        String Login { get; }
        String Password { get; }
        String CostumeIp { get; }
        void CloseLogin(LoginResult result);
        event EventHandler ButtLoginClicked;
    }
}
