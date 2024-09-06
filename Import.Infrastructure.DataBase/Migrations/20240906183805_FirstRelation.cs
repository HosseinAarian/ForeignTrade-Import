using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Import.Infrastructure.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class FirstRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImportProforma",
                schema: "Import",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Buyer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeneficiaryCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeneficiaryBanck = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BuyingMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackingMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartialShipment = table.Column<bool>(type: "bit", nullable: false),
                    TransShipment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingDestination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromCarryPeriodDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToCarryPeriodDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Responsible = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportProforma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImportProformaGoodsDetail",
                schema: "Import",
                columns: table => new
                {
                    ImportProformaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoodsCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoodsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeasurementUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Number = table.Column<double>(type: "float", nullable: false),
                    GrossWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FobAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HsCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImportProformaId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportProformaGoodsDetail", x => x.ImportProformaId);
                    table.ForeignKey(
                        name: "FK_ImportProformaGoodsDetail_ImportProforma_ImportProformaId",
                        column: x => x.ImportProformaId,
                        principalSchema: "Import",
                        principalTable: "ImportProforma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImportProformaGoodsDetail_ImportProforma_ImportProformaId1",
                        column: x => x.ImportProformaId1,
                        principalSchema: "Import",
                        principalTable: "ImportProforma",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImportProformaGoodsDetail_ImportProformaId1",
                schema: "Import",
                table: "ImportProformaGoodsDetail",
                column: "ImportProformaId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImportProformaGoodsDetail",
                schema: "Import");

            migrationBuilder.DropTable(
                name: "ImportProforma",
                schema: "Import");
        }
    }
}
