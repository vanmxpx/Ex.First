namespace MainClient
{
    public enum LoginResult
    {
        None = -1,
        LoggedIn = 0,
        Failed = 1
    }
    public enum ConnectionType
    {
        WSHttpBinding_Message,
        WSHttpBinding_TransportWithMessage,
        WSHttpBinding_Transport
    }

}
