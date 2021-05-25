using System.Collections.Generic;

namespace TheCraftShop.Models
{
    //Interface, allows the entire application to use handicrafts without knowing how the are presisted (a simple API)
    public interface IHandicraftRepository
    {
        IEnumerable<Handicraft> AllHandicrafts { get; }
        IEnumerable<Handicraft> NewItem { get; }
        IEnumerable<Handicraft> Crochet { get; }
        IEnumerable<Handicraft> Macrame { get; }
        IEnumerable<Handicraft> Drawing { get; }
        Handicraft GetHandicraftById(int handicraftId);
    }
}
