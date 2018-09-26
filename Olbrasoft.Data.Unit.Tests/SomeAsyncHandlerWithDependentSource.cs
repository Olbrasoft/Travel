﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Data.Query;

namespace Olbrasoft.Data.Unit.Tests
{
    internal class SomeAsyncHandlerWithDependentSource : AsyncHandlerWithDependentSource<SomQuery, IQueryable<object>, object>
    {

        public SomeAsyncHandlerWithDependentSource(IQueryable<object> source) : base(source)
        {
        }


        public new object Handle(SomQuery query)
        {
            return new object();
            throw new System.NotImplementedException();
        }

        public override Task<object> HandleAsync(SomQuery query, CancellationToken cancellationToken)
        {
            

            throw new System.NotImplementedException();
        }
    }
}