using HelloExtensions.Auth;

namespace HelloExtensions
{
    static class Program
    {
        static void Main(string[] args)
        {
            var authCredentialsA = ProjectA.Auth.AuthProviderFactory.Default
                .AuthorizeUser("user", "password");
            bool authCredentialsAIsValid = authCredentialsA.IsValid();

            var authCredentialsAEx = ProjectA.Auth.AuthProviderFactory.Default
                .AuthorizeUserEx("user", "password");
            bool authCredentialsAExIsValid = authCredentialsAEx.IsValid();

            var authCredentialsBSimple = ProjectB.Auth.AuthProviderFactory.Default
                .AuthorizeSimpleUser("user", "password");
            bool authCredentialsBSimpleIsValid = authCredentialsBSimple.IsValid();

            var authCredentialsB = ProjectB.Auth.AuthProviderFactory.Default
                .AuthorizeUser("user", "password");
            bool authCredentialsBIsValid = authCredentialsB.IsValid();

            var sessionCredentials = ProjectB.Auth.AuthProviderFactory.Default
                .AuthorizeSession();
            bool sessionCredentialsIsValid = sessionCredentials.IsValid();
        }
    }
}
