namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IDeleteByIdAsync<TId, TReturn> 
{
    Task<TReturn> DeleteByIdAsync(TId id);
}