using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class Inventory 
    {
        public int Id { get; set; }

        public int MobileNumber { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
        [StringLength(15, ErrorMessage = "PartyName cannot be longer than 15 characters.")]
        public string PartyName { get; set; }

        [StringLength(15, ErrorMessage = "ProductName cannot be longer than 15 characters.")]
        public string ProductName { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public int NoOfItem { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Total { get; set; }

        public Inventory()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }
    }
}

