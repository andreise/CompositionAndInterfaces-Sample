using System;

namespace HelloExtensions.ProjectB.Auth
{
    public static class AuthProviderFactory
    {
        private static readonly Lazy<IAuthProvider> defaultInstance;

        static AuthProviderFactory()
        {
            defaultInstance = new Lazy<IAuthProvider>(Create);
        }

        public static IAuthProvider Create() => new AuthProvider();

        public static IAuthProvider Default => defaultInstance.Value;
    }
}
