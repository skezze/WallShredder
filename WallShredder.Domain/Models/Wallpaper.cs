using WallShredder.Domain.Enums;
using WallShredder.Domain.Models.SubModels;

namespace WallShredder.Domain.Models
{
    public class Wallpaper
    {
        public string Id { get; set; }
        public Uploader Uploader { get; set; }
        public string Url { get; set; }
        public int Views { get; set; }
        public int Favourites { get; set; }
        public string SourceInFS { get; set; }
        public Purity Purity { get; set; }
        public Category Category { get; set; }
        public string Resolution { get; set; }
        public Ratio Ratio { get; set; }
        public int FileSize { get; set; }
        public FileType FileType { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
