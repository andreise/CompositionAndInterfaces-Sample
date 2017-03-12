using HelloExtensions.Auth.Interfaces;

namespace HelloExtensions.ProjectB.Auth.Interfaces
{
    public interface ISimpleUserCredentials : ICredentialUser, IJsonSupport
    {
    }
}
