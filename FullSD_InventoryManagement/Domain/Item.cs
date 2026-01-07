namespace FullSD_InventoryManagement.Domain
{
    public class Item : BaseDomainModel
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }
    }
}
