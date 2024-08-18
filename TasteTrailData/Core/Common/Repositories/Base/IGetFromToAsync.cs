namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IGetFromToAsync<TEntity>
{
    Task<List<TEntity>> GetFromToAsync(int from, int to);
}
