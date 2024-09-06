using Import.Domain.Core.ImportFiles;
using Import.Domain.Core.ImportProforma;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Infrastructure.DataBase.Context
{
    public class ImportContext : DbContext
    {
        //Just AggregateRoots
        public DbSet<ImportFile> ImportFiles { get; set; }
        public DbSet<ImportProforma> ImportProformas { get; set; }


        public ImportContext(DbContextOptions<ImportContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ImportContext).Assembly);
        }
    }
}
