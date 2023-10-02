using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoCleanArchiteture.Domain.Entities;

namespace ProjetoCleanArchiteture.Infra.Data.EntityConfigurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Price).HasPrecision(10, 2);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Caderno",
                    Description = "Caderno de 10 mat 200 fls",
                    Price = 15.50m
                },
                new Product
                {
                    Id = 2,
                    Name = "Caneta",
                    Description = "Caneta Bic 1.0 azul",
                    Price = 3.60m
                },
                new Product
                {
                    Id = 3,
                    Name = "Borracha",
                    Description = "Borracha branca nº 40",
                    Price = 2.80m
                }
            );
        }
    }
}
