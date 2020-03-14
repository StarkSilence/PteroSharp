using System;

namespace PteroSharp.Model
{
    public class PteroEgg
    {
        public int ID { get; set; }
        public string UUID { get; set; }
        public int Nest { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string DockerImage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}