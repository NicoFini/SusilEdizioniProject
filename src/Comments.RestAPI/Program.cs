using SunsilEdizioni.Core;
using SunsilEdizioni.Core.Service;
using SunsilEdizioni.DB;

namespace Comments.RestAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors();

            builder.Services.AddControllersWithViews();

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            builder.Services.AddSingleton<StorageServiceUsers, MySqlStorageService>();

            builder.Services.AddSingleton<ApplicationManagerUsers>();

            builder.Services.AddSingleton<StorageServiceBooks, MySqlStorageService>();

            builder.Services.AddSingleton<ApplicationManagerBooks>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}