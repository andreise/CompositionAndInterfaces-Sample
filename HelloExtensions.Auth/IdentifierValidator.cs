using System;

namespace HelloExtensions.Auth
{
    public static class IdentifierValidator
    {
        // TODO: check id exists in database
        private static bool IsIdentidierExists(Guid id) => true;

        public static bool IsValidIdentifier(Guid id) =>
            id != Guid.Empty && IsIdentidierExists(id);

        public static bool IsValidIdentifier(Guid? id) =>
            !(id is null) && IsValidIdentifier(id.Value);
    }
}
