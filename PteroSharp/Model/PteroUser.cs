using System;
using Newtonsoft.Json;

namespace PteroSharp.Model
{
    public class PteroUser
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("uuid")]
        public string UUID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("username")]
        public string UserName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_admin")]
        public bool Admin { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("2fa")]
        public bool TwoFactorAuthentication { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}