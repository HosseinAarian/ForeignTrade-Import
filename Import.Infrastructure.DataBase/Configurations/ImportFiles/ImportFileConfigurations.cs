using Import.Domain.Core.ImportFiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Infrastructure.DataBase.Configurations.ImportFiles
{
    public sealed class ImportFileConfigurations : IEntityTypeConfiguration<ImportFile>
    {
        public void Configure(EntityTypeBuilder<ImportFile> builder)
        {
            builder.ToTable("ImportFile", "Import");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasConversion(v => v.Value, v => new ImportFileId(v));

            builder.Property(x => x.Number).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1024);
        }
    }
}
