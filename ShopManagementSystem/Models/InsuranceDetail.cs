using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManagementSystem.Models
{
    public class InsuranceDetail : BaseEntity
    {

        public User user { get; set; }
        public int? UserId { get; set; }

        public string NomineeName { get; set; }
        public string PolicyNumber { get; set; }
        public Category category { get; set; }
        public int? CategoryId { get; set; }
        public int Premium { get; set; }
        public ODCategory oDCategory { get; set; }
        public int? ODCategoryId { get; set; }
        public int ODPremium { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal ODPercentage { get; set; }
        public int Commission { get; set; }

        public int CompanyName { get; set; }

        public int VehicleModel { get; set; }

        public int VehicleNumber { get; set; }

        public DateTime ExpireDate { get; set; }

        public string Broker { get; set; }
        [Column(TypeName = "decimal(18,4)")]

        public decimal Income { get; set; }

        public string Expense { get; set; }
    }
}

