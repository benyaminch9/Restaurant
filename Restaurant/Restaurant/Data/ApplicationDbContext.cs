using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;

namespace Restaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Pay> Pays { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<TableReservation> TableReservations  { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FoodReservation> FoodReservations { get; set; }
        public DbSet<Table> Tables { get; set; }

    }
}
