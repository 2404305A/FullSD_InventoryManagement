namespace FullSD_InventoryManagement.Domain
{
    public class BranchInventory : BaseDomainModel
    {
        public int BranchID { get; set; }
        public Branch? Branch { get; set; }
        public int ItemID { get; set; }
        public Item? Item { get; set; }
        public int Quantity { get; set; }
    }
}
