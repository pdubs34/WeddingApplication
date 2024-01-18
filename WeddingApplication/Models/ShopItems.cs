using System.Security.Cryptography.X509Certificates;

namespace WeddingApplication.Models
{
    public class ShopItems
    {
        public string ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Category { get; set; }
    }
}
