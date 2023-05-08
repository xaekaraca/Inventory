using Inventory.Api.Models;
using Inventory.Api.Services.Base;

namespace Inventory.Api.Services;

public class InventoryItemService : BaseService<InventoryItemViewModel,InventoryItemCreateModel,InventoryItemUpdateModel,string>
{
    public InventoryItemService(MongoService mongoService) : base(mongoService)
    {
        
    }
    public override Task<InventoryItemViewModel> CreateAsync(InventoryItemCreateModel model)
    {
        return base.CreateAsync(model);
    }

    public override Task<InventoryItemViewModel> GetAsync(string id)
    {
        return base.GetAsync(id);
    }

    public override Task<IEnumerable<InventoryItemViewModel>> GetAllAsync()
    {
        return base.GetAllAsync();
    }

    public override Task<InventoryItemViewModel> UpdateAsync(string id, InventoryItemUpdateModel model)
    {
        return base.UpdateAsync(id, model);
    }

    public override Task<InventoryItemViewModel> DeleteAsync(string id)
    {
        return base.DeleteAsync(id);
    }

    public override void BeforeCreate()
    {
        throw new NotImplementedException();
    }

    public override void BeforeGet()
    {
        throw new NotImplementedException();
    }

    public override void BeforeGetAll()
    {
        throw new NotImplementedException();
    }

    public override void BeforeUpdate()
    {
        throw new NotImplementedException();
    }

    public override void BeforeDelete()
    {
        throw new NotImplementedException();
    }

    public override void AfterCreate()
    {
        throw new NotImplementedException();
    }

    public override void AfterGet()
    {
        throw new NotImplementedException();
    }

    public override void AfterGetAll()
    {
        throw new NotImplementedException();
    }

    public override void AfterUpdate()
    {
        throw new NotImplementedException();
    }

    public override void AfterDelete()
    {
        throw new NotImplementedException();
    }
    
}