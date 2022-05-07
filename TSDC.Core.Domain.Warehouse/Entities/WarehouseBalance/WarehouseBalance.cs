namespace TSDC.Core.Domain.Warehouse
{
    public class WarehouseBalance : BaseEntity
    {
        public int WarehouseItemId { get; set; }

        public int WarehouseId { get; set; }

        public double Quantity { get; set; }

        public double Amount { get; set; }

        public WarehouseItem? WarehouseItem { get; set; }

        public Warehouse? Warehouse { get; set; }
    }
}
