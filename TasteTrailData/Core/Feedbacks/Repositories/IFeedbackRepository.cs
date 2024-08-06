using TasteTrail.Data.src.Core.Common.Repositories.Base;
using TasteTrailData.Core.Feedbacks.Models;

namespace TasteTrailData.Core.Feedbacks.Repositories;

public interface IFeedbackRepository : IGetByCountAsync<Feedback>, IGetByIdAsync<Feedback, int>,
ICreateAsync<Feedback>, IDeleteByIdAsync<int>, IPutAsync<Feedback>
{
    
}