using NbaWebTools;
namespace NbaStatsApi.Features.Player.Entities;

public class O_Player: BaseEntity
{
    public string Height { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public int Overall { get; set; } 
    public string Img { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Team { get; set; } = string.Empty;
    public List<string> Positions { get; set; } = new List<string>();
    public string Weight { get; set; } = string.Empty;
    public Badge? Badges { get; set; } 
    public string Archetype { get; set; } = string.Empty;
}

