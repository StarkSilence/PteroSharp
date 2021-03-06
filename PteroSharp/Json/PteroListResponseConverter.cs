﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PteroSharp.Json
{
    internal class PteroListResponseConverter<T> : JsonConverter<List<T>>
    {
        public override bool CanRead => Attribute.IsDefined(typeof(T), typeof(PteroResponseAttribute));
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, List<T> value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override List<T> ReadJson(JsonReader reader, Type objectType, List<T> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var list = JObject.Load(reader).Value<JArray>("data");
            var stringList = list.Children().Select(c => c.ToString());

            var converter = new PteroResponseConverter<T>();
            return stringList.Select(i => JsonConvert.DeserializeObject<T>(i, converter)).ToList();
        }
    }
}