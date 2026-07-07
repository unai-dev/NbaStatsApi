namespace NbaStatsApi.Entities;

public class Team
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Abbreviation { get; set; }
    public string Slug { get; set; }
    public string Division { get; set; }
    public int Overall { get; set; }
    public string Logo { get; set; }
    public string Url { get; set; }
    public string Arena { get; set; }
    public int Founded { get; set; }
    public int Championships { get; set; }
    public TeamRecord Record { get; set; }
    public TeamColors Colors { get; set; }
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
    public string Primary { get; set; }
    public string Secondary { get; set; }
}
