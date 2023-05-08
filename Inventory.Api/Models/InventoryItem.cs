using Inventory.Api.Models.Base;
using MongoDB.Bson.Serialization.Attributes;

namespace Inventory.Api.Models;
public class InventoryItem : BaseModel
{
    [BsonId]
    public string Id { get; set; } = null!;
    
    public string Name { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public string Category { get; set; } = null!;
    
    public int Quantity { get; set; }
    
    public decimal Price { get; set; }
}

public class InventoryItemCreateModel : BaseCreateModel
{
    public string Name { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public string Category { get; set; } = null!;
    
    public int Quantity { get; set; }
    
    public decimal Price { get; set; }
}

public class InventoryItemViewModel : BaseViewModel
{
    public string Id { get; set; } = null!;
    
    public string Name { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public string Category { get; set; } = null!;
    
    public int Quantity { get; set; }
    
    public decimal Price { get; set; }
}

public class InventoryItemUpdateModel : BaseUpdateModel
{
    public string Name { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public string Category { get; set; } = null!;
    
    public int Quantity { get; set; }
    
    public decimal Price { get; set; }
}