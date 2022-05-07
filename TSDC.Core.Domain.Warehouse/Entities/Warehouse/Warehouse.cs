namespace TSDC.Core.Domain.Warehouse
{
    public class Warehouse : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string? Address { get; set; }

        public string? Description { get; set; }

        public string? ParentId { get; set; }

        public string? Path { get; set; }

        public bool Inactive { get; set; }

        public IList<WarehouseLimit>? WarehouseLimits { get; set; }

        public IList<WarehouseBalance>? WarehouseBalances { get; set; }

        public IList<BeginningWarehouse>? BeginningWarehouses { get; set; }
    }
}
