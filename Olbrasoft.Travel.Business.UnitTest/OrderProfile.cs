using AutoMapper;

namespace Olbrasoft.Travel.Business.UnitTest
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>();
        }
    }
}