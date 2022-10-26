using APISoft.Models;
using Microsoft.EntityFrameworkCore;

namespace APISoft.Data.Map
{
    public class ContatoMap : IEntityTypeConfiguration<ContatoModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ContatoModel> builder)
        {
            builder.HasKey(x => x.PessoaId);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Celular).IsRequired().HasMaxLength(11);
            
        }
    }
}
