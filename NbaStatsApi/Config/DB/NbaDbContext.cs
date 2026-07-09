using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NbaStatsApi.Features.Auth.Entities;

namespace NbaStatsApi.Config.DB;

public class NbaDbContext: IdentityDbContext<User>
{
    public NbaDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
