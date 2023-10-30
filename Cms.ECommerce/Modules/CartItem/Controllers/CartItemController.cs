﻿using Cms.Shared.Shared;
using Cms.Shared.Shared.Models;
using Cms.Shared.Shared.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cms.ECommerce.Modules.CartItem.Controllers;

[ApiController]
[Route("api/v1[controller]")]
public class CartItemController : ControllerBase
{
    private readonly DataContext _dataContext;
    private DbSet<Entities.CartItem> DbSet => _dataContext.Set<Entities.CartItem>();

    public CartItemController(DataContext dataContext)
    {

        _dataContext = dataContext;
    }
    private IQueryable<Entities.CartItem> FilterPredicate(Filter filter, IQueryable<Entities.CartItem> items)
    {
        switch (filter.Name)
        {
            default: return items;
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetList(string?filter, int? pageIndex, int?pageSize, string? orderField, string?orderType)
    {
        try
        {
            var query = DbSet
                .Filter(filter ?? "", FilterPredicate)
                .Sort(orderField ?? "Id", orderType ?? "ASC")
                .Paginate((pageIndex ?? 1), pageSize ?? 30);
            
            var items = await query.ToListAsync();
            var total = query.Count();

            return Ok(new ListResponse<Entities.CartItem>(items, total));
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Entities.CartItem model)
    {
        try
        {
            DbSet.Add(model);
            await _dataContext.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    [HttpGet("scs")]
    public async Task<IActionResult> GetById(long id)
    {
        try
        {
            var item = await DbSet.FirstOrDefaultAsync(p => p.Id==id);
            if (item == null) throw new Exception("Товар не найден ");
            return Ok(item);
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
        
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(long id)
    {
        try
        {
            var item = await DbSet.FirstOrDefaultAsync(p => p.Id == id);
            if (item == null) throw new Exception("Товар не найден ");
            _dataContext.Remove(item);
            await _dataContext.SaveChangesAsync();
            return Ok();

        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }
    
    [HttpPut]
    public async Task<IActionResult> Update(Entities.CartItem model)
    {
        try
        {
            DbSet.Update(model);
            await _dataContext.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
      

    }
    
}