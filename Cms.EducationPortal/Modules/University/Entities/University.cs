using Cms.Shared.Shared.Entities;

namespace Cms.EducationPortal.Modules.University.Entities;

public class University : Entity
{
    public string Name { get; set; }
    protected override int GetClassId() => 6;
}