using ShoppingList.ServiceContracts;
using ShoppingList.ServiceContracts.DTO;

namespace ShoppingList.Services;

public class GroceryService : IGroceryService
{
    public async Task<GroceryItemResponse> AddAsync(GroceryItemAddRequest? addRequest)
    {
        throw new NotImplementedException();
    }

    public async Task<List<GroceryItemResponse>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<GroceryItemResponse> GetById(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<GroceryItemResponse> UpdateAsync(GroceryItemUpdateRequest? updateRequest)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteAsync(int? id)
    {
        throw new NotImplementedException();
    }
}