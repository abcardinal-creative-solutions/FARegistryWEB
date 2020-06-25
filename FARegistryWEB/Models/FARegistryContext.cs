using FARegistryWEB.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FARegistryWEB.Data
{
    public class RegistryContext : DbContext
    {


        public RegistryContext(DbContextOptions<RegistryContext> options ) : base(options)
        {
            
        }
        public DbSet<RegistryRecord> RegistryRecords { get; set; }
    }
}
