﻿namespace ecommerce_api.Models.Products
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public int ParentCategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
