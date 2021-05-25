using System.Collections.Generic;
using TheCraftShop.Models;

namespace TheCraftShop.ViewModels
{
    public class HandicraftListViewModel
    {
        public IEnumerable<Handicraft> Handicrafts { get; set; }
        public IEnumerable<Handicraft> CrochetItems { get; set; }

    }
}
