using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IRobo.Domain.Tests
{
    public class PointMapTests
    {
        [Theory]
        [InlineData(0,0)]
        public void isSelectXY_00(int positionX, int positionY)
        {
            MapArea map = new MapArea();
            map.PointMap.SetPoint(positionX, positionY);
            Assert.True(map.PointMap.p00);
        }

        [Theory]
        [InlineData(2, 0)]
        public void isSelectXY_20(int positionX, int positionY)
        {
            MapArea map = new MapArea();
            map.PointMap.SetPoint(positionX, positionY);
            Assert.True(map.PointMap.p20);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(1, 1)]
        [InlineData(0, 1)]
        public void isNotSelectXY_00(int positionX, int positionY)
        {
            MapArea map = new MapArea();
            map.PointMap.SetPoint(positionX, positionY);
            Assert.False(map.PointMap.p00);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(1, 1)]
        [InlineData(0, 1)]
        public void isNotSelectXY_20(int positionX, int positionY)
        {
            MapArea map = new MapArea();
            map.PointMap.SetPoint(positionX, positionY);
            Assert.False(map.PointMap.p20);
        }

    }
}
