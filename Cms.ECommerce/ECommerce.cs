using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Cms.ECommerce;

public static class ECommerce
{
    public static Assembly GetECommerceAssembly()
    {
        return Assembly.GetAssembly(typeof(ECommerce))!;
    }
}