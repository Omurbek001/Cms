using System.Reflection;

namespace Cms.EducationPortal;

public static class EducationPortal
{
    public static Assembly GetEducationPortalAssembly()
    {
        return Assembly.GetAssembly(typeof(EducationPortal))!;
    }
}