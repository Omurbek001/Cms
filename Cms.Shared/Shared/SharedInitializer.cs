using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Cms.Shared.Shared;

public class SharedInitializer : IInitializer
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly DataContext _dataContext;

    public SharedInitializer(DataContext dataContext, RoleManager<IdentityRole> roleManager)
    {
        _dataContext = dataContext;
        _roleManager = roleManager;
    }

    public async Task Initialize()
    {
        var administrator = await _roleManager.Roles.ToListAsync();
        if (administrator.Exists(r => r.Name == "Administrator"))
        {
            return;
        }
        
        var roles = new List<IdentityRole>()
        {
            new()
            {
                Name = "Administrator",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            }
        };

        foreach (var role in roles)
        {
            await _roleManager.CreateAsync(role);
        }

        await _dataContext.SaveChangesAsync();
    }
}