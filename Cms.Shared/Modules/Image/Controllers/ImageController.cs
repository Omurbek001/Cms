using Cms.Shared.Modules.Image.Services;
using Cms.Shared.Shared;
using Cms.Shared.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cms.Shared.Modules.Image.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class OrderController : ControllerBase
{
    private readonly DataContext _dataContext;
    private readonly ImageService _imageService;

    public OrderController(DataContext dataContext,ImageService imageService)
    {
        _dataContext = dataContext;
        _imageService = imageService;
    }

    private DbSet<Entities.Image> DataSet => _dataContext.Set<Entities.Image>();

    [HttpGet]
    public async Task<IActionResult> GetList(long id,bool download = false)
    {
        try
        {
            var result = await _imageService.GetAsync<Entities.Image>(id, download);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }

    [HttpGet("{id:long}")]
    public async Task<IActionResult> GetById(long id)
    {
        try
        {
            var model = await DataSet
                .FirstOrDefaultAsync(e => e.Id == id);

            if (model == null) throw new Exception("Товар не найден");

            return Ok(model);
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }
    
    [HttpPost]                       
    public async Task<IActionResult> Add(IFormFile file)
    {
        try
        {

            var model = new Entities.Image()
            {
                Name = file.FileName,
                Size = file.Length,
                
            };
            var result = await _imageService.SaveAsync(model,file);

            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }
    
    [HttpPut]
    public async Task<IActionResult> Update(Entities.Image model)
    {
        try
        {
            DataSet.Update(model);
            await _dataContext.SaveChangesAsync();
            return Ok(model);
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }
    
    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Delete(long id)
    {
        try
        {
            var model = await DataSet
                .FirstOrDefaultAsync(e => e.Id == id);
            
            if (model == null) throw new Exception("Товар не найден");
            
            DataSet.Remove(model);
            
            await _dataContext.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }
}