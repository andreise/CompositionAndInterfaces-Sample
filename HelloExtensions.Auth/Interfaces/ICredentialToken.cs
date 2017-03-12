namespace HelloExtensions.Auth.Interfaces
{
    public interface ICredentialToken : IAuthCredentials
    {
        byte[] Token { get; }
    }
}
