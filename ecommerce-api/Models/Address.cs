﻿namespace ecommerce_api.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string? HouseNumber { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

    }
}
