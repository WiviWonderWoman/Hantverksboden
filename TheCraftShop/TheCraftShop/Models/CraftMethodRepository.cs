using System.Collections.Generic;

namespace TheCraftShop.Models
{
    public class CraftMethodRepository : ICraftMethodRepository
    {
        //local field for AppDbContext
        private readonly AppDbContext _appDbContext;

        //constructor
        public CraftMethodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Implementation of the interface
        public IEnumerable<CraftMethod> AllCraftMethods
        {
            get
            {
                return _appDbContext.CraftMethods;
            }
        }
    }
}
