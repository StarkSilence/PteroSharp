using System;
using Newtonsoft.Json;

namespace PteroSharp.Model
{
    public class PteroNode
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        
        [JsonProperty("public")]
        public bool Public { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location_id")]
        public int LocationID { get; set; }
        
        [JsonProperty("fqdn")]
        public string FQDN { get; set; }
        
        [JsonProperty("scheme")]
        public string Scheme { get; set; }
        
        [JsonProperty("behind_proxy")]
        public bool BehindProxy { get; set; }
        
        [JsonProperty("maintenance_mode")]
        public bool MaintenanceMode { get; set; }
        
        [JsonProperty("memory")]
        public int Memory { get; set; }
        
        [JsonProperty("memory_overallocate")]
        public int MemoryOverAllocate { get; set; }
        
        [JsonProperty("disk")]
        public int Disk { get; set; }
        
        [JsonProperty("disk_overallocate")]
        public int DiskOverAllocate { get; set; }
        
        [JsonProperty("upload_size")]
        public int UploadSize { get; set; }
        
        [JsonProperty("daemon_listen")]
        public int DaemonListen { get; set; }
        
        [JsonProperty("daemon_sftp")]
        public int DaemonSFTP { get; set; }
        
        [JsonProperty("daemon_base")]
        public string DaemonBase { get; set; }
        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}