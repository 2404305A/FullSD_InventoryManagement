namespace FullSD_InventoryManagement.Domain
{
    public class OrderDetail : BaseDomainModel
    {
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
    }
}
