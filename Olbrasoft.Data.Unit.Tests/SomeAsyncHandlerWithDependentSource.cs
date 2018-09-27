﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Data.Query;

namespace Olbrasoft.Data.Unit.Tests
{
    internal class SomeAsyncHandlerWithDependentSource : AsyncHandlerWithDependentSource<SomQuery, IQueryable<object>, object>
    {


        public new object Handle(SomQuery query)
        {
            return new object();
            throw new System.NotImplementedException();
        }

        public override Task<object> HandleAsync(SomQuery query, CancellationToken cancellationToken)
        {
            

            throw new System.NotImplementedException();
        }

        public SomeAsyncHandlerWithDependentSource(IQueryable<object> source, IProjection projector) : base(source, projector)
        {
        }
    }
}