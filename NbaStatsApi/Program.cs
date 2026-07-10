using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NbaStatsApi.Config.DB;
using NbaStatsApi.Contracts;
using NbaStatsApi.Entities;
using NbaStatsApi.Services;
using NbaStatsApi.Tools.MockData;
using System.Text;

/**************************************** SERVICES SECTION ****************************************/
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NbaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NbaConnection")));

builder.Services.AddCors(cfg =>
    cfg.AddDefaultPolicy(c =>
        c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()));

builder.Services.AddControllers();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IPlayerContract, PlayerService>();
builder.Services.AddScoped<ITeamContract, TeamService>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddIdentityCore<User>()
    .AddEntityFrameworkStores<NbaDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<UserManager<User>>();
builder.Services.AddScoped<SignInManager<User>>();

// Configuración de autenticación JWT
builder.Services.AddAuthentication().AddJwtBearer(o =>
{
    o.MapInboundClaims = false;
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = false,
        ValidateIssuer = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["JWT_KEY"]!)),
        ClockSkew = TimeSpan.Zero
    };
});


/**************************************** BUILDER SECTION ****************************************/
var app = builder.Build();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();


/**************************************** MINIMAL ENDPOINTS ****************************************/

/* PLAYERS */
app.MapGet("/api/players", () => MOCK_DATA.GetPlayers());

/* TEAMS */
app.MapGet("/api/teams", () => MOCK_DATA.GetTeams());

app.Run();