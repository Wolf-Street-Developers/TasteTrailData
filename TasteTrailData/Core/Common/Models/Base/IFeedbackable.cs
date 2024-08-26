using TasteTrailData.Core.Feedbacks.Models;

namespace TasteTrailData.Core.Common.Models.Base;

public interface IFeedbackable
{
    ICollection<Feedback> Feedbacks { get; set; }
}