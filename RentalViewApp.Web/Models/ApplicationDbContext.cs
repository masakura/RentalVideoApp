using System.Data.Entity;

namespace RentalViewApp.Web.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}