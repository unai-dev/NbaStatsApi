using Microsoft.EntityFrameworkCore;
using NbaStatsApi.Config.DB;
using NbaStatsApi.Data;

/**************************************** SERVICES SECTION ****************************************/
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NbaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NbaConnection")));

builder.Services.AddCors(cfg =>
    cfg.AddDefaultPolicy(c =>
        c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()));

builder.Services.AddControllers();


/**************************************** BUILDER SECTION ****************************************/
var app = builder.Build();
app.UseCors();
app.MapControllers();


/**************************************** MINIMAL ENDPOINTS ****************************************/

/* PLAYERS */
app.MapGet("/api/players", () => MOCK_DATA.GetPlayers());

/* TEAMS */
app.MapGet("/api/teams", () => MOCK_DATA.GetTeams());

app.Run();