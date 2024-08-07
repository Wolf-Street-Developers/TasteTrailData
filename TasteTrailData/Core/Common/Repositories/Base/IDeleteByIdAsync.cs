namespace TasteTrail.Data.src.Core.Common.Repositories.Base;

public interface IDeleteByIdAsync<TId> 
{
    Task<TId> DeleteByIdAsync(TId id);
}