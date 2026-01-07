namespace FullSD_InventoryManagement.Domain
{
    public class Order : BaseDomainModel
    {
       public MovementType Movement { get; set; }
       public string? Location { get; set; }
       public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
       public int BranchID { get; set; }
    }
}

public enum MovementType
{
    In = 0,
    Out = 1
}