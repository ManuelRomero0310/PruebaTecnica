using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ServicesLibrary.Models;

namespace ServicesLibrary.DBContext.Configure
{
    internal class BooksConfig : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("LIBROS");

            builder.Property(e => e.Id).HasColumnName("IdLibro");
            builder.Property(e => e.Titulo).HasColumnName("Titulo");
            builder.Property(e => e.IdAutor).HasColumnName("IdAutor");
        }
    }
}
