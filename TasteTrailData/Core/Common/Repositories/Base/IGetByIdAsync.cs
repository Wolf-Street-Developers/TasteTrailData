namespace TasteTrail.Data.src.Core.Common.Repositories.Base;

public interface IGetByIdAsync<TEntity, TId>
{
    Task<TEntity?> GetByIdAsync(TId id);
}
