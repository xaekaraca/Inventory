using Inventory.Api.Models.Base;

namespace Inventory.Api.Services.Base;

public abstract class BaseService<TViewModel, TCreateModel, TUpdateModel, TId> : IBaseService<TViewModel, TCreateModel, TUpdateModel, TId>
    where TCreateModel : BaseCreateModel
    where TViewModel : BaseViewModel
    where TUpdateModel : BaseUpdateModel
{
    private readonly MongoService _mongoService;

    protected BaseService(MongoService mongoService)
    {
        _mongoService = mongoService;
    }

    public virtual Task<TViewModel> CreateAsync(TCreateModel model)
    {
        throw new NotImplementedException();
    }

    public virtual Task<TViewModel> GetAsync(TId id)
    {
        throw new NotImplementedException();
    }

    public virtual Task<IEnumerable<TViewModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public virtual Task<TViewModel> UpdateAsync(TId id, TUpdateModel model)
    {
        throw new NotImplementedException();
    }

    public virtual Task<TViewModel> DeleteAsync(TId id)
    {
        throw new NotImplementedException();
    }
    
    public abstract void BeforeCreate();
    
    public abstract void BeforeGet();
    
    public abstract void BeforeGetAll();
    
    public abstract void BeforeUpdate();
    
    public abstract void BeforeDelete();
    
    public abstract void AfterCreate();
    
    public abstract void AfterGet();
    
    public abstract void AfterGetAll();
    
    public abstract void AfterUpdate();
    
    public abstract void AfterDelete();
}