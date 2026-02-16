using Microsoft.AspNetCore.Mvc;
using ShoppingList.ServiceContracts;

namespace ShoppingList.Controllers;

public class ShoppingListController : Controller
{
    private readonly IGroceryService _groceryService;

    public ShoppingListController(IGroceryService groceryService)
    {
        _groceryService = groceryService;
    }
}