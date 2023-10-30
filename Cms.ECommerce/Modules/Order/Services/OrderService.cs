using System.Reflection;
using Cms.Shared.Shared;
using Microsoft.EntityFrameworkCore;

namespace Cms.ECommerce.Modules.Order.Services;

public class OrderService
{
    private readonly DataContext _dataContext;

    public OrderService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }
    public async Task<Entities.Order> CreateOrder(Entities.Order order, long cartId)
    {
        var cart = _dataContext.Set<Cart.Entities.Cart>().Include(i => i.Items).FirstOrDefault(i => i.Id == cartId);
       
        if (cart == null) throw new NullReferenceException("Неправильный Id");
       
        if (cart.Items.Count == 0) throw new Exception("Корзинка пустая");
       
        order.Items = cart.Items.Select(i => new OrderItem.Entities.OrderItem
            { CommodityId = i.CommodityId, Count = i.Count }).ToList();
       

        _dataContext.Set<Entities.Order>().Add(order);

        await _dataContext.SaveChangesAsync();
       
        _dataContext.Set<CartItem.Entities.CartItem>().RemoveRange(cart.Items);

        await _dataContext.SaveChangesAsync();
        
        return order;
    }
}