namespace PteroSharp.Model
{
    public class PteroServerLimits
    {
        public int Memory { get; set; }
        public int Swap { get; set; }
        public int Disk { get; set; }
        public int IO { get; set; }
        public int CPU { get; set; }
    }
}