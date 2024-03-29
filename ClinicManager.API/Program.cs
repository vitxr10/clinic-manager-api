using ClinicManager.Core.Repository;
using ClinicManager.Infrastructure.Persistence.Context;
using ClinicManager.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Context
builder.Services.AddDbContext<ClinicManagerDbContext>(options => options.UseInMemoryDatabase("ClinicManagerDb"));

// Interfaces
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();

// MediatR
var myHandlers = AppDomain.CurrentDomain.Load("ClinicManager.Application");
builder.Services.AddMediatR(m => m.RegisterServicesFromAssemblies(myHandlers));

var app = builder.Build();

app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

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
