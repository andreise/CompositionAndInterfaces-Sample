namespace HelloExtensions.ProjectB.Auth.Interfaces
{
    public interface IJsonSupport
    {
        void LoadFromJson(string json);

        string SaveToJson();
    }
}
