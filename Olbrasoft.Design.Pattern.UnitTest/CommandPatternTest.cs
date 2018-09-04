﻿using NUnit.Framework;
using Olbrasoft.Design.Pattern.GangOfFour.Behavior;

namespace Olbrasoft.Design.Pattern.UnitTest
{
    [TestFixture]
    public class CommandPatternTest
    {
        [Test]
        public void IsInstanceOfICommand()
        {
            //Arrange
            var type = typeof(ICommand);

            //Act
            var commandPattern = new CommandPattern();

            //Assert
            Assert.IsInstanceOf(type, commandPattern);
        }

        [Test]
        public void ExecuteCall()
        {
            //Arrange
            var c = new CommandPattern();

            //Act
            c.Execute();

            //Assert
        }
    }

    public class CommandPattern : ICommand

    {
        public void Execute()
        {
        }
    }
}