using System;

namespace HelloExtensions.Auth.Interfaces
{
    public interface ICredentialUser : IAuthCredentials
    {
        Guid? UserId { get; }
    }
}
