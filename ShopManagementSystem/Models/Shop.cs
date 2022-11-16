using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class Shop : BaseEntity
    {
        public string Name { get; set; }
        public string Place { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Total { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
    }
}
