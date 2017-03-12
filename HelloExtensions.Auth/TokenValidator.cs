namespace HelloExtensions.Auth
{
    public static class TokenValidator
    {
        private static class TokenParams
        {
            public const int TokenHeaderSize = 8;
            public const int MinTokenSize = TokenHeaderSize + 32;
            public const int MaxTokenSize = TokenHeaderSize + 256;
        }

        private static int GetTokenBodySize(byte[] token)
        {
            int bodySize = 0;

            for (int i = 0; i < 2; i++)
                bodySize |= token[i] << i * 8;

            return bodySize;
        }

        private static bool IsValidTokenInternal(byte[] token)
        {
            if (GetTokenBodySize(token) != token.Length - TokenParams.TokenHeaderSize)
                return false;

            // TODO: Additional Token Validation,
            // for ex., searching token in a Session Cache Manager

            return true;
        }

        public static bool IsValidToken(byte[] token) =>
            token != null &&
            token.Length >= TokenParams.MinTokenSize &&
            token.Length <= TokenParams.MaxTokenSize &&
            IsValidTokenInternal(token);
    }
}
