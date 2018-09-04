using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using NUnit.Framework;
using Olbrasoft.Travel.Business.Mapping;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Business.UnitTest
{
    [TestFixture]
    internal class AutoMapperTest
    {
        [Test]
        public void Map_Order_To_OrderDto()
        {
            //Arrange
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDto>());
            var order = new Order { Name = "Lenka" };
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
            Mapper.Initialize(cfg => cfg.CreateMap<Accommodation, AccommodationDto>()
               .ForMember(d => d.Name, opt => opt.MapFrom(src => src.LocalizedAccommodations.FirstOrDefault().Name)));

            var accommodation = new Accommodation { Address = "Olbramovice" };

            accommodation.LocalizedAccommodations.Add(new LocalizedAccommodation { Name = "Jirka" });

            var accommodationDataTransferObject = new AccommodationDto();

            //Act
            accommodationDataTransferObject = Mapper.Map(accommodation, accommodationDataTransferObject);

            //Assert
            Assert.IsTrue(accommodationDataTransferObject.Name == "Jirka");
        }

        [Test]
        public void Map_Accommodations_to_AccommodationDataTransferObjects_configuration_from_AccommodationProfile()
        {
            //Arrange
            var config = new MapperConfiguration(cfg => cfg.AddProfile<AccommodationProfile>());
            var mapper = config.CreateMapper();

            var accommodations = new[]
            {
                new Accommodation { Id=1, Address = "Olbramovice Ves." },
                new Accommodation {Id=2, Address = "Veselka 18"}
            };

            accommodations[1].LocalizedAccommodations.Add(new LocalizedAccommodation { Name = "Jirka" });

            //Act
            var accommodationDataTransferObjects = mapper.Map<AccommodationDto[]>(accommodations);

            //Assert
            Assert.IsTrue(accommodationDataTransferObjects[1].Name == "Jirka");
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
            Assert.IsTrue(orderDtos.Count() == 3);
        }

        [Test]
        public void MapperConfiguration_From_Interface()
        {
           
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDto>());

            IOrder order = new Order { Name = "Lenka" };
            var mapper = config.CreateMapper();

            IOrderDto orderDto =new OrderDto();

            //Act
            orderDto = mapper.Map<IOrderDto>(order);

            //Assert
            Assert.IsTrue(orderDto.Name == "Lenka");

        }

    }
}