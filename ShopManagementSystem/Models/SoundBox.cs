using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class SoundBox 
    {
        public int SoundBoxId { get; set; }

        [StringLength(15, ErrorMessage = "ItemPlan cannot be longer than 15 characters.")]
        public string ItemPlan { get; set; }

        public int NoOfItem { get; set; }
        public int Price { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Total { get; set; }       
        public string  ShopName { get; set; }
        public int ShopId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public SoundBox()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }
    }
}
