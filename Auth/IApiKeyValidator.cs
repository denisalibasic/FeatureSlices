namespace FeatureSlices.Auth
{
    public interface IApiKeyValidator
    {
        bool IsValid(string apiKey);
    }
}
