namespace HelloExtensions.ProjectA.Auth
{
    using Entities;
    using Interfaces;

    internal sealed class AuthProvider : IAuthProvider
    {
        // TODO: Implement User Authorization
        public IUserCredentials AuthorizeUser(string login, string password)
            => new UserCredentials();

        // TODO: Implement User Authorization
        public IUserCredentialsEx AuthorizeUserEx(string login, string password)
            => new UserCredentialsEx();
    }
}
