﻿using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Data
{
    public interface IQuery
    {
    }

    public interface IQuery<TResult> : IQuery
    {
        TResult Execute();
        Task<TResult> ExecuteAsync(CancellationToken cancellationToken);

    }

}