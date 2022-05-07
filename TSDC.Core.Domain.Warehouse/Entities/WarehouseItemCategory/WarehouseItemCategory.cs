namespace TSDC.Core.Domain.Warehouse
{
    public class WarehouseItemCategory : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? ParentId { get; set; }

        public string? Path { get; set; }

        public bool Inactive { get; set; }

        public IList<WarehouseItem>? WarehouseItems { get; set; }
    }
}
