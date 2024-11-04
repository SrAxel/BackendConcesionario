using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendConcesionario.Migrations
{
    /// <inheritdoc />
    public partial class backdatosemilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Make = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Model = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name_or_CompanyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dni = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone_Number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cuit_Cuil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CarsFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Feature = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarsFeatures_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CarsImagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsPrimaryImage = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsImagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarsImagens_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PaymentMethod = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CarPrice = table.Column<int>(type: "int", nullable: false),
                    SaleDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ClientId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Clients_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "Clients",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Description", "Make", "Model", "Price", "Status", "Stock", "Year" },
                values: new object[,]
                {
                    { 1, "Sedán con gran eficiencia de combustible.", "Toyota", "Corolla", 4500000m, "New", 5, 2023 },
                    { 2, "Deportivo con diseño aerodinámico.", "Honda", "Civic", 4200000m, "New", 3, 2022 },
                    { 3, "Camioneta de alta resistencia.", "Ford", "Ranger", 6800000m, "Used", 2, 2023 },
                    { 4, "Compacto con tecnología avanzada.", "Chevrolet", "Cruze", 3700000m, "New", 4, 2021 },
                    { 5, "Sedán cómodo y espacioso.", "Nissan", "Sentra", 3900000m, "New", 6, 2023 }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Cuit_Cuil", "Dni", "Email", "Name_or_CompanyName", "Phone_Number" },
                values: new object[,]
                {
                    { 1, "Calle Falsa 123, Rosario", 0, "12345678", "juan.perez@email.com", "Juan Pérez", "3412345678" },
                    { 2, "Av. Libertador 456, Santa Fe", 0, "23456789", "maria.gonzalez@email.com", "María González", "3412345679" },
                    { 3, "Ruta 11, Km 15, Reconquista", 0, "34567890", "carlos.rodriguez@email.com", "Carlos Rodríguez", "3412345680" },
                    { 4, "Bv. Oroño 789, Santa Fe", 0, "45678901", "laura.fernandez@email.com", "Laura Fernández", "3412345681" },
                    { 5, "Mitre 456, Santo Tomé", 0, "56789012", "roberto.sanchez@email.com", "Roberto Sánchez", "3412345682" }
                });

            migrationBuilder.InsertData(
                table: "CarsFeatures",
                columns: new[] { "Id", "CarId", "Feature" },
                values: new object[,]
                {
                    { 1, 1, "Aire acondicionado" },
                    { 2, 1, "Frenos ABS" },
                    { 3, 2, "Sistema de navegación GPS" },
                    { 4, 3, "Cámara de reversa" },
                    { 5, 4, "Control de crucero" }
                });

            migrationBuilder.InsertData(
                table: "CarsImagens",
                columns: new[] { "Id", "CarId", "ImageUrl", "IsPrimaryImage" },
                values: new object[,]
                {
                    { 1, 1, "https://images.example.com/corolla-front.jpg", true },
                    { 2, 1, "https://images.example.com/corolla-side.jpg", false },
                    { 3, 2, "https://images.example.com/civic-front.jpg", true },
                    { 4, 3, "https://images.example.com/ranger-front.jpg", true },
                    { 5, 4, "https://images.example.com/cruze-front.jpg", true }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CarId", "CarPrice", "ClientId", "ClientId1", "PaymentMethod", "SaleDate" },
                values: new object[,]
                {
                    { 1, 1, 4450000, "Juan Pérez", null, "", new DateOnly(2024, 1, 15) },
                    { 2, 2, 4200000, "María González", null, "", new DateOnly(2024, 2, 20) },
                    { 3, 3, 6800000, "Carlos Rodríguez", null, "", new DateOnly(2024, 3, 10) },
                    { 4, 4, 3700000, "Laura Fernández", null, "", new DateOnly(2024, 4, 5) },
                    { 5, 5, 3900000, "Roberto Sánchez", null, "", new DateOnly(2024, 5, 12) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarsFeatures_CarId",
                table: "CarsFeatures",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarsImagens_CarId",
                table: "CarsImagens",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CarId",
                table: "Sales",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ClientId1",
                table: "Sales",
                column: "ClientId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarsFeatures");

            migrationBuilder.DropTable(
                name: "CarsImagens");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
