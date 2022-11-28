
using System.ComponentModel.DataAnnotations;

namespace ShopManagementSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        [StringLength(15, ErrorMessage = "UserName cannot be longer than 15 characters.")]
        public string UserName { get; set; }
        [StringLength(15, ErrorMessage = "Password cannot be longer than 15 characters.")]
        public string Password { get; set; }
        [StringLength(15, ErrorMessage = "Email cannot be longer than 15 characters.")]
        public string Email { get; set; }
        [StringLength(15, ErrorMessage = "FirstName cannot be longer than 15 characters.")]
        public string? FirstName { get; set; }
        [StringLength(15, ErrorMessage = "LastName cannot be longer than 15 characters.")]
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(50, ErrorMessage = "Address cannot be longer than 50 characters.")]
        public string Address { get; set; }
        [StringLength(15, ErrorMessage = "AadharID cannot be longer than 15 characters.")]

        public string AadharID { get; set; }
        [StringLength(15, ErrorMessage = "PanCard cannot be longer than 15 characters.")]

        public string PanCard { get; set; }

        public int? MobileNumber { get; set; }

        public UserType UserType { get; set; }

        public int UserTypeID { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public User()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }


    }
}
