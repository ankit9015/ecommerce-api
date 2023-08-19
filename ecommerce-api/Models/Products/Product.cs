using System.Reflection.Metadata;

namespace ecommerce_api.Models.Products
{
    public class Product
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public IEnumerable<Blob>? ProductImages { get; set; }

    }
}
