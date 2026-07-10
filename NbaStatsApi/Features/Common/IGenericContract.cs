namespace NbaStatsApi.Features.Common;

public interface IGenericContract<T> where T : class 
{
    public Task<IEnumerable<T>> GetAll();
    public Task<T> GetById(int id);
    public Task<T> Create(T Entity);
    public Task<T> Delete(int id);
}
