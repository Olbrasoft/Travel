using AutoMapper;

namespace Olbrasoft.Travel.Business.Unit.Tests
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>();
        }
    }
}