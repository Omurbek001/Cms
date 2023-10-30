using Cms.ECommerce.Modules.Cart.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cms.ECommerce.Modules.Cart.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CartController : ControllerBase
{
    private readonly CartService _cartService;

    public CartController(CartService cartService)
    {
        _cartService = cartService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCart()
    {
        var result = await _cartService.GetCart();
        return Ok(result);
    }
}