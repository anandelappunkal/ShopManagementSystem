using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class JioPoslite : BaseEntity
    {
        public User user { get; set; }
        public int UserId { get; set; }
        public string TarifPlan { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
    }
}
