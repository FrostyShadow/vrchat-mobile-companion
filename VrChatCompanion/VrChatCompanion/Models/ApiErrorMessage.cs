using Newtonsoft.Json;

namespace VrChatCompanion.Models
{
    public class ApiErrorMessage
    {
        public Error Error { get; set; }
    }

    public class Error
    {
        private string _message;

        public string Message
        {
            get => _message;
            set => _message = value.Replace("\"", string.Empty);
        }
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }
    }
}