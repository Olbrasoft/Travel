using Olbrasoft.Data;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Query
{
    public class GetAccommodationDetailById : QueryWithDependentDispatcher<AccommodationDetail>
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        public GetAccommodationDetailById(IDispatcher queryDispatcher) : base(queryDispatcher)
        {
        }
    }
}