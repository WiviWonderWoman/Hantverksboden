using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheCraftShop.Models
{
    // domain class for all handicrafts
    public class Handicraft
    {
        public int HandicraftId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int CraftMethodId { get; set; }
        public CraftMethod CraftMethod { get; set; }
        public bool IsNewItem { get; set; }
    }
}
