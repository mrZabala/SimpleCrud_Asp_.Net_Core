using Microsoft.EntityFrameworkCore;
using crud_Aplication.Models;

namespace crud_Aplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<crud_Aplication.Models.Contact> Contacts { get; set; }
    }
}
