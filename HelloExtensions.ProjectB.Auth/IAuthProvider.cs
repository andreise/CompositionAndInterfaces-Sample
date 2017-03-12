namespace HelloExtensions.ProjectB.Auth
{
    using Interfaces;

    public interface IAuthProvider
    {
        INonRegistrationSessionCredentials AuthorizeSession();

        ISimpleUserCredentials AuthorizeSimpleUser(string login, string password);

        IUserCredentials AuthorizeUser(string login, string password);
    }
}
