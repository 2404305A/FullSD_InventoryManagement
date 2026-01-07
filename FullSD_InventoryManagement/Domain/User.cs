namespace FullSD_InventoryManagement.Domain
{
    public class User : BaseDomainModel
    {
        public string? Username { get; set; }
        public string? EmailAddress { get; set; }
        public int BranchID { get; set; }
    }
}
