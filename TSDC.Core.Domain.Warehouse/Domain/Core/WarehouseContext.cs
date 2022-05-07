using Microsoft.EntityFrameworkCore;

namespace TSDC.Core.Domain.Warehouse
{
    public class WarehouseContext : DbContext
    {
        #region Fields
        public DbSet<BeginningWarehouse> BeginningWarehouse { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<WarehouseBalance> WarehouseBalance { get; set; }
        public DbSet<WarehouseItem> WarehouseItem { get; set; }
        public DbSet<WarehouseItemCategory> WarehouseItemCategory { get; set; }
        public DbSet<WarehouseItemUnit> WarehouseItemUnit { get; set; }
        public DbSet<WarehouseLimit> WarehouseLimit { get; set; }
        #endregion

        #region Ctor
        public WarehouseContext(DbContextOptions options) : base(options)
        {

        }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {          
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }
        #endregion
    }
}
