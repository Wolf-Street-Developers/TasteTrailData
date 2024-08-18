using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IGetFromToAsync<TEntity>
{
    Task<IEnumerable<TEntity>> GetFromToAsync(int from, int to);
}
