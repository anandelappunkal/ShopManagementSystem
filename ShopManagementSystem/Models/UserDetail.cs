using System.ComponentModel.DataAnnotations;

namespace ShopManagementSystem.Models
{
    public class UserDetail 
    {
        public UserDetail()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }

        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Description cannot be longer than 50 characters.")]
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public User user { get; set; }
        public int UserID { get; set; }
        public Category category { get; set; }
        public int CategoryID { get; set; }
    }
}
