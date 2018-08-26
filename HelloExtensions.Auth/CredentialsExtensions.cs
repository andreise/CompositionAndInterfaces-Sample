using System;

namespace HelloExtensions.Auth
{
    using Interfaces;

    public static class CredentialsExtensions
    {
        private static bool IsValid(this ICredentialUser user) =>
            IdentifierValidator.IsValidIdentifier(user.UserId);

        private static bool IsValid(this ICredentialToken token) =>
            TokenValidator.IsValidToken(token.Token);

        private static bool IsValid(this ICredentialInfo info) =>
            ((ICredentialUser)info).IsValid() &&
            ((ICredentialToken)info).IsValid();

        private static bool IsValid(this ICredentialInfoEx info) =>
            ((ICredentialInfo)info).IsValid() &&
            KeyValidator.IsValidKey(info.EncryptionKey);

        public static bool IsValid(this IAuthCredentials credentials)
        {
            switch (credentials)
            {
                case ICredentialInfoEx credentialInfoEx:
                    return credentialInfoEx.IsValid();

                case ICredentialInfo credentialInfo:
                    return credentialInfo.IsValid();

                case ICredentialUser credentialUser:
                    return credentialUser.IsValid();

                case ICredentialToken credentialToken:
                    return credentialToken.IsValid();

                case null:
                    //throw new ArgumentNullException(nameof(credentials));
                    return false;

                default:
                    //throw new ArgumentException(
                    //    FormattableString.Invariant(
                    //        $"Specified {nameof(IAuthCredentials)} implementation not supported."
                    //    ),
                    //    nameof(credentials)
                    //);
                    return false;
            }
        }
    }
}
