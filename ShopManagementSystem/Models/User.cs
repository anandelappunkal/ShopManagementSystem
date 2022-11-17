using ShopManagementSystem.Migrations;
using System.ComponentModel.DataAnnotations;

namespace ShopManagementSystem.Models
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string AadharID { get; set; }

        public string PanCard { get; set; }
       
        public UserType UserType { get; set; }

        public int UserTypeID { get; set; }

        public int MobileNumber { get; set; }
    }
}
