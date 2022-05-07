namespace TSDC.Core.Domain.Warehouse
{
    public class Unit : BaseEntity
    {
        public string? UnitName { get; set; }

        public bool Inactive { get; set; }

        public IList<WarehouseItem>? WarehouseItems { get; set; }

        public IList<WarehouseItemUnit>? WarehouseItemsUnits { get; set; }

        public IList<WarehouseLimit>? WarehouseLimits { get; set; }

        public IList<BeginningWarehouse>? BeginningWarehouses { get; set; }
    }
}
