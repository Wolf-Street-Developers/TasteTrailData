namespace TasteTrail.Data.src.Core.Common.Repositories.Base;

public interface ICreateAsync<TEntity> 
{
    Task<int> CreateAsync(TEntity entity);
}