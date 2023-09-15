using Cms.Shared.Entities;

namespace Cms.ECommerce.Entities;

public class Order : Entity
{
    public string Caption { get; set; }
    public string Description { get; set; }
    protected override int GetClassId() => 5;
}