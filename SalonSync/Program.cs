using SalonSync.BLL.Interfaces;
using SalonSync.DAL.Services;
using SalonSync.DAL.Repositories.Interfaces;
using SalonSync.BLL.Services;

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
//BLL
builder.Services.AddScoped<IPlageHoraireService, SalonSync.BLL.Services.PlageHoraireService>();
//DAL
builder.Services.AddScoped<IPlageHoraireRepository, PlageHoraireRepository>(sp =>
    new PlageHoraireRepository(
        new System.Data.SqlClient.SqlConnection(
            builder.Configuration.GetConnectionString("default"))));

//BLL
builder.Services.AddScoped<ICoiffeurService, CoiffeurService>();
//DAL
builder.Services.AddScoped<ICoiffeurRepository, CoiffeurRepository>(sp =>
    new CoiffeurRepository(
        new System.Data.SqlClient.SqlConnection(
            builder.Configuration.GetConnectionString("default"))));


//BLL
builder.Services.AddScoped<ICalendrierService, CalendrierService>();
//DAL
builder.Services.AddScoped<ICalendrierRepository, CalendrierRepository>(sp =>
    new CalendrierRepository(
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
