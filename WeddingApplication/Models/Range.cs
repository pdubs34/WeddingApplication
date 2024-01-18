using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace WeddingApplication.Models
{
    public class Range
    {
        public int Min { get; set; }
        public int Max { get; set; }
        
        public int Num { get; set; }

        public Range() { }
        public Range(int min, int max, int num) {
            Min = min;
            Max = max;
            Num = num;
        }

        internal bool IsNumInRange()
        {
            return Num >= Min && Num <= Max;
        }
    }
}
