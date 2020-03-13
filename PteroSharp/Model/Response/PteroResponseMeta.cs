using Newtonsoft.Json;

namespace PteroSharp.Model.Response
{
    internal class PteroResponseMeta
    {
        [JsonProperty("pagination")]
        public PteroResponsePagination Pagination { get; set; }
    }
}