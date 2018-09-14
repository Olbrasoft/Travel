using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Data.Unit.Tests
{
    internal class SomeQueryHandler : QueryHandler<SomQuery,IQueryable<object>, object>
    {
    
        public SomeQueryHandler(IQueryable<object> source) : base(source)
        {
        }

        public override object Handle(SomQuery query)
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