using BlueMusicAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace BlueMusicAPI.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IHost app)
        {        

            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<BlueMusicContext>();
                context.Database.Migrate();

                if (!context.Music.Any())
                {
                    context.Music.Add(new Music { Name = "Aways", Author = "Bon Jovi", Duration = 180, Link = "", CreatedBy = "System" });
                    context.Music.Add(new Music { Name = "Hotel California", Author = "The Eagles", Duration = 360, Link = "", CreatedBy = "System" });
                    context.Music.Add(new Music { Name = "Smells Like Teen Spirity", Author = "Nirvana", Duration = 240, Link = "", CreatedBy = "System" });
                    context.Music.Add(new Music { Name = "Sultans Of Swings", Author = "Dire Straits", Duration = 210, Link = "", CreatedBy = "System" });
                    context.Music.Add(new Music { Name = "Nothing Else Matter", Author = "Metalica", Duration = 0, Link = "", CreatedBy = "System" });
                }

                context.SaveChanges();
            }
        }
    }
}
