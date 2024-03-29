﻿namespace AMXProductsCatalog.Core.Domain.Entities.Stocks
{
    public class StockItemEntity<TProduct>
    {
        public long Id { get; set; }
        public TProduct Product { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset LastUpdated { get; set; }


        public StockItemEntity() { }

        public StockItemEntity(long id, TProduct product, int quantity, DateTimeOffset lastUpdated)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
            LastUpdated = lastUpdated;
        }
    }
}