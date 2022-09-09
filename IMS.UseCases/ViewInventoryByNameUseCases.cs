using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class ViewInventoryByNameUseCases : IViewInventoryByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoryByNameUseCases(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await this.inventoryRepository.GetInventoriesByName(name);
        }

    }
}