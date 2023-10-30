using Cms.Shared.Shared;
using Cms.Shared.Shared.Entities;

namespace Cms.ECommerce.Modules.Category.Entities;

public class Category:Entity
{
    public string Caption { get; set; }
    public string Description { get; set; }
    protected override int GetClassId() => ClassNames.Category;
}