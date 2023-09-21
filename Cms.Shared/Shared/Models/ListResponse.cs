namespace Cms.Shared.Shared.Models;

public class ListResponse<TType>
{
    public ListResponse(IEnumerable<TType> items, long? total)
    {
        Items = items;
        Total = total;
    }

    public IEnumerable<TType> Items { get; set; } = new List<TType>();
    public long? Total { get; set; }
}