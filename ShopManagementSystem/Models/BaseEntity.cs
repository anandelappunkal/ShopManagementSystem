using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public partial class BaseEntity
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public int? MobileNumber { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Total { get; set; }

      

        public BaseEntity()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }
    }
}
