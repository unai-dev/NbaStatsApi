using AutoMapper;
using NbaStatsApi.Config.DB;
using NbaStatsApi.Features.Player.Contracts;
using NbaStatsApi.Features.Player.Entities;

namespace NbaStatsApi.Features.Player.Services;

public class PlayerService: IPlayerContract
{
    private readonly NbaDbContext _db;
    private readonly IMapper _mapper;

    public PlayerService(NbaDbContext db, IMapper mapper)
    {
        this._db = db;
        this._mapper = mapper;
    }


    public async Task<IEnumerable<O_Player>> GetAll()
    {
        throw new NotImplementedException();
    }
    public async Task<O_Player> GetById(int id)
    {
        throw new NotImplementedException();
    }
    public async Task<O_Player> Create(O_Player Entity)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }
}
