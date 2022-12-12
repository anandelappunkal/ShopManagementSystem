using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ShopManagementSystem.Models
{
    public class Fastag 
    {
        public int FastagId { get; set; }      
       
        [ForeignKey("UserId")]
        public User? User { get; set; }
        [Display(Name = "Customer Name")]
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
