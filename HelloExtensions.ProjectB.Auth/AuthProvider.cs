using System;
using System.Security.Cryptography;

namespace HelloExtensions.ProjectB.Auth
{
    using Entities;
    using Interfaces;

    internal sealed class AuthProvider : IAuthProvider
    {
        private static class TokenParams
        {
            public const int TokenHeaderSize = 8;
            public const int TokenBodySize = 64;
            public const int TokenSize = TokenHeaderSize + TokenBodySize;
        }

        private static void FillTokenHeader(byte[] token)
        {
            for (int i = 0; i < 2; i++)
            {
                token[i] = unchecked(
                    (byte)((uint)TokenParams.TokenBodySize >> i * 8)
                );
            }

            // TODO: Put Additional Info into the Token Header
        }

        private static void FillTokenBody(byte[] token)
        {
            byte[] tokenBody = new byte[TokenParams.TokenBodySize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(tokenBody);
            }
            Array.Copy(tokenBody, 0, token, TokenParams.TokenHeaderSize, TokenParams.TokenBodySize);
        }

        private static void StoreToken(byte[] token)
        {
            // TODO: Implement Token Storing in a Session Cache Manager
        }

        private static byte[] CreateToken()
        {
            byte[] token = new byte[TokenParams.TokenSize];
            FillTokenHeader(token);
            FillTokenBody(token);
            return token;
        }

        public INonRegistrationSessionCredentials AuthorizeSession()
        {
            var credentials = new NonRegistrationSessionCredentials() { Token = CreateToken() };

            StoreToken(credentials.Token);

            return credentials;
        }

        // TODO: Implement User Authorization
        public ISimpleUserCredentials AuthorizeSimpleUser(string login, string password)
            => new SimpleUserCredentials();

        // TODO: Implement User Authorization
        public IUserCredentials AuthorizeUser(string login, string password)
            => new UserCredentials();
    }
}
