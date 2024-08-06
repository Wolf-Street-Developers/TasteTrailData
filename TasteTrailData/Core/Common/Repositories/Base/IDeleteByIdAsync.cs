namespace TasteTrail.Data.src.Core.Common.Repositories.Base;

public interface IDeleteByIdAsync<TId> 
{
    Task<int> DeleteByIdAsync(TId id);
}