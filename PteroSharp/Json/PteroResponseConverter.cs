#nullable enable

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PteroSharp.Json
{
    public class PteroResponseConverter<T> : JsonConverter<T>
    {
        public override bool CanRead => Attribute.IsDefined(typeof(T), typeof(PteroResponseAttribute));
        public override bool CanWrite => false;
        
        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var content = JObject.Load(reader).SelectToken("attributes").ToString();
            
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}