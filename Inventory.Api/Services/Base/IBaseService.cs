using Inventory.Api.Models.Base;

namespace Inventory.Api.Services.Base;

public interface IBaseService<TViewModel, in TCreateModel, in TUpdateModel, in TId>
    where TViewModel : BaseViewModel
    where TCreateModel : BaseCreateModel
    where TUpdateModel : BaseUpdateModel
{
    Task<TViewModel> CreateAsync(TCreateModel model);
    Task<TViewModel> GetAsync(TId id);
    Task<IEnumerable<TViewModel>> GetAllAsync();
    Task<TViewModel> UpdateAsync(TId id, TUpdateModel model);
    Task<TViewModel> DeleteAsync(TId id);
}