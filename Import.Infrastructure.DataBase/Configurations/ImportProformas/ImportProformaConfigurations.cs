using Import.Domain.Core.ImportProforma;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Import.Infrastructure.DataBase.Configurations.ImportProformas
{
    internal sealed class ImportProformaConfigurations : IEntityTypeConfiguration<ImportProforma>
    {
        public void Configure(EntityTypeBuilder<ImportProforma> builder)
        {
            builder.ToTable(nameof(ImportProforma), "Import");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasConversion(v => v.Value, v => new ImportProformaId(v));

            //builder.HasMany(x => x.ImportProformaGoodsDetails)
            //    .WithOne(y => y.ImportProforma)
            //    .HasForeignKey(x => x.ImportProformaId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);

            builder.OwnsMany(s => s.ImportProformaGoodsDetails, y =>
            {
                y.WithOwner().HasForeignKey("ImportProformaId");

                y.ToTable("ImportProformaGoodsDetail", "Import");

                y.Property(x => x.ImportProformaId)
                .HasConversion(v => v.Value,
                               v => new ImportProformaId(v));

                y.HasKey("ImportProformaId");
            });
        }
    }


    //builder.OwnsMany(s => s.ImportProformaGoodsDetails, y =>
    //{
    //    y.WithOwner().HasForeignKey("ProductId");

    //    y.ToTable("ProductFeatureValues", "Catalog");

    //    y.Property(x => x.ProductId)
    //    .HasConversion(
    //        v => v.Value,
    //        v => new ProductId(v));

    //    y.Property(x => x.FeatureId)
    //    .HasConversion(
    //        v => v.Value,
    //        v => new FeatureId(v));

    //    y.HasKey("ProductId", "FeatureId");

    //});

}

