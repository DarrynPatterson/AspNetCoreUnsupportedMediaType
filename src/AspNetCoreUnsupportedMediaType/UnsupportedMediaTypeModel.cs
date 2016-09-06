using Newtonsoft.Json;

namespace AspNetCoreUnsupportedMediaType
{
    internal class UnsupportedMediaTypeModel
    {
        public const string UnsupportedMediaTypeMessage = "The MIME type specified in the 'Content-Type' header is not supported.";

        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        private UnsupportedMediaTypeModel(string message)
        {
            Message = message;
        }

        internal static UnsupportedMediaTypeModel Create()
        {
            return new UnsupportedMediaTypeModel(UnsupportedMediaTypeMessage);
        }
    }
}