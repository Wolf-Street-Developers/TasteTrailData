

namespace TasteTrailData.Core.FeedbackLikes.Models;

public class FeedbackLike
{
    public required int Id { get; set; }
    
    public required int FeedbackId { get; set; }

    public required string UserId { get; set; }
}
