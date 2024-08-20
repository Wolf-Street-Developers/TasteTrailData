namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IGetAsNoTrackingAsync<TEntity, TId>
{
    Task<TEntity?> GetAsNoTrackingAsync(TId id);
}
