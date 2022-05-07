namespace TSDC.Core.Domain.Warehouse
{
    public class WarehouseItemUnit : BaseEntity
    {
        public int WarehouseItemId { get; set; }

        public int UnitId { get; set; }

        public string? UnitName { get; set; }

        public int ConvertRate { get; set; }

        public bool IsPrimary { get; set; }

        public WarehouseItem? WarehouseItem { get; set; }

        public Unit? Unit { get; set; }
    }
}
