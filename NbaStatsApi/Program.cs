using NbaStatsApi.Data;

/**************************************** SERVICES SECTION ****************************************/
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(cfg =>
{
    cfg.AddDefaultPolicy(c =>
    {
        c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
});


/**************************************** BUILDER SECTION ****************************************/
var app = builder.Build();
app.UseCors();


/**************************************** MINIMAL ENDPOINTS ****************************************/

/* PLAYERS */
app.MapGet("/api/players", () => MOCK_DATA.GetPlayers());

/* TEAMS */
app.MapGet("/api/teams", () => MOCK_DATA.GetTeams());

app.Run();
