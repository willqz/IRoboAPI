using IRobo.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IRobo.Domain.Tests
{
    public class BotTests
    {
        [Theory]
        [InlineData("L")]
        public void Point_00N_Turn_L(string command)
        {
            Bot bot = new Bot();
            var result = bot.Direction(command);
            Assert.Equal((int)EnumDirection.West, result);
        }

        [Theory]
        [InlineData("L")]
        public void Point_00W_Turn_L(string command)
        {
            Bot bot = new Bot();
            bot.DirectionGraus = (int)EnumDirection.West;
            var result = bot.Direction(command);
            Assert.Equal((int)EnumDirection.South, result);
        }

        [Theory]
        [InlineData("L")]
        public void Point_00S_Turn_L(string command)
        {
            Bot bot = new Bot();
            bot.DirectionGraus = (int)EnumDirection.South;
            var result = bot.Direction(command);
            Assert.Equal((int)EnumDirection.East, result);
        }

        [Theory]
        [InlineData("L")]
        public void Point_00L_Turn_L(string command)
        {
            Bot bot = new Bot();
            bot.DirectionGraus = (int)EnumDirection.East;
            var result = bot.Direction(command);
            Assert.Equal((int)EnumDirection.North, result);
        }


        [Theory]
        [InlineData("R")]
        public void Point_00N_Turn_R(string command)
        {
            Bot bot = new Bot();
            var result = bot.Direction(command);
            Assert.Equal((int)EnumDirection.East, result);
        }

        [Theory]
        [InlineData("R")]
        public void Point_00L_Turn_R(string command)
        {
            Bot bot = new Bot();
            bot.DirectionGraus = (int)EnumDirection.East;
            var result = bot.Direction(command);
            Assert.Equal((int)EnumDirection.South, result);
        }

        [Theory]
        [InlineData("R")]
        public void Point_00S_Turn_R(string command)
        {
            Bot bot = new Bot();
            bot.DirectionGraus = (int)EnumDirection.South;
            var result = bot.Direction(command);
            Assert.Equal((int)EnumDirection.West, result);
        }

        [Fact]
        public void GetDescriptionDirection_West()
        {
            Bot bot = new Bot();
            var result = bot.GetDescriptionDirection((int)EnumDirection.West);
            Assert.Equal("W", result);
        }

        [Fact]
        public void GetDescriptionDirection_South()
        {
            Bot bot = new Bot();
            var result = bot.GetDescriptionDirection((int)EnumDirection.South);
            Assert.Equal("S", result);
        }

        [Fact]
        public void GetDescriptionDirection_East()
        {
            Bot bot = new Bot();
            var result = bot.GetDescriptionDirection((int)EnumDirection.East);
            Assert.Equal("E", result);
        }

        [Fact]
        public void GetDescriptionDirection_North()
        {
            Bot bot = new Bot();
            var result = bot.GetDescriptionDirection((int)EnumDirection.North);
            Assert.Equal("N", result);
        }

        [Theory]
        [InlineData("M")]
        public void Action_01N_isOk(string command)
        {
            Bot bot = new Bot();
            var result = bot.Action(command);

            Assert.Equal("(0,1,N)", result);
        }

        [Theory]
        [InlineData("MM")]
        public void Action_02N_isOk(string command)
        {
            Bot bot = new Bot();
            var result = bot.Action(command);

            Assert.Equal("(0,2,N)", result);
        }

        [Theory]
        [InlineData("MMM")]
        public void Action_03N_isOk(string command)
        {
            Bot bot = new Bot();
            var result = bot.Action(command);

            Assert.Equal("(0,3,N)", result);
        }

        [Theory]
        [InlineData("MMMM")]
        public void Action_04N_isOk(string command)
        {
            Bot bot = new Bot();
            var result = bot.Action(command);

            Assert.Equal("(0,4,N)", result);
        }

        [Theory]
        [InlineData("MMMMM")]
        public void Action_05N_isOk(string command)
        {
            Bot bot = new Bot();
            var result = bot.Action(command);

            Assert.Equal("(0,4,N)", result);
        }

        [Theory]
        [InlineData("AAA")]
        public void Command_NotValid(string command)
        {
            Bot bot = new Bot();
            var result = bot.ValidCommand(command);

            Assert.False(result);
        }
    }
}
