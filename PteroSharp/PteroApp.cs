using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using PteroSharp.Json;
using PteroSharp.Model;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;

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
        
        //Users
        
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
        
        //Nodes

        public List<PteroNode> GetNodes()
        {
            return ParseListResponse<PteroNode>(Get("application/nodes"));
        }

        public PteroNode GetNode(int id)
        {
            return ParseResponse<PteroNode>(Get($"application/nodes/{id}"));
        }
        
        //Locations

        public List<PteroLocation> GetLocations()
        {
            return ParseListResponse<PteroLocation>(Get("application/locations"));
        }

        public PteroLocation GetLocation(int id)
        {
            return ParseResponse<PteroLocation>(Get($"application/locations/{id}"));
        }
        
        //Servers

        public List<PteroServer> GetServers()
        {
            return ParseListResponse<PteroServer>(Get("application/servers"));
        }

        public PteroServer GetServer(int id)
        {
            return ParseResponse<PteroServer>(Get($"application/servers/{id}"));
        }

        public PteroServer GetServer(string externalID)
        {
            return ParseResponse<PteroServer>(Get($"application/locations/servers/external/{externalID}"));
        }
        
        //Nests

        public List<PteroNest> GetNests()
        {
            return ParseListResponse<PteroNest>(Get("application/nests"));
        }

        public PteroNest GetNest(int id)
        {
            return ParseResponse<PteroNest>(Get($"application/nests/{id}"));
        }
        
        //Eggs

        public List<PteroEgg> GetEggs(int nestID)
        {
            return ParseListResponse<PteroEgg>(Get($"application/nests/{nestID}/eggs"));
        }

        public PteroEgg GetEgg(int nestID, int eggID)
        {
            return ParseResponse<PteroEgg>(Get($"application/nests/{nestID}/eggs/{eggID}"));
        }
        
        //HTTP

        private HttpResponseMessage Get(string path)
        {
            var req = new HttpRequestMessage(HttpMethod.Get, new Uri($"{_URL}/api/{path}"));
            
            return _HttpClient.SendAsync(req).Result;
        }

        private HttpResponseMessage Post<T>(string path, T content)
        {
            var req = new HttpRequestMessage(HttpMethod.Post, new Uri($"{_URL}/api/{path}"))
            {
                Content = new StringContent(JsonConvert.SerializeObject(content, Formatting.Indented))
            };

            return _HttpClient.SendAsync(req).Result;
        }

        private HttpResponseMessage Patch<T>(string path, T content)
        {
            var req = new HttpRequestMessage(HttpMethod.Patch, new Uri($"{_URL}/api/{path}"))
            {
                Content = new StringContent(JsonConvert.SerializeObject(content, Formatting.Indented))
            };

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