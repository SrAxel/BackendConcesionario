using BackendConcesionario.DataContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();
string cadenaConexion = configuration.GetConnectionString("mysqlremoto");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<ConcesionarioContext>(
    options => options.UseMySql(cadenaConexion,
                                ServerVersion.AutoDetect(cadenaConexion),
                    options => options.EnableRetryOnFailure(
                                        maxRetryCount: 5,
                                        maxRetryDelay: System.TimeSpan.FromSeconds(30),
                                       errorNumbersToAdd: null)
                                ));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
