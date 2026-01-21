namespace FullSD_InventoryManagement.Domain
{
    public class Order : BaseDomainModel
    {
       public MovementType Movement { get; set; }
       public OrderStatus Status { get; set; } = OrderStatus.Pending;
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
public enum OrderStatus
{
    Pending = 0,
    Approved = 1,
    Denied = 2
}