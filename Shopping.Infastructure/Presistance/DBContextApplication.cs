using Microsoft.EntityFrameworkCore;
using Shopping.Domain.Entities;
using Shopping.Infrastructure.Presistance.Seeds;


namespace Shopping.Infrastructure.Presistance
{
    public class DBContextApplication : DbContext 
    {
        public DBContextApplication(DbContextOptions<DBContextApplication> options)
           : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("data source=.;initial catalog=ShoppingDB;integrated security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedRolesAndPermissions();
        }
        public DbSet<Module> Modules { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }





    }
}
