using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class Shop 
    {
        public int Id { get; set; }
        [StringLength(15, ErrorMessage = "Name cannot be longer than 15 characters.")]
        public string Name { get; set; }
        public int MobileNumber { get; set; }
        [StringLength(15, ErrorMessage = "Place cannot be longer than 15 characters.")]
        public string Place { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Total { get; set; }
        public Category? category { get; set; }
        public int CategoryId { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Shop()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }
    }
}
