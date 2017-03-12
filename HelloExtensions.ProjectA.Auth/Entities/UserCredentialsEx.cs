using System;

namespace HelloExtensions.ProjectA.Auth.Entities
{
    using Interfaces;

    public class UserCredentialsEx : UserCredentials, IUserCredentialsEx
    {
        public byte[] EncryptionKey { get; set; }

        public override void LoadFromXml(string xml)
        {
            // TODO: Implement loading from XML
            throw new NotImplementedException();
        }

        public override string SaveToXml()
        {
            // TODO: Implement saving to XML
            throw new NotImplementedException();
        }
    }
}
