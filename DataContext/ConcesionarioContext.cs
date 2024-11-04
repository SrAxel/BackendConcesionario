//using BackendConcesionario.Models;

using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;
using BackendConcesionario.Models;

namespace BackendConcesionario.DataContext
{
    public class ConcesionarioContext : DbContext
    {
        public ConcesionarioContext(DbContextOptions<ConcesionarioContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string cadenaConexion = configuration.GetConnectionString("mysqlremoto");

            //optionsBuilder.UseSqlServer(cadenaConexion) ;
            optionsBuilder.UseMySql(cadenaConexion,
                                    ServerVersion.AutoDetect(cadenaConexion));
        }

        //ESTE CÓDIGO LO DEBEN AGREGAR A LA CLASE DBCONTEXT DESPUÉS DE HABER CREADO EL MODELO MATERIA
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarFeature> CarsFeatures { get; set; }
        public virtual DbSet<CarImage> CarsImagens { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Datos semilla para el modelo Car
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Make = "Toyota", Model = "Corolla", Year = 2023, Price = 4500000, Status = "New", Stock = 5, Description = "Sedán con gran eficiencia de combustible." },
                new Car { Id = 2, Make = "Honda", Model = "Civic", Year = 2022, Price = 4200000, Status = "New", Stock = 3, Description = "Deportivo con diseño aerodinámico." },
                new Car { Id = 3, Make = "Ford", Model = "Ranger", Year = 2023, Price = 6800000, Status = "Used", Stock = 2, Description = "Camioneta de alta resistencia." },
                new Car { Id = 4, Make = "Chevrolet", Model = "Cruze", Year = 2021, Price = 3700000, Status = "New", Stock = 4, Description = "Compacto con tecnología avanzada." },
                new Car { Id = 5, Make = "Nissan", Model = "Sentra", Year = 2023, Price = 3900000, Status = "New", Stock = 6, Description = "Sedán cómodo y espacioso." }
            );

            // Datos semilla para el modelo CarImage
            modelBuilder.Entity<CarImage>().HasData(
                new CarImage { Id = 1, CarId = 1, ImageUrl = "https://images.example.com/corolla-front.jpg", IsPrimaryImage = true },
                new CarImage { Id = 2, CarId = 1, ImageUrl = "https://images.example.com/corolla-side.jpg", IsPrimaryImage = false },
                new CarImage { Id = 3, CarId = 2, ImageUrl = "https://images.example.com/civic-front.jpg", IsPrimaryImage = true },
                new CarImage { Id = 4, CarId = 3, ImageUrl = "https://images.example.com/ranger-front.jpg", IsPrimaryImage = true },
                new CarImage { Id = 5, CarId = 4, ImageUrl = "https://images.example.com/cruze-front.jpg", IsPrimaryImage = true }
            );

            // Datos semilla para el modelo CarFeature
            modelBuilder.Entity<CarFeature>().HasData(
                new CarFeature { Id = 1, CarId = 1, Feature = "Aire acondicionado" },
                new CarFeature { Id = 2, CarId = 1, Feature = "Frenos ABS" },
                new CarFeature { Id = 3, CarId = 2, Feature = "Sistema de navegación GPS" },
                new CarFeature { Id = 4, CarId = 3, Feature = "Cámara de reversa" },
                new CarFeature { Id = 5, CarId = 4, Feature = "Control de crucero" }
            );

            // Datos semilla para el modelo Sale
            modelBuilder.Entity<Sale>().HasData(
                new Sale { Id = 1, CarId = 1, SaleDate = new DateOnly(2024, 01, 15), ClientId = "Juan Pérez", CarPrice = 4450000 },
                new Sale { Id = 2, CarId = 2, SaleDate = new DateOnly(2024, 02, 20), ClientId = "María González", CarPrice = 4200000 },
                new Sale { Id = 3, CarId = 3, SaleDate = new DateOnly(2024, 03, 10), ClientId = "Carlos Rodríguez", CarPrice = 6800000 },
                new Sale { Id = 4, CarId = 4, SaleDate = new DateOnly(2024, 04, 05), ClientId = "Laura Fernández", CarPrice = 3700000 },
                new Sale { Id = 5, CarId = 5, SaleDate = new DateOnly(2024, 05, 12), ClientId = "Roberto Sánchez", CarPrice = 3900000 }
            );

            // Datos semilla para el modelo Customer
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, Name_or_CompanyName = "Juan Pérez", Dni = "12345678", Email = "juan.perez@email.com", Phone_Number = "3412345678", Address = "Calle Falsa 123, Rosario" },
                new Client { Id = 2, Name_or_CompanyName = "María González", Dni = "23456789", Email = "maria.gonzalez@email.com", Phone_Number = "3412345679", Address = "Av. Libertador 456, Santa Fe" },
                new Client { Id = 3, Name_or_CompanyName = "Carlos Rodríguez", Dni = "34567890", Email = "carlos.rodriguez@email.com", Phone_Number = "3412345680", Address = "Ruta 11, Km 15, Reconquista" },
                new Client { Id = 4, Name_or_CompanyName = "Laura Fernández", Dni = "45678901", Email = "laura.fernandez@email.com", Phone_Number = "3412345681", Address = "Bv. Oroño 789, Santa Fe" },
                new Client { Id = 5, Name_or_CompanyName = "Roberto Sánchez", Dni = "56789012", Email = "roberto.sanchez@email.com", Phone_Number = "3412345682", Address = "Mitre 456, Santo Tomé" }
            );

            base.OnModelCreating(modelBuilder);


        }
    }
}
