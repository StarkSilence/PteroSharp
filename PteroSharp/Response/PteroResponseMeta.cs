using Newtonsoft.Json;

namespace PteroSharp.Response
{
    internal class PteroResponseMeta
    {
        [JsonProperty("pagination")]
        public PteroResponsePagination Pagination { get; set; }
    }
}