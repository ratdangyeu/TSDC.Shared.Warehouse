namespace TSDC.Core.Domain.Warehouse
{
    public class WarehouseLimit : BaseEntity
    {
        public int WarehouseId { get; set; }

        public int WarehouseItemId { get; set; }

        public int UnitId { get; set; }

        public string? UnitName { get; set; }

        public double MinQuantity { get; set; }

        public double MaxQuantity { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }

        public Warehouse? Warehouse { get; set; }

        public WarehouseItem? WarehouseItem { get; set; }

        public Unit? Unit { get; set; }
    }
}
