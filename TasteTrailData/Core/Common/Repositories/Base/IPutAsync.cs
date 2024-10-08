namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IPutAsync<TEntity, TReturn> 
{
    Task<TReturn> PutAsync(TEntity entity);
}