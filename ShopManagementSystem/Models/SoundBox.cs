using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class SoundBox 
    {
        public int SoundBoxId { get; set; }

        [ForeignKey("ShopId")]
        public Shop? ShopName { get; set; }
        [Display(Name = "Shop Name")]
        public int ShopId { get; set; }       
        public string? Category { get; set; }
        public string? ItemPlan { get; set; }
        public int NoOfItems { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Total { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public SoundBox()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }
    }
}
