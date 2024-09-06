﻿// <auto-generated />
using System;
using Import.Infrastructure.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Import.Infrastructure.DataBase.Migrations
{
    [DbContext(typeof(ImportContext))]
    partial class ImportContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Import.Domain.Core.ImportFiles.ImportFile", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ImportFile", "Import");
                });

            modelBuilder.Entity("Import.Domain.Core.ImportProforma.ImportProforma", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BeneficiaryBanck")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BeneficiaryCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Buyer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BuyingMethod")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FromCarryPeriodDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ManufacturerCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackingMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PartialShipment")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsible")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seller")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingDestination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToCarryPeriodDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransShipment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValidityDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ImportProforma", "Import");
                });

            modelBuilder.Entity("Import.Domain.Core.ImportProforma.ImportProforma", b =>
                {
                    b.OwnsMany("Import.Domain.Core.ImportProforma.ImportProformaGoodsDetail", "ImportProformaGoodsDetails", b1 =>
                        {
                            b1.Property<Guid>("ImportProformaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Fee")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("FobAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<string>("GoodsCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("GoodsName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<decimal>("GrossWeight")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<string>("HsCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<Guid?>("ImportProformaId1")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("MeasurementUnit")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<decimal>("NetWeight")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<double>("Number")
                                .HasColumnType("float");

                            b1.HasKey("ImportProformaId");

                            b1.HasIndex("ImportProformaId1");

                            b1.ToTable("ImportProformaGoodsDetail", "Import");

                            b1.WithOwner()
                                .HasForeignKey("ImportProformaId");

                            b1.HasOne("Import.Domain.Core.ImportProforma.ImportProforma", "ImportProforma")
                                .WithMany()
                                .HasForeignKey("ImportProformaId1");

                            b1.Navigation("ImportProforma");
                        });

                    b.Navigation("ImportProformaGoodsDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
