namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IPutAsync<TEntity, TId> 
{
    Task<TId> PutAsync(TEntity entity);
}