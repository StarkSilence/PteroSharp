using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using PteroSharp.Json;
using PteroSharp.Model;

namespace PteroSharp
{
    public class PteroApp
    {
        private readonly string _URL;
        private readonly HttpClient _HttpClient = new HttpClient();
        
        public PteroApp(string url, string authToken)
        {
            _URL = url;
            
            _HttpClient.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse($"Bearer {authToken}");
            _HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            _HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "Application/vnd.pterodactyl.v1+json");
        }
        
        public List<PteroUser> GetUsers()
        {
            return ParseListResponse<PteroUser>(Get("application/users"));
        }

        public PteroUser GetUser(int id)
        {
            return ParseResponse<PteroUser>(Get($"application/users/{id}"));
        }

        public PteroUser GetUser(string externalID)
        {
            return ParseResponse<PteroUser>(Get($"application/users/external/{externalID}"));
        }

        public List<PteroNode> GetNodes()
        {
            return ParseListResponse<PteroNode>(Get("application/nodes"));
        }

        private HttpResponseMessage Get(string path)
        {
            var req = new HttpRequestMessage(HttpMethod.Get, new Uri($"{_URL}/api/{path}"));
            
            return _HttpClient.SendAsync(req).Result;
        }

        private List<T> ParseListResponse<T>(HttpResponseMessage res)
        {
            var content = res.Content.ReadAsStringAsync().Result;
            
            return JsonConvert.DeserializeObject<List<T>>(content, new PteroListResponseConverter<T>());
        }
        
        private T ParseResponse<T>(HttpResponseMessage res)
        {
            var content = res.Content.ReadAsStringAsync().Result;
            
            return JsonConvert.DeserializeObject<T>(content, new PteroResponseConverter<T>());
        }
    }
}