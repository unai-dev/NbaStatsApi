using NbaStatsApi.Entities;

namespace NbaStatsApi.Data;

public static class MOCK_DATA
{
    public static IEnumerable<Player> getPlayers()
    {
        var PLAYERS = new List<Player>()
        {
            new Player
            {
                Id = "lebron_james",
                Name = "LeBron James",
                Slug = "lebron_james",
                Height = "6'9\"",
                Weight = "250 lbs",
                Overall = 97,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/2544.png",
                Url = "https://www.nba.com/player/2544/lebron-james",
                Team = "Los Angeles Lakers",
                Positions = new List<string>{ "SF", "PF" },
                Archetype = "All-Around Superstar",
                Badges = new Badge { Bronze = 10, Silver = 15, Gold = 25, HallOfFame = 12, Legendary = 5, Total = 67 }
            },

            new Player
            {
                Id = "michael_jordan",
                Name = "Michael Jordan",
                Slug = "michael_jordan",
                Height = "6'6\"",
                Weight = "216 lbs",
                Overall = 99,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/893.png",
                Url = "https://www.nba.com/player/893/michael-jordan",
                Team = "Chicago Bulls",
                Positions = new List<string>{ "SG" },
                Archetype = "Elite Scorer",
                Badges = new Badge { Bronze = 5, Silver = 10, Gold = 20, HallOfFame = 15, Legendary = 10, Total = 60 }
            },

            new Player
            {
                Id = "kobe_bryant",
                Name = "Kobe Bryant",
                Slug = "kobe_bryant",
                Height = "6'6\"",
                Weight = "212 lbs",
                Overall = 98,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/977.png",
                Url = "https://www.nba.com/player/977/kobe-bryant",
                Team = "Los Angeles Lakers",
                Positions = new List<string>{ "SG" },
                Archetype = "Two-Way Shot Creator",
                Badges = new Badge { Bronze = 8, Silver = 12, Gold = 22, HallOfFame = 14, Legendary = 7, Total = 63 }
            },

            new Player
            {
                Id = "stephen_curry",
                Name = "Stephen Curry",
                Slug = "stephen_curry",
                Height = "6'3\"",
                Weight = "185 lbs",
                Overall = 97,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/201939.png",
                Url = "https://www.nba.com/player/201939/stephen-curry",
                Team = "Golden State Warriors",
                Positions = new List<string>{ "PG" },
                Archetype = "Sharpshooter",
                Badges = new Badge { Bronze = 6, Silver = 10, Gold = 18, HallOfFame = 12, Legendary = 8, Total = 54 }
            },

            new Player
            {
                Id = "kevin_durant",
                Name = "Kevin Durant",
                Slug = "kevin_durant",
                Height = "6'10\"",
                Weight = "240 lbs",
                Overall = 96,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/201142.png",
                Url = "https://www.nba.com/player/201142/kevin-durant",
                Team = "Phoenix Suns",
                Positions = new List<string>{ "SF", "PF" },
                Archetype = "Scoring Machine",
                Badges = new Badge { Bronze = 7, Silver = 11, Gold = 20, HallOfFame = 10, Legendary = 6, Total = 54 }
            },

            new Player
            {
                Id = "shaquille_oneal",
                Name = "Shaquille O'Neal",
                Slug = "shaquille_oneal",
                Height = "7'1\"",
                Weight = "325 lbs",
                Overall = 98,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/406.png",
                Url = "https://www.nba.com/player/406/shaquille-oneal",
                Team = "Los Angeles Lakers",
                Positions = new List<string>{ "C" },
                Archetype = "Dominant Paint Beast",
                Badges = new Badge { Bronze = 4, Silver = 8, Gold = 18, HallOfFame = 16, Legendary = 10, Total = 56 }
            },

            new Player
            {
                Id = "tim_duncan",
                Name = "Tim Duncan",
                Slug = "tim_duncan",
                Height = "6'11\"",
                Weight = "250 lbs",
                Overall = 97,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/1495.png",
                Url = "https://www.nba.com/player/1495/tim-duncan",
                Team = "San Antonio Spurs",
                Positions = new List<string>{ "PF", "C" },
                Archetype = "Fundamental Two-Way Big",
                Badges = new Badge { Bronze = 5, Silver = 10, Gold = 20, HallOfFame = 12, Legendary = 5, Total = 52 }
            },

            new Player
            {
                Id = "nikola_jokic",
                Name = "Nikola Jokic",
                Slug = "nikola_jokic",
                Height = "6'11\"",
                Weight = "284 lbs",
                Overall = 97,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/203999.png",
                Url = "https://www.nba.com/player/203999/nikola-jokic",
                Team = "Denver Nuggets",
                Positions = new List<string>{ "C" },
                Archetype = "Playmaking Center",
                Badges = new Badge { Bronze = 6, Silver = 12, Gold = 18, HallOfFame = 10, Legendary = 4, Total = 50 }
            },

            new Player
            {
                Id = "luka_doncic",
                Name = "Luka Dončić",
                Slug = "luka_doncic",
                Height = "6'7\"",
                Weight = "230 lbs",
                Overall = 96,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/1629029.png",
                Url = "https://www.nba.com/player/1629029/luka-doncic",
                Team = "Dallas Mavericks",
                Positions = new List<string>{ "PG", "SG" },
                Archetype = "Offensive Maestro",
                Badges = new Badge { Bronze = 5, Silver = 10, Gold = 15, HallOfFame = 8, Legendary = 4, Total = 42 }
            },
            new Player {
                Id = "giannis_antetokounmpo",
                Name = "Giannis Antetokounmpo",
                Slug = "giannis_antetokounmpo",
                Height = "6'11\"",
                Weight = "243 lbs",
                Overall = 97,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/203507.png",
                Url = "https://www.nba.com/player/203507/giannis-antetokounmpo",
                Team = "Milwaukee Bucks",
                Positions = new List<string>{ "PF" },
                Archetype = "Two-Way Slasher",
                Badges = new Badge { Bronze = 6, Silver = 12, Gold = 20, HallOfFame = 10, Legendary = 5, Total = 53 }
            },

            new Player {
                Id = "joel_embiid",
                Name = "Joel Embiid",
                Slug = "joel_embiid",
                Height = "7'0\"",
                Weight = "280 lbs",
                Overall = 97,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/203954.png",
                Url = "https://www.nba.com/player/203954/joel-embiid",
                Team = "Philadelphia 76ers",
                Positions = new List<string>{ "C" },
                Archetype = "Dominant Two-Way Center",
                Badges = new Badge { Bronze = 5, Silver = 10, Gold = 18, HallOfFame = 12, Legendary = 6, Total = 51 }
            },

            new Player {
                Id = "jayson_tatum",
                Name = "Jayson Tatum",
                Slug = "jayson_tatum",
                Height = "6'8\"",
                Weight = "210 lbs",
                Overall = 95,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/1628369.png",
                Url = "https://www.nba.com/player/1628369/jayson-tatum",
                Team = "Boston Celtics",
                Positions = new List<string>{ "SF", "PF" },
                Archetype = "Two-Way Shot Creator",
                Badges = new Badge { Bronze = 6, Silver = 10, Gold = 16, HallOfFame = 8, Legendary = 4, Total = 44 }
            },

            new Player {
                Id = "damian_lillard",
                Name = "Damian Lillard",
                Slug = "damian_lillard",
                Height = "6'2\"",
                Weight = "195 lbs",
                Overall = 94,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/203081.png",
                Url = "https://www.nba.com/player/203081/damian-lillard",
                Team = "Milwaukee Bucks",
                Positions = new List<string>{ "PG" },
                Archetype = "Offensive Shot Creator",
                Badges = new Badge { Bronze = 5, Silver = 10, Gold = 15, HallOfFame = 7, Legendary = 3, Total = 40 }
            },

            new Player {
                Id = "anthony_davis",
                Name = "Anthony Davis",
                Slug = "anthony_davis",
                Height = "6'10\"",
                Weight = "253 lbs",
                Overall = 95,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/203076.png",
                Url = "https://www.nba.com/player/203076/anthony-davis",
                Team = "Los Angeles Lakers",
                Positions = new List<string>{ "PF", "C" },
                Archetype = "Two-Way Interior Force",
                Badges = new Badge { Bronze = 6, Silver = 12, Gold = 18, HallOfFame = 10, Legendary = 4, Total = 50 }
            },

            new Player {
                Id = "kawhi_leonard",
                Name = "Kawhi Leonard",
                Slug = "kawhi_leonard",
                Height = "6'7\"",
                Weight = "225 lbs",
                Overall = 95,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/202695.png",
                Url = "https://www.nba.com/player/202695/kawhi-leonard",
                Team = "Los Angeles Clippers",
                Positions = new List<string>{ "SF" },
                Archetype = "Two-Way Superstar",
                Badges = new Badge { Bronze = 5, Silver = 10, Gold = 18, HallOfFame = 12, Legendary = 5, Total = 50 }
            },

            new Player {
                Id = "jimmy_butler",
                Name = "Jimmy Butler",
                Slug = "jimmy_butler",
                Height = "6'7\"",
                Weight = "230 lbs",
                Overall = 94,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/202710.png",
                Url = "https://www.nba.com/player/202710/jimmy-butler",
                Team = "Miami Heat",
                Positions = new List<string>{ "SF", "SG" },
                Archetype = "Two-Way Leader",
                Badges = new Badge { Bronze = 6, Silver = 10, Gold = 14, HallOfFame = 8, Legendary = 4, Total = 42 }
            },

            new Player {
                Id = "trae_young",
                Name = "Trae Young",
                Slug = "trae_young",
                Height = "6'1\"",
                Weight = "164 lbs",
                Overall = 90,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/1629027.png",
                Url = "https://www.nba.com/player/1629027/trae-young",
                Team = "Atlanta Hawks",
                Positions = new List<string>{ "PG" },
                Archetype = "Offensive Playmaker",
                Badges = new Badge { Bronze = 4, Silver = 8, Gold = 12, HallOfFame = 5, Legendary = 2, Total = 31 }
            },

            new Player {
                Id = "devin_booker",
                Name = "Devin Booker",
                Slug = "devin_booker",
                Height = "6'6\"",
                Weight = "206 lbs",
                Overall = 93,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/1626164.png",
                Url = "https://www.nba.com/player/1626164/devin-booker",
                Team = "Phoenix Suns",
                Positions = new List<string>{ "SG" },
                Archetype = "Elite Scorer",
                Badges = new Badge { Bronze = 5, Silver = 10, Gold = 14, HallOfFame = 7, Legendary = 3, Total = 39 }
            },

            new Player {
                Id = "shai_gilgeous_alexander",
                Name = "Shai Gilgeous-Alexander",
                Slug = "shai_gilgeous_alexander",
                Height = "6'6\"",
                Weight = "195 lbs",
                Overall = 95,
                Img = "https://cdn.nba.com/headshots/nba/latest/1040x760/1628983.png",
                Url = "https://www.nba.com/player/1628983/shai-gilgeous-alexander",
                Team = "Oklahoma City Thunder",
                Positions = new List<string>{ "PG", "SG" },
                Archetype = "Two-Way Playmaker",
                Badges = new Badge { Bronze = 6, Silver = 12, Gold = 16, HallOfFame = 8, Legendary = 4, Total = 46 }
            }

        };

        return PLAYERS;
    }
}
