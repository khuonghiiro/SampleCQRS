﻿namespace SampleCQRS.Core
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
    }
}