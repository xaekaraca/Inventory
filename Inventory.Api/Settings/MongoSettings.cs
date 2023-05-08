namespace Inventory.Api.Settings;

public class MongoSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;
    
    public string InventoryCollection { get; set; } = null!;
}