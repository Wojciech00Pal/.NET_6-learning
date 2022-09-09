using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly IMSContext db;

        public InventoryRepository(IMSContext db)
        {
            this.db = db;
        }

      
        public async  Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
             return  this.db.Inventories.Where(x=>x.InventoryName.Contains(name)||
              string.IsNullOrWhiteSpace(name)).ToList();
        }
    }
}