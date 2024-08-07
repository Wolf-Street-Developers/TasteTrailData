namespace TasteTrail.Data.src.Core.Common.Repositories.Base;

public interface IPutAsync<TEntity, TId> 
{
    Task<TId> PutAsync(TEntity entity);
}