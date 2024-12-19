using MongoDB.Driver;
using VSLinkShortener_Backend.Config;
using VSLinkShortener_Backend.Repositories;
using VSLinkShortener_Backend.Services;

namespace VSLinkShortener_Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbSettings"));
            
            builder.Services.AddSingleton<IMongoClient>(sp =>
                new MongoClient(builder.Configuration.GetValue<string>("MongoDbSettings:ConnectionString")));
            
            builder.Services.AddScoped<IUrlRepository, UrlRepository>();
            
            builder.Services.AddScoped<UrlService>();


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
