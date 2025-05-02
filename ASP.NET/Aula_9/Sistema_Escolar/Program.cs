using Microsoft.EntityFrameworkCore;
using Sistema_Escolar.DB;
using Sistema_Escolar.DTO;
using Sistema_Escolar.Models;
using FluentValidation.AspNetCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;

// Comandos para realizar migrations
// dotnet ef migrations add InitialCreate
// dotnet ef database update



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sistema Escolar", Version = "v1" });
});

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseDefaultFiles(); 
app.UseStaticFiles();
app.UseAuthorization();
app.MapControllers();
app.Run();