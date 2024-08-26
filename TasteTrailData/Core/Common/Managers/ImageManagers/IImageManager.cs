using Microsoft.AspNetCore.Http;

namespace TasteTrailData.Core.Common.Managers.ImageManagers;

public interface IImageManager<TId>
{
    Task<string> DeleteImage(TId id);
	Task<string> SetImage (TId id, IFormFile? logo);
	Task<string> GetDefaultImageUrl();
}
