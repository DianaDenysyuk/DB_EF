namespace DB_EF
{
    using DB_EF.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MarketModel : DbContext
    {
        public MarketModel()
            : base("name=MarketModel")
        {
        }
        public virtual DbSet<AbstractProduct> AbstractProducts { get; set; }
        public virtual DbSet<Adress> Adresses { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<RealProduct> RealProducts { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        //f
    }
}