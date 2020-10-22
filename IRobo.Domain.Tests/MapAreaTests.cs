using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IRobo.Domain.Tests
{
    public class MapAreaTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void ValidXorY_IsValid(int point)
        {
            MapArea map = new MapArea();
            Assert.True(map.ValidAxis(point));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(5)]
        [InlineData(7)]
        public void ValidXorY_IsNotValid(int point)
        {
            MapArea map = new MapArea();
            Assert.False(map.ValidAxis(point));
        }
    }
}
