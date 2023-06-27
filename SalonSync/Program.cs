using SalonSync.BLL.Interfaces;
using SalonSync.DAL.Services;
using SalonSync.DAL.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();


builder.Services.AddCors(o => o.AddPolicy("angular", option =>
            option.WithOrigins("http://localhost:4200")
                    .AllowCredentials()
                    .AllowAnyMethod()
                    .AllowAnyHeader()));

builder.Services.AddScoped<IPlageHoraireService, SalonSync.BLL.Services.PlageHoraireService>();
builder.Services.AddScoped<IPlageHoraireRepository, PlageHoraireService>(sp =>
    new PlageHoraireService(
        new System.Data.SqlClient.SqlConnection(
            builder.Configuration.GetConnectionString("default"))));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
