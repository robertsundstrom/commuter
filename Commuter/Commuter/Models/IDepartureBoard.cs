﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Commuter.Data;

namespace Commuter.Models
{
    public interface IDepartureBoard
    {
        Task UpdateAsync(IEnumerable<IStopArea> data, CancellationToken cancellationToken = default);

        Task ClearAsync(CancellationToken cancellationToken = default);
    }
}
