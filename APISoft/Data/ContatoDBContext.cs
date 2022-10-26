using APISoft.Data.Map;
using APISoft.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APISoft.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoDBContext : DbContext
    {
        public ContatoDBContext(DbContextOptions<ContatoDBContext> options)
            : base(options)
        {
        }
        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<ContatoModel> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
