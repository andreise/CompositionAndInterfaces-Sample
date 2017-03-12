using System;
using HelloExtensions.Auth.Interfaces;

namespace HelloExtensions.ProjectA.Auth.Entities
{
    using Interfaces;

    public class UserCredentials : IUserCredentials
    {
        public Guid? UserId { get; set; }

        public byte[] SessionToken { get; set; }

        byte[] ICredentialToken.Token => this.SessionToken;

        public virtual void LoadFromXml(string xml)
        {
            // TODO: Implement loading from XML
            throw new NotImplementedException();
        }

        public virtual string SaveToXml()
        {
            // TODO: Implement saving to XML
            throw new NotImplementedException();
        }
    }
}
