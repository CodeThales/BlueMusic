using BlueMusicAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueMusicAPI.Data
{
    public class BlueMusicContext : IdentityDbContext
    {
        public BlueMusicContext(DbContextOptions<BlueMusicContext> options) : base(options) { }
        public DbSet<Music> Music { get; set; }

    }
}
