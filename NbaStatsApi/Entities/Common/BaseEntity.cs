namespace NbaStatsApi.Entities.Common;

public abstract class BaseEntity
{
    public string Id { get; set; } = string.Empty;
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    protected BaseEntity()
    {
        CreatedAt = DateTime.Now;
    }
}
