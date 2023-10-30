using System.Text.Json.Serialization;
using Cms.Shared.Shared;
using Cms.Shared.Shared.Entities;

namespace Cms.Shared.Modules.Image.Entities;
 
public class Image : Entity
{
    public string Name { get; set; }
    public string Extension { get; set; }
    public long Size { get; set; }
    public string Alt { get; set; }
    [JsonIgnore]
    public byte[] Data { get; set; }
    protected override int GetClassId() => ClassNames.Image;
}