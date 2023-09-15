using Cms.Shared.Entities;

namespace Cms.EducationPortal.Entities;

public class University : Entity
{
    public string Name { get; set; }
    protected override int GetClassId() => 6;
}