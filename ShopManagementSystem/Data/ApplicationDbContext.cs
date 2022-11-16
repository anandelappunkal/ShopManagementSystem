

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
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<ODCategory> ODCategorys { get; set; }
        public DbSet<UserType> UserTypes { get; set; }


        public DbSet<Shop> Shops { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }

        public DbSet<JioPoslite> JioPsoslites { get; set; }

        public DbSet<Inventory> Inventorys { get; set; }
       

        public DbSet<Fastag> Fastags { get; set; }

        public DbSet<SoundBox> SoundBoxs { get; set; }

        public DbSet<InsuranceDetail> InsuranceDetails { get; set; }

    }
}

