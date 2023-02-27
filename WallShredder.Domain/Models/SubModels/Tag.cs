using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallShredder.Domain.Enums;

namespace WallShredder.Domain.Models.SubModels
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public Purity Purity { get; set; }
    }
}
