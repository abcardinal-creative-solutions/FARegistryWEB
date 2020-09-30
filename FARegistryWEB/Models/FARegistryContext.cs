using FARegistryWEB.Models;
using Microsoft.EntityFrameworkCore;

namespace FARegistryWEB.Data
{
    public class RegistryContext : DbContext
    {


        public RegistryContext(DbContextOptions<RegistryContext> options) : base(options)
        {

        }
        public DbSet<RegistryRecord> RegistryRecords { get; set; }
    }
}
