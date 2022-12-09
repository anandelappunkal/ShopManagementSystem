using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class Insurance
    {
        public int InsuranceId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }
        public int? UserId { get; set; }

        [StringLength(30, ErrorMessage = "NomineeName cannot be longer than 30 characters.")]
        public string NomineeName { get; set; }

        [StringLength(30, ErrorMessage = "PolicyNumber cannot be longer than 30 characters.")]
        public string PolicyNumber { get; set; }

        [ForeignKey("ODCategoryId")]
        public ODCategory? ODCategory { get; set; }
        public int? ODCategoryId { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Premium { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal ODPremium { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal ODPercentage { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Commission { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal NoClaimBonusPercentage { get; set; }  

        [StringLength(15, ErrorMessage = "CompanyName cannot be longer than 15 characters.")]
        public Company CompanyName { get; set; }
        public int CompanyId { get; set; }
        [StringLength(15, ErrorMessage = "VehicleModel cannot be longer than 15 characters.")]
        public string VehicleModel { get; set; }

        public int VehicleNumber { get; set; }

        public DateTime ExpireDate { get; set; }

        public string Broker { get; set; }       

        public string? EngineNumber { get; set; }

        public string? ChaiseNumber { get; set; }

        public string? ManufactureMonthyear { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Income { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Expense { get; set; }
      
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Insurance()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }

    }
}

