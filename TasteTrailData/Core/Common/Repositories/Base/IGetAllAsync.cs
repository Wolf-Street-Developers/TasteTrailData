namespace TasteTrail.Data.src.Core.Common.Repositories.Base;

public interface IGetAllAsync<TEntity>
{
    Task<List<TEntity>> GetAllAsync();
}