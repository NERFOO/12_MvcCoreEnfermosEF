using _12_MvcCoreEnfermosEF.Models;
using Microsoft.EntityFrameworkCore;

namespace _12_MvcCoreEnfermosEF.Data
{
    public class EnfermoContext : DbContext
    {
        public EnfermoContext(DbContextOptions<EnfermoContext> options) : base(options) { }

        public DbSet<Enfermo> Enfermos { get; set; }
    }
}
