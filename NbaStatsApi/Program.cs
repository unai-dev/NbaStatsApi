using NbaStatsApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(cfg =>
{
    cfg.AddDefaultPolicy(c =>
    {
        c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
});


var app = builder.Build();

app.UseCors();

// minimal endpoint
app.MapGet("/api/players", () => MOCK_DATA.GetPlayers());
app.MapGet("/api/teams", () => MOCK_DATA.GetTeams());

app.Run();
