namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IDeleteByIdAsync<TId> 
{
    Task<TId> DeleteByIdAsync(TId id);
}