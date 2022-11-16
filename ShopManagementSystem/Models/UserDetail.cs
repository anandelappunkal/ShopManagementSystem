namespace ShopManagementSystem.Models
{
    public class UserDetail : BaseEntity
    {
        public User user { get; set; }
        public int userID { get; set; }
        public Category category { get; set; }
        public int CategoryID { get; set; }
    }
}
