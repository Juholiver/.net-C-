using API_2.Models;
using API_2.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<_DbContext>(x => x.UseMySql(
                builder.Configuration.GetConnectionString("DefaultConnection"),
                ServerVersion.Parse("8.0.31")
                ));

            builder.Services.AddScoped<IPessoasRepository, PessoasRepository>();
            builder.Services.AddScoped<IContatosRepository, ContatosRepository>();

            
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}