
using Microsoft.AspNetCore.Mvc;

namespace TasteTrailData.Api.Common.Extensions.Controllers;

public static class InternalServerErrorMethod
{
    public static IActionResult InternalServerError(this ControllerBase controller, string message)
    {
        return controller.StatusCode(500, new { message });
    }
}