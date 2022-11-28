using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class InsuranceDetail 
    {
        public int InsuranceDetailId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }
        public int? UserId { get; set; }

        [StringLength(30, ErrorMessage = "NomineeName cannot be longer than 30 characters.")]
        public string NomineeName { get; set; }

        [StringLength(30, ErrorMessage = "PolicyNumber cannot be longer than 30 characters.")]
        public string PolicyNumber { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        public int? CategoryId { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Premium { get; set; }
        [ForeignKey("ODCategoryId")]
        public ODCategory? ODCategory { get; set; }
        public int? ODCategoryId { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal NoClaimBonusPercentage { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal ODPremium { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal ODPercentage { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Commission { get; set; }

        [StringLength(15, ErrorMessage = "CompanyName cannot be longer than 15 characters.")]
        public string CompanyName { get; set; }
        [StringLength(15, ErrorMessage = "VehicleModel cannot be longer than 15 characters.")]
        public string VehicleModel { get; set; }

        public int VehicleNumber { get; set; }

        public DateTime ExpireDate { get; set; }

        public string Broker { get; set; }
        [Column(TypeName = "decimal(18,4)")]

        public decimal Income { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Expense { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public InsuranceDetail()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }

    }
}

