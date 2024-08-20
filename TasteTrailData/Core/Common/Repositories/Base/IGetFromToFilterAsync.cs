namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IGetFromToFilterAsync<TEntity>
{
    Task<List<TEntity>> GetFromToFilterAsync(int from, int to, Predicate<TEntity> filter);
}
