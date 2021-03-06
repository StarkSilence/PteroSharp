﻿using Newtonsoft.Json;

namespace PteroSharp.Model.Sub
{
    public class PteroCPU
    {
        [JsonProperty("current")]
        public double Current { get; set; }
        
        [JsonProperty("cores")]
        public double[] Cores { get; set; }
        
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}