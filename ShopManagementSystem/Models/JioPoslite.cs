using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class JioPoslite 
    {
        public int Id { get; set; }
        [ForeignKey("CustomerId")]
        public User? user { get; set; }
        public int CustomerId { get; set; }
        public string TarifPlan { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Total { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public JioPoslite()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }
    }
}
