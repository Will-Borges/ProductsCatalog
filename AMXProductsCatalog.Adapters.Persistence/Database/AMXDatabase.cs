﻿namespace AMXProductsCatalog.Adapters.Persistence.Data
{
    using AMXProductsCatalog.Core.Domain.Entities.Orders.CreateOrder;
    using AMXProductsCatalog.Core.Domain.Entities.Products;
    using AMXProductsCatalog.Core.Domain.Entities.Stocks;

    public static class AMXDatabase
    {
        public static List<CarProductEntity> Cars { get; set; } = new List<CarProductEntity>();
        public static List<StockEntity> Stocks { get; set; } = new List<StockEntity>();
        public static List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();


        public static void startDatabase()
        {
            Cars = new List<CarProductEntity>();
            Stocks = new List<StockEntity>();
            Orders = new List<OrderEntity>();
        }
    }

    //public class AMXDatabase : DbContext
    //{
    //    public DbSet<CarProductEntity> Cars { get; set; }
    //    public DbSet<StockEntity> Stocks { get; set; }

    //    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    //{
    //    //    //modelBuilder.Entity<CarProductEntity>();
    //    //    //modelBuilder.Entity<StockEntity>();

    //    //    //modelBuilder.Entity<StockEntity>().Property(e => e.Id).ValueGeneratedNever();

    //    //    //modelBuilder.Entity<StockEntity>()
    //    //    //    .Ignore(s => s.StockItems);

    //    //    base.OnModelCreating(modelBuilder);
    //    //}


    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseInMemoryDatabase("InMemoryDatabase");
    //    }
    //}
}