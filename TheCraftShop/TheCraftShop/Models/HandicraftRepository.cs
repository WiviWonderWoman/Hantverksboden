using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace TheCraftShop.Models
{
    public class HandicraftRepository : IHandicraftRepository
    {
        //local field for AppDbContext
        private readonly AppDbContext _appDbContext;

        //constructor
        public HandicraftRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Implementation of the interface
        public IEnumerable<Handicraft> AllHandicrafts
        {
            get
            {
                return _appDbContext.Handicrafts.Include(c => c.CraftMethod);
            }
        }
        public IEnumerable<Handicraft> NewItem
        {
            get
            {
                return _appDbContext.Handicrafts.Include(c => c.CraftMethod).Where(h => h.IsNewItem);
            }
        }
        public IEnumerable<Handicraft> Crochet
        {
            get
            {
                return _appDbContext.Handicrafts.Include(c => c.CraftMethod).Where(h => h.CraftMethodId == 1);
            }
        }

        public IEnumerable<Handicraft> Macrame
        {
            get
            {
                return _appDbContext.Handicrafts.Include(c => c.CraftMethod).Where(h => h.CraftMethodId == 2);
            }
        }

        public IEnumerable<Handicraft> Drawing
        {
            get
            {
                return _appDbContext.Handicrafts.Include(c => c.CraftMethod).Where(h => h.CraftMethodId == 3);
            }
        }

        //makes it possible to find an view a specific handicraft
        public Handicraft GetHandicraftById(int handicraftId)
        {
            return _appDbContext.Handicrafts.FirstOrDefault(h => h.HandicraftId == handicraftId);
        }

    }
}
