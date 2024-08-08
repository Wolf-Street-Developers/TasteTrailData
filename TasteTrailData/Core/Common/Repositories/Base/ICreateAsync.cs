namespace TasteTrailData.Core.Common.Repositories.Base;

public interface ICreateAsync<TEntity, TId> 
{
    Task<TId> CreateAsync(TEntity entity);
}