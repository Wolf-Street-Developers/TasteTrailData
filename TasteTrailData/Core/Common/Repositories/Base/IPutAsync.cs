namespace TasteTrail.Data.src.Core.Common.Repositories.Base;

public interface IPutAsync<TEntity> 
{
    Task<int> PutAsync(TEntity entity);
}