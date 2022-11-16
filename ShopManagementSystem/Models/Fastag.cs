namespace ShopManagementSystem.Models
{
    public class Fastag : BaseEntity
    {
        public User user { get; set; }
        public int userId { get; set; }
        public Category category { get; set; }

        public int CategoryId { get; set; }

    }
}
