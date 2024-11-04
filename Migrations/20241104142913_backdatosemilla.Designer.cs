﻿// <auto-generated />
using System;
using BackendConcesionario.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendConcesionario.Migrations
{
    [DbContext(typeof(ConcesionarioContext))]
    [Migration("20241104142913_backdatosemilla")]
    partial class backdatosemilla
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("BackendConcesionario.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Sedán con gran eficiencia de combustible.",
                            Make = "Toyota",
                            Model = "Corolla",
                            Price = 4500000m,
                            Status = "New",
                            Stock = 5,
                            Year = 2023
                        },
                        new
                        {
                            Id = 2,
                            Description = "Deportivo con diseño aerodinámico.",
                            Make = "Honda",
                            Model = "Civic",
                            Price = 4200000m,
                            Status = "New",
                            Stock = 3,
                            Year = 2022
                        },
                        new
                        {
                            Id = 3,
                            Description = "Camioneta de alta resistencia.",
                            Make = "Ford",
                            Model = "Ranger",
                            Price = 6800000m,
                            Status = "Used",
                            Stock = 2,
                            Year = 2023
                        },
                        new
                        {
                            Id = 4,
                            Description = "Compacto con tecnología avanzada.",
                            Make = "Chevrolet",
                            Model = "Cruze",
                            Price = 3700000m,
                            Status = "New",
                            Stock = 4,
                            Year = 2021
                        },
                        new
                        {
                            Id = 5,
                            Description = "Sedán cómodo y espacioso.",
                            Make = "Nissan",
                            Model = "Sentra",
                            Price = 3900000m,
                            Status = "New",
                            Stock = 6,
                            Year = 2023
                        });
                });

            modelBuilder.Entity("BackendConcesionario.Models.CarFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Feature")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarsFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            Feature = "Aire acondicionado"
                        },
                        new
                        {
                            Id = 2,
                            CarId = 1,
                            Feature = "Frenos ABS"
                        },
                        new
                        {
                            Id = 3,
                            CarId = 2,
                            Feature = "Sistema de navegación GPS"
                        },
                        new
                        {
                            Id = 4,
                            CarId = 3,
                            Feature = "Cámara de reversa"
                        },
                        new
                        {
                            Id = 5,
                            CarId = 4,
                            Feature = "Control de crucero"
                        });
                });

            modelBuilder.Entity("BackendConcesionario.Models.CarImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsPrimaryImage")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarsImagens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            ImageUrl = "https://images.example.com/corolla-front.jpg",
                            IsPrimaryImage = true
                        },
                        new
                        {
                            Id = 2,
                            CarId = 1,
                            ImageUrl = "https://images.example.com/corolla-side.jpg",
                            IsPrimaryImage = false
                        },
                        new
                        {
                            Id = 3,
                            CarId = 2,
                            ImageUrl = "https://images.example.com/civic-front.jpg",
                            IsPrimaryImage = true
                        },
                        new
                        {
                            Id = 4,
                            CarId = 3,
                            ImageUrl = "https://images.example.com/ranger-front.jpg",
                            IsPrimaryImage = true
                        },
                        new
                        {
                            Id = 5,
                            CarId = 4,
                            ImageUrl = "https://images.example.com/cruze-front.jpg",
                            IsPrimaryImage = true
                        });
                });

            modelBuilder.Entity("BackendConcesionario.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Cuit_Cuil")
                        .HasColumnType("int");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name_or_CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Calle Falsa 123, Rosario",
                            Cuit_Cuil = 0,
                            Dni = "12345678",
                            Email = "juan.perez@email.com",
                            Name_or_CompanyName = "Juan Pérez",
                            Phone_Number = "3412345678"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Av. Libertador 456, Santa Fe",
                            Cuit_Cuil = 0,
                            Dni = "23456789",
                            Email = "maria.gonzalez@email.com",
                            Name_or_CompanyName = "María González",
                            Phone_Number = "3412345679"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Ruta 11, Km 15, Reconquista",
                            Cuit_Cuil = 0,
                            Dni = "34567890",
                            Email = "carlos.rodriguez@email.com",
                            Name_or_CompanyName = "Carlos Rodríguez",
                            Phone_Number = "3412345680"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Bv. Oroño 789, Santa Fe",
                            Cuit_Cuil = 0,
                            Dni = "45678901",
                            Email = "laura.fernandez@email.com",
                            Name_or_CompanyName = "Laura Fernández",
                            Phone_Number = "3412345681"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Mitre 456, Santo Tomé",
                            Cuit_Cuil = 0,
                            Dni = "56789012",
                            Email = "roberto.sanchez@email.com",
                            Name_or_CompanyName = "Roberto Sánchez",
                            Phone_Number = "3412345682"
                        });
                });

            modelBuilder.Entity("BackendConcesionario.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CarPrice")
                        .HasColumnType("int");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ClientId1")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("SaleDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("ClientId1");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            CarPrice = 4450000,
                            ClientId = "Juan Pérez",
                            PaymentMethod = "",
                            SaleDate = new DateOnly(2024, 1, 15)
                        },
                        new
                        {
                            Id = 2,
                            CarId = 2,
                            CarPrice = 4200000,
                            ClientId = "María González",
                            PaymentMethod = "",
                            SaleDate = new DateOnly(2024, 2, 20)
                        },
                        new
                        {
                            Id = 3,
                            CarId = 3,
                            CarPrice = 6800000,
                            ClientId = "Carlos Rodríguez",
                            PaymentMethod = "",
                            SaleDate = new DateOnly(2024, 3, 10)
                        },
                        new
                        {
                            Id = 4,
                            CarId = 4,
                            CarPrice = 3700000,
                            ClientId = "Laura Fernández",
                            PaymentMethod = "",
                            SaleDate = new DateOnly(2024, 4, 5)
                        },
                        new
                        {
                            Id = 5,
                            CarId = 5,
                            CarPrice = 3900000,
                            ClientId = "Roberto Sánchez",
                            PaymentMethod = "",
                            SaleDate = new DateOnly(2024, 5, 12)
                        });
                });

            modelBuilder.Entity("BackendConcesionario.Models.CarFeature", b =>
                {
                    b.HasOne("BackendConcesionario.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("BackendConcesionario.Models.CarImage", b =>
                {
                    b.HasOne("BackendConcesionario.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("BackendConcesionario.Models.Sale", b =>
                {
                    b.HasOne("BackendConcesionario.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendConcesionario.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId1");

                    b.Navigation("Car");

                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
