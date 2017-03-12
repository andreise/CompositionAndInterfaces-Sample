namespace HelloExtensions.ProjectA.Auth.Interfaces
{
    public interface IXmlSupport
    {
        void LoadFromXml(string xml);

        string SaveToXml();
    }
}
