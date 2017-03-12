using System;

namespace HelloExtensions.ProjectB.Auth.Entities
{
    using Interfaces;

    public class SimpleUserCredentials : ISimpleUserCredentials
    {
        public Guid? UserId { get; set; }

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
