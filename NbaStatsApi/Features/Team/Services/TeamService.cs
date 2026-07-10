using AutoMapper;
using NbaStatsApi.Config.DB;
using NbaStatsApi.Features.Team.Contracts;
using NbaStatsApi.Features.Team.Entities;

namespace NbaStatsApi.Features.Team.Services;

public class TeamService: ITeamContract
{
    private readonly NbaDbContext _db;
    private readonly IMapper _mapper;

    public  TeamService(NbaDbContext db, IMapper mapper)
    {
        this._db = db;
        this._mapper = mapper;
    }
    public async Task<IEnumerable<O_Team>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<O_Team> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<O_Team> Create(O_Team Entity)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

}
