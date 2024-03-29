﻿namespace AMXProductsCatalog.Views.CreateProduct.Request
{
    public class CreateCarProductRequestDTO
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
    }
}