using Microsoft.AspNetCore.Http;

namespace TasteTrailData.Core.Common.Managers.ImageManagers;

public interface IImageManager<TId>
{
    Task<string> DeleteImageAsync(TId id);
	Task<string> SetImageAsync(TId id, IFormFile? logo);
	string GetDefaultImageUrl();
}
