﻿using Newtonsoft.Json;

namespace PteroSharp.Model.Sub
{
    public class PteroStartup
    {
        [JsonProperty("done")]
        public string Done { get; set; }
        
        [JsonProperty("userInteraction")]
        public string[] UserInteraction { get; set; }
    }
}