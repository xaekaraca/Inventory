using Inventory.Api.Models;
using Inventory.Api.Models.Base;
using Inventory.Api.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Inventory.Api.Services;

public class MongoService
{
    private readonly IMongoCollection<InventoryItem> _inventoryCollection;

    public MongoService(IOptions<MongoSettings> settings)
    {
        var mongoClient = new MongoClient(settings.Value.ConnectionString);
        
        var database = mongoClient.GetDatabase(settings.Value.DatabaseName);
        
        _inventoryCollection = database.GetCollection<InventoryItem>(settings.Value.InventoryCollection);
    }
    
    public async Task<List<InventoryItem>> GetInventoryItemAsync() =>
        await _inventoryCollection.Find(_ => true).ToListAsync();
    
    public async Task<InventoryItem> GetInventoryItemByIdAsync(string id) =>
        await _inventoryCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    
    public async Task InsertInventoryItemAsync(InventoryItem model) =>
        await _inventoryCollection.InsertOneAsync(model);
    
    public async Task UpdateInventoryItemAsync(string id, InventoryItem model) =>
        await _inventoryCollection.ReplaceOneAsync(x => x.Id == id, model);

    public async Task RemoveInventoryItemAsync(string id)
    {
        var entity = await _inventoryCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        entity.IsDeleted = true;
        await _inventoryCollection.ReplaceOneAsync(x => x.Id == id, entity);
    }
}