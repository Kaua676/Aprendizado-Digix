using Microsoft.EntityFrameworkCore;
using Sistema_Escolar.DB;
using Sistema_Escolar.DTO;
using Sistema_Escolar.Models;
using FluentValidation.AspNetCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Adiciona controllers, endpoints e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sistema Escolar", Version = "v1" });
});

// Configuração do banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"))
);

// Lê a chave JWT do appsettings.json
var jwtKey = builder.Configuration["Jwt:Key"];

// Configuração da autenticação JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtKey))
        };
    });

var app = builder.Build();

// Pipeline do app
app.UseSwagger();
app.UseSwaggerUI();

// Redirecionamento para o front end
app.UseAuthentication();
app.UseAuthorization();

// Arquivos estáticos
app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();

app.MapGet("/", context =>
{
    context.Response.Redirect("/index.html");
    return Task.CompletedTask;
}
);

app.MapControllers();
app.Run();
