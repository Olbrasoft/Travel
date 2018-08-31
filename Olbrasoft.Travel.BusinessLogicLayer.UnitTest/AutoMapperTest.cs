using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.DataTransferObject;

namespace Olbrasoft.Travel.BusinessLogicLayer.UnitTest
{
    [TestFixture]
    internal class AutoMapperTest
    {
        [Test]
        public void Map_Order_To_OrderDto()
        {
            //Arrange
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDto>());
            var order = new Order {  Name = "Lenka" };
            var mapper = config.CreateMapper();

            //Act
            var dto = mapper.Map<OrderDto>(order);
            
            //Assert
            Assert.IsTrue(dto.Name == "Lenka");

        }
        

        [Test]
        public void Map_Accommodation_to_AccommodationDataTransferObject()
        {
            //Arrange
            Mapper.Initialize (cfg=>cfg.CreateMap<Accommodation, AccommodationDataTransferObject>()
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.LocalizedAccommodations.FirstOrDefault().Name)));

            var accommodation = new Accommodation { Address="Olbramovice"};
            
            accommodation.LocalizedAccommodations.Add(new LocalizedAccommodation {Name = "Jirka"});

            var accommodationDataTransferObject = new AccommodationDataTransferObject();
             
            //Act
            accommodationDataTransferObject = Mapper.Map(accommodation, accommodationDataTransferObject);

            //Assert
            Assert.IsTrue(accommodationDataTransferObject.Name == "Jirka");

        }
        

        [Test]
        public void Map_Profile_Configuration__IEnumerable_Of_Order_To_IEnumerable_Of_OrderDto()
        {
            //Arrange
            var orders = new[]
            {
                new Order {Name = "Jirka"},
                new Order {Name = "Lenka"},
                new Order{Name="Kristina"}
            };

            var config = new MapperConfiguration(cfg => cfg.AddProfile<OrderProfile>());
            var mapper = config.CreateMapper();

            //Act
            var orderDtos = mapper.Map<IEnumerable<Order>>(orders);

            //Assert
            Assert.IsTrue(orderDtos.Count()==3);
        }


    }
}