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
            if (credentials is null)
            {
                //throw new ArgumentNullException(nameof(credentials));
                return false;
            }

            {
                var credentialInfoEx = credentials as ICredentialInfoEx;
                if (!(credentialInfoEx is null))
                    return credentialInfoEx.IsValid();
            }

            {
                var credentialInfo = credentials as ICredentialInfo;
                if (!(credentialInfo is null))
                    return credentialInfo.IsValid();
            }

            {
                var credentialUser = credentials as ICredentialUser;
                if (!(credentialUser is null))
                    return credentialUser.IsValid();
            }

            {
                var credentialToken = credentials as ICredentialToken;
                if (!(credentialToken is null))
                    return credentialToken.IsValid();
            }

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
