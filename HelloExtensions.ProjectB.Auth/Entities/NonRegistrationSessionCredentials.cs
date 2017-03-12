using System;

namespace HelloExtensions.ProjectB.Auth
{
    using Interfaces;

    public class NonRegistrationSessionCredentials : INonRegistrationSessionCredentials
    {
        public byte[] Token { get; set; }

        public virtual void LoadFromJson(string json)
        {
            // TODO: Implement loading from JSON
            throw new NotImplementedException();
        }

        public virtual string SaveToJson()
        {
            // TODO: Implement saving to JSON
            throw new NotImplementedException();
        }
    }
}
