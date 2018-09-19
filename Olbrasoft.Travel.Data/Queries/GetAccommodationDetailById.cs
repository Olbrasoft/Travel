using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Data.Queries
{
    public class GetAccommodationDetailById : QueryWithDependentQueryProcessor<AccommodationDetail>
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        public GetAccommodationDetailById(IQueryProcessor queryProcessor) : base(queryProcessor)
        {
        }
    }
}