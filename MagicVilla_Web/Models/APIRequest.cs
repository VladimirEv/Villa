namespace MagicVilla_Web.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = APIType.GET;

        public string Url { get; set; }

        public object Data { get; set; }
    }
}
