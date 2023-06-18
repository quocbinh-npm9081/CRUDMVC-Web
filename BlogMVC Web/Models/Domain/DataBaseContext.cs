using Microsoft.EntityFrameworkCore;

namespace BlogMVC_Web.Models.Domain
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base()
        {

        }

        public DbSet<Person> Person { get; set; }
    }
}
