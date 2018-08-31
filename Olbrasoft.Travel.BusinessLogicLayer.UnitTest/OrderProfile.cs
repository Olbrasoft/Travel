using AutoMapper;

namespace Olbrasoft.Travel.BusinessLogicLayer.UnitTest
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>();
        }
    }
}