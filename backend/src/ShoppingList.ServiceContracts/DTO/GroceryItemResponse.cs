namespace ShoppingList.ServiceContracts.DTO;

public class GroceryItemResponse
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Quantity { get; set; }

    public DateTime DateAdded { get; set; }

    public bool IsPurchased { get; set; }
}