using System.Linq;

namespace HelloExtensions.Auth
{
    public static class KeyValidator
    {
        private static bool IsValidKeyInternal(byte[] key)
        {
            if (key.All(item => item == byte.MinValue))
                return false;

            if (key.All(item => item == byte.MaxValue))
                return false;

            // TODO: Additional Key Validation, for ex., checking for known testings values

            return true;
        }

        public static bool IsValidKey(byte[] key) =>
            !(key is null) &&
            key.Length > 0 &&
            KeySizes.Items.Contains((KeySize)key.Length) &&
            IsValidKeyInternal(key);
    }
}
