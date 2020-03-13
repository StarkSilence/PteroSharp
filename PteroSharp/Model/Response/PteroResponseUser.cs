﻿using System.Text.Json.Serialization;
using Newtonsoft.Json;
using PteroSharp.Model;

namespace PteroSharp.Model.Response
{
    internal class PteroResponseUser
    {
        [JsonProperty("object")]
        public string ObjectType { get; set; }
        [JsonProperty("attributes")]
        public PteroUser User { get; set; }
    }
}