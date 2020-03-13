using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using PteroSharp.Model;
using PteroSharp.Model.Response;

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
            var res = ParseResponse<PteroResponse>(Get("application/users"));

            return res.PteroResponseUsers.Select(resUser => resUser.User).ToList();
        }

        public PteroUser GetUser(int id)
        {
            var res = ParseResponse<PteroResponseUser>(Get($"application/users/{id}"));

            return res.User;
        }

        public PteroUser GetUser(string externalID)
        {
            var res = ParseResponse<PteroResponseUser>(Get($"application/users/external/{externalID}"));

            return res.User;
        }

        private HttpResponseMessage Get(string path)
        {
            var req = new HttpRequestMessage(HttpMethod.Get, new Uri($"{_URL}/api/{path}"));
            
            return _HttpClient.SendAsync(req).Result;
        }

        private T ParseResponse<T>(HttpResponseMessage res)
        {
            var content = res.Content.ReadAsStringAsync().Result;
            
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}