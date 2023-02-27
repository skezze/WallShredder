using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WallShredder.Db;
using WallShredder.Domain.Models;

namespace WallShredder.API.Controllers
{
    [ApiController]
    public class WallpaperController
    {
        private ApplicationDbContext _context;

        public WallpaperController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("/")]
        public async Task<List<Wallpaper>> getWallpapers() {
            return await _context.Wallpapers.ToListAsync();
        }
        [HttpPost("/")]
        public IResult createWallpaper([FromBody] Wallpaper wallpaper)
        {
            _context.Wallpapers.Add(wallpaper);
            _context.SaveChanges();
            return Results.Ok(wallpaper);

        }
    }
}
