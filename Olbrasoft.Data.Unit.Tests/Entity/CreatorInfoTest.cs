﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Data.Unit.Tests.Entity
{
    [TestFixture]
    class CreatorInfoTest
    {
        [Test]
        public void Instance_Implement_Interface_ICreation()
        {
            //Arrange
            var type = typeof(IHaveId<int>);

            //Act
            var creator = new HaveCreatorId<int,int>();

            //Assert
            Assert.IsInstanceOf(type,creator);

        }


        [Test]
        public void CreatorId()
        {
            //Arrange
           var guid =new Guid();
            var creatorInfo = new HaveCreatorId<int, Guid>()
            {
                CreatorId = guid
            };

            //Act
            var result = creatorInfo.CreatorId;
            
            //Assert
            Assert.IsTrue(result==guid);
        }

        [Test]
        public void Creator()
        {
            //Arrange
            var user = new User<Guid>();
            var creatorInfo = new HaveCreatorId<int, Guid>()
            {
                Creator = user
            };

            //Act
            var result = creatorInfo.Creator;

            //Assert

            Assert.AreSame(result,user);
        }


    }
}
