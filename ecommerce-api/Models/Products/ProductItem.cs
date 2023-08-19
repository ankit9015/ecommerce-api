namespace ecommerce_api.Models.Products
{
    public class ProductItem
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public int QuantityInStock { get; set; }
        public double Price { get; set; }
        public string? SKU { get; set; }
        // A SKU (stock keeping unit) is used to further define an item number.
        // An item that is sold in multiple colors and sizes is often represented by a base item number,
        // which is common to all of the colors and sizes, and a SKU which specifically defines the color and size.
        // For example, the base item number for a dress could be 9201 and the SKUs associated with that item number
        // could be RED SML, RED MED, RED LRG, BLUE SML, BLUE MED, and BLUE LRG.
    }
}
