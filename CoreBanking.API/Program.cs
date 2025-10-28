using CoreBanking.Domain.Interfaces;
using CoreBanking.Infrastructure.Repositories;
using CoreBanking.Domain.Interfaces;
using CoreBanking.Infrastructure.Repositories;

namespace CoreBanking.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Register dependencies (DI)
            builder.Services.AddScoped<IAccountRepository, AccountRepository>();

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
