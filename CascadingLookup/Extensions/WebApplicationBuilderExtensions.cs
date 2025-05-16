using CascadingLookup.Data;
using CascadingLookup.Data.Seed;
using Microsoft.EntityFrameworkCore;

namespace CascadingLookup.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static WebApplication BuildAndConfigureRequestPipeline(this WebApplicationBuilder builder)
        {
            var app = builder.Build();

            app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>().Database.Migrate();
            DbInitializer.Seed(app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>());

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Lookup}/{action=Index}/{id?}");

            return app;
        }
    }
}