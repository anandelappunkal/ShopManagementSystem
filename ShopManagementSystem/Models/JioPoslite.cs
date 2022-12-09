using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class JioPoslite 
    {
        public int JioPosliteId { get; set; }
        [ForeignKey("CustomerId")]
        public User? user { get; set; }
        public int CustomerId { get; set; }

        [StringLength(50, ErrorMessage = "TarifPlan cannot be longer than 50 characters.")]
        public string TarifPlan { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Total { get; set; }        
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public JioPoslite()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }
    }
}
