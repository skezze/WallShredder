using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallShredder.Domain.Models;

namespace WallShredder.Db
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {}
        public DbSet<Wallpaper> Wallpapers { get; set; }
        public DbSet<User>  Users { get; set; }
    }
}
