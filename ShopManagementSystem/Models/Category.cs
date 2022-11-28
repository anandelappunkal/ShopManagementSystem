using System.ComponentModel.DataAnnotations;

namespace ShopManagementSystem.Models
{
    public class Category 
    {
        public int CategoryId { get; set; }

        [StringLength(15, ErrorMessage = "Name cannot be longer than 15 characters.")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Description cannot be longer than 50 characters.")]
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Category()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }
    }
}
