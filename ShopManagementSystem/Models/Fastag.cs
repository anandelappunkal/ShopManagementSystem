using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class Fastag 
    {
        public int FastagId { get; set; }      
       
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? AmountTotal { get; set; }  
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Fastag()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }

    }
}
