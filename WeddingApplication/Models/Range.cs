using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace WeddingApplication.Models
{
    public class Range
    {
        public decimal Min { get; set; } = 0;
        public decimal Max { get; set; } = 0;

        public Range() {
        }

        public Range(decimal min, decimal max)
        {
            Min = min;
            Max = max;
        }
        internal bool IsNumInRange(decimal num)
        {
            return num >= Min && num <= Max;
        }
    }
}
