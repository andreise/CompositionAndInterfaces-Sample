using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HelloExtensions.Auth
{
    public static class KeySizes
    {
        public static IReadOnlyList<KeySize> Items { get; }

        static KeySizes()
        {
            Items = new ReadOnlyCollection<KeySize>(
                (KeySize[])Enum.GetValues(typeof(KeySize))
            );
        }
    }
}
