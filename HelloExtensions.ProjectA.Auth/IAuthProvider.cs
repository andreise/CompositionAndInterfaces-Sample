namespace HelloExtensions.ProjectA.Auth
{
    using Interfaces;

    public interface IAuthProvider
    {
        IUserCredentials AuthorizeUser(string login, string password);

        IUserCredentialsEx AuthorizeUserEx(string login, string password);
    }
}
