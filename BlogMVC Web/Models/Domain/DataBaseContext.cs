using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace BlogMVC_Web.Models.Domain
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
    }
}
