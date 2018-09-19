using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Olbrasoft.Collections.Generic;
using Olbrasoft.Data;
using Olbrasoft.Data.Entity;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Data.Entity.Query
{
    public class GetPagedAccommodationItemsQueryHandler : QueryHandler<GetPagedAccommodationItems, IQueryable<LocalizedAccommodation>, IPagedList<AccommodationItem>>
    {
        public GetPagedAccommodationItemsQueryHandler(IQueryable<LocalizedAccommodation> source) : base(source)
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
            var localizedAccommodationQueryable =
                source.Include(p => p.Accommodation).Where(p => p.LanguageId == query.LanguageId);

            var localizedAccommodationOrderedQueryable = query.Sorting(localizedAccommodationQueryable);

            return localizedAccommodationOrderedQueryable;
        }
    }
}
