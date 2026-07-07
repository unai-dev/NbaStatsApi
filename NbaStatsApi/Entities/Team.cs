namespace NbaStatsApi.Entities;

public class Team
{
    public string Id { get; set; } = string.Empty;
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
    public Conference Conference { get; set; }
}

public enum Conference
{
    East,
    West
}

public class TeamRecord
{
    public int Wins { get; set; }
    public int Losses { get; set; }
}

public class TeamColors
{
    public string Primary { get; set; } = string.Empty;
    public string Secondary { get; set; } = string.Empty;
}
