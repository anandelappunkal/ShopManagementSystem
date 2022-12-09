

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopManagementSystem.Models;

namespace ShopManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Company> Company { get; set; }

        public DbSet<ODCategory> ODCategory { get; set; }
        public DbSet<UserType> UserType { get; set; }

       

        public DbSet<Shop> Shop { get; set; }
       

        public DbSet<JioPoslite> JioPsoslite { get; set; }

       
       

        public DbSet<Fastag> Fastag { get; set; }

        public DbSet<SoundBox> SoundBox { get; set; }

        public DbSet<Insurance> Insurance { get; set; }

    }
}

