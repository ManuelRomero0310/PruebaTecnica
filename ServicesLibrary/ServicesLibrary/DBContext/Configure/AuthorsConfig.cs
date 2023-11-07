using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ServicesLibrary.Models;

namespace ServicesLibrary.DBContext.Configure
{
    internal class AuthorsConfig : IEntityTypeConfiguration<Authors>
    {
        public void Configure(EntityTypeBuilder<Authors> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("AUTORES");

            builder.Property(e => e.Id).HasColumnName("IdAutor");
            builder.Property(e => e.Nombre).HasColumnName("Nombre");
        }
    }
}
