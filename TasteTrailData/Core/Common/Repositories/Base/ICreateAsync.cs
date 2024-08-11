namespace TasteTrailData.Core.Common.Repositories.Base;

public interface ICreateAsync<TEntity, TReturn> 
{
    Task<TReturn> CreateAsync(TEntity entity);
}