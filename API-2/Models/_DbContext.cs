using Microsoft.EntityFrameworkCore;

namespace API_2.Models
{
    public class _DbContext: DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options): base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Pessoa> pessoa { get; set; }

        public DbSet<Contato> contato { get; set; }
    }
}
