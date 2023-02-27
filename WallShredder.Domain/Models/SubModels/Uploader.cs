using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WallShredder.Domain.Models.SubModels
{
    [Keyless] 
    [NotMapped]
    public class Uploader
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string AvatarInFS { get; set; }
    }
}
