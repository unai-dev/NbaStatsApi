using NbaStatsApi.Features.Common;
using NbaWebTools;

namespace NbaStatsApi.Entities;

public class O_Team: BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Abbreviation { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public string Division { get; set; } = string.Empty;
    public int Overall { get; set; }
    public string Logo { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Arena { get; set; } = string.Empty;
    public int Founded { get; set; }
    public int Championships { get; set; }
    public TeamRecord? Record { get; set; } 
    public TeamColors? Colors { get; set; }
    public EConference Conference { get; set; }
}

public enum EConference
{
    East,
    West,
}
