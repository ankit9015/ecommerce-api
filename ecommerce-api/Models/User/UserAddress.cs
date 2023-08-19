namespace ecommerce_api.Models.User
{
    public class UserAddress
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public bool IsDefault { get; set; }
    }
}
