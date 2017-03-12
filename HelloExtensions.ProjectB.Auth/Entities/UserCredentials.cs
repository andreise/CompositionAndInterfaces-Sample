using System;

namespace HelloExtensions.ProjectB.Auth.Entities
{
    using Interfaces;

    public class UserCredentials : SimpleUserCredentials, IUserCredentials
    {
        public byte[] Token { get; set; }

        public override void LoadFromJson(string json)
        {
            // TODO: Implement loading from JSON
            throw new NotImplementedException();
        }

        public override string SaveToJson()
        {
            // TODO: Implement saving to JSON
            throw new NotImplementedException();
        }
    }
}
