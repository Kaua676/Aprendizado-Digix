using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Builder; 
// dotnet add package Microsoft.AspnetCore.Hosting 
// dotnet add package Microsoft.Extensions.Hosting 
// dotnet add package Microsoft.AspnetCore.App
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;



namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Builder = WebApplication.CreateBuilder(args);
            var app = Builder.Build();

            app.UseStaticFiles(); // Para poder habilitar arquivos estaticos

            app.UseRouting();

            // Para definir as rotas
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    context.Response.Redirect("/index.html");
                });
            });

            app.Run();
        }
    }
}