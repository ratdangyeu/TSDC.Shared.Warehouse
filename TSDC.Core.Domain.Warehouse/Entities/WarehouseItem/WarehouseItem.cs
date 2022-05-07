namespace TSDC.Core.Domain.Warehouse
{
    public class WarehouseItem : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int? WarehouseItemCategoryId { get; set; }

        public string? Description { get; set; }

        public int? VendorId { get; set; }

        public string? VendorName { get; set; }

        public string? Country { get; set; }

        public int UnitId { get; set; }

        public bool Inactive { get; set; }

        public Unit? Unit { get; set; }

        public Vendor? Vendor { get; set; }

        public WarehouseItemCategory? WarehouseItemCategory { get; set; }

        public IList<WarehouseItemUnit>? WarehouseItemsUnits { get; set; }

        public IList<WarehouseLimit>? WarehouseLimits { get; set; }

        public IList<WarehouseBalance>? WarehouseBalances { get; set; }

        public IList<BeginningWarehouse>? BeginningWarehouses { get; set; }
    }
}
