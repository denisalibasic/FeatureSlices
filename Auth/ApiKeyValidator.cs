namespace FeatureSlices.Auth
{
    public class ApiKeyValidator : IApiKeyValidator
    {
        private readonly string _validApiKey;

        public ApiKeyValidator(string validApiKey)
        {
            _validApiKey = validApiKey;
        }

        public bool IsValid(string apiKey)
        {
            return apiKey == _validApiKey;
        }
    }
}
