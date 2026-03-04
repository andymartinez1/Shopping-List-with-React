namespace ShoppingList.ServiceContracts.DTO;

public class GroceryItemAddRequest
{
    public string? Name { get; set; }

    public DateTime DateAdded { get; set; }

    public bool IsPurchased { get; set; }
}
