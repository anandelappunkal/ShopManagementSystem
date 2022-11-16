namespace ShopManagementSystem.Models
{
    public class Inventory : BaseEntity
    {
        public int Id { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
        public string PartyName { get; set; }
        public string ProductName { get; set; }

        public int NoOfItem { get; set; }
        public int Price { get; set; }
    }
}

