using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MyAppBackend
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Add CORS configuration to allow the frontend app
            services.AddCors(options =>
            {
                options.AddPolicy("AllowReactApp",
                    builder =>
                    {
                        // Replace with the actual URL of your React app
                        builder.WithOrigins("http://localhost:5174")  // React's local development server
                               .AllowAnyHeader()
                               .AllowAnyMethod()
                               .AllowCredentials();  // Allow credentials if needed
                    });
            });

            services.AddControllers(); // Add support for controllers
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable CORS
            app.UseCors("AllowReactApp");

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Map the controllers for API routes
            });
        }
    }
}
