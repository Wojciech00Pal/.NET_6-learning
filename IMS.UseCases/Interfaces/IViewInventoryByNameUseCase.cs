using IMS.CoreBusiness;

namespace IMS.UseCases.Interfaces
{
    public interface IViewInventoryByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}