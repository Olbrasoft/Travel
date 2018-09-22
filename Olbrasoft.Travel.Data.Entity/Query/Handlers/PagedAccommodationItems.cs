using AutoMapper;
using AutoMapper.QueryableExtensions;
using Olbrasoft.Collections.Generic;
using Olbrasoft.Data.Entity;
using Olbrasoft.Data.Query;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Travel.Data.Entities;


namespace Olbrasoft.Travel.Data.Entity.Query.Handlers
{
    public class PagedAccommodationItems : HandlerWithDependentSource<GetPagedAccommodationItems, IQueryable<LocalizedAccommodation>, IPagedList<AccommodationItem>>
    {
        public PagedAccommodationItems(IHaveLocalizedAccommodations ownLocalizedAccommodations) : base(ownLocalizedAccommodations.LocalizedAccommodations)
        {
        }

        public override IPagedList<AccommodationItem> Handle(GetPagedAccommodationItems query)
        {
            var config = new MapperConfiguration(expression => expression.CreateMap<LocalizedAccommodation, AccommodationItem>()
                .ForMember(dto => dto.Address, conf => conf.MapFrom(localizedAccommodation => localizedAccommodation.Accommodation.Address)));

            return PreHandle(Source, query).ProjectTo<AccommodationItem>(config).AsPagedList(query.Paging);
        }

        public override Task<IPagedList<AccommodationItem>> HandleAsync(GetPagedAccommodationItems query, CancellationToken cancellationToken)
        {
            var config = new MapperConfiguration(expression => expression.CreateMap<LocalizedAccommodation, AccommodationItem>()
                .ForMember(dto => dto.Address, conf => conf.MapFrom(localizedAccommodation => localizedAccommodation.Accommodation.Address)));

            return PreHandle(Source, query).ProjectTo<AccommodationItem>(config)
                .AsPagedListAsync(query.Paging, cancellationToken);
        }

        private static IQueryable<LocalizedAccommodation> PreHandle(IQueryable<LocalizedAccommodation> source, GetPagedAccommodationItems query)
        {
            var localizedAccommodationQueryable = source.Include(p => p.Accommodation).Where(p => p.LanguageId == query.LanguageId);

            var localizedAccommodationOrderedQueryable = query.Sorting(localizedAccommodationQueryable);

            return localizedAccommodationOrderedQueryable;
        }
    }
}