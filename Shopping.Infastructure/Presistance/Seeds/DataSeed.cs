using Microsoft.EntityFrameworkCore;
using Shopping.Domain.Entities;
using Module = Shopping.Domain.Entities.Module;


namespace Shopping.Infrastructure.Presistance.Seeds
{
    public static class DataSeed
    {
     
        public static void SeedRolesAndPermissions(this ModelBuilder modelBuilder)
        {
            
            //    // Seed Modules
            modelBuilder.Entity<Module>().HasData(
            new Module { Id = 1, Name = "Users" },
            new Module { Id = 2, Name = "Orders" },
            new Module { Id = 3, Name = "Products" },
            new Module { Id = 4, Name = "Roles" },
            new Module { Id = 5, Name = "Carts" },
            new Module { Id = 6, Name = "Reviews" },
            new Module { Id = 7, Name = "Images" },
            new Module { Id = 8, Name = "Categories" }
            );
          
            //    // Seed Permissions
            modelBuilder.Entity<Permission>().HasData(
            new Permission { Id = 1, Name = "Read", ModuleId = 8 },
            new Permission { Id = 2, Name = "Create", ModuleId = 8 },
            new Permission { Id = 3, Name = "Update", ModuleId = 8 },
            new Permission { Id = 4, Name = "Delete", ModuleId = 8 }
         
            );
           
            // Seed Roles
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "User" }
                );

           
            // Seed RolePermissions
            modelBuilder.Entity<RolePermission>().HasData(
            new RolePermission { Id= 1, RoleId = 1, PermissionId = 1 },  // Admin can Read Users
            new RolePermission { Id = 2, RoleId = 1, PermissionId = 2 },  // Admin can Write Users
            new RolePermission { Id = 3, RoleId = 1, PermissionId = 3 },  // Admin can Read Orders
            new RolePermission { Id = 4, RoleId = 1, PermissionId = 4 },  // Admin can Write Orders
            new RolePermission { Id = 5, RoleId = 2, PermissionId = 1 },  // User can Read Users
            new RolePermission { Id = 6, RoleId = 2, PermissionId = 3 }   // User can Read Orders
            );
        

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Category 1" },
                new Category { Id = 2, Name = "Category 2" },
                new Category { Id = 3, Name = "Category 3" },
                new Category { Id = 4, Name = "Category 4" },
                new Category { Id = 5, Name = "Category 5" },
                new Category { Id = 6, Name = "Category 6" },
                new Category { Id = 7, Name = "Category 7" }
            );
        }
    }
}
