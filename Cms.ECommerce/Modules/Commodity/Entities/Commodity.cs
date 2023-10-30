using Cms.Shared.Modules.Image.Entities;
using Cms.Shared.Shared;
using Cms.Shared.Shared.Entities;

namespace Cms.ECommerce.Modules.Commodity.Entities;

public class Commodity : Entity
{
    public string Caption { get; set; } 
    public string Description { get; set; }
    public int Weight { get; set; }
    public int Price { get; set; }
    public string? WeightUnit { get; set; }
    public int ItemCount { get; set; }
    public long? ImageId { get; set; }
    public Image? Image { get; set; }
    protected override int GetClassId() => ClassNames.Commodity;
}