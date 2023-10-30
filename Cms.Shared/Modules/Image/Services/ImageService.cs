using Cms.Shared.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Shared.Modules.Image.Services;

public class ImageService
{
    private readonly DataContext _dataContext;

    public ImageService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<TFileClass> SaveAsync<TFileClass>(TFileClass model, IFormFile file) where TFileClass : Entities.Image, new()
    {
        using var ms = new MemoryStream();
        await file.CopyToAsync(ms);
        model.Data = ms.ToArray();
        await _dataContext.Set<TFileClass>().AddAsync(model);
        return model;
    }

    public async Task<FileContentResult> GetAsync<TFileClass>(long? id, bool download = false) where TFileClass : Entities.Image, new()
    {
        var file = await _dataContext.Set<TFileClass>().FindAsync(id);
        if (file?.Data == null) throw new NullReferenceException("Файл повреждён");
        return download 
            ? new FileContentResult(file.Data, "image/jpg") { FileDownloadName = file.Name }
            : new FileContentResult(file.Data, "image/jpg");
    }
}