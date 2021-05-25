using System.Collections.Generic;

namespace TheCraftShop.Models
{
    //Interface, allows the entire application to use crafting methods without knowing how the are presisted (a simple API)
    public interface ICraftMethodRepository
    {
        IEnumerable<CraftMethod> AllCraftMethods { get; }
    }
}
