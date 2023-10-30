using Cms.Shared.Shared;
using Cms.Shared.Shared.Entities;

namespace Cms.ECommerce.Modules.CartItem.Entities;

public class CartItem:Entity
{
    public long CartId { get; set; }
    public Cart.Entities.Cart Cart { get; set; }
    public long CommodityId { get; set; }
    public Commodity.Entities.Commodity Commodity { get; set; }
    public int Count { get; set; }
    protected override int GetClassId() => ClassNames.CartItem;
}