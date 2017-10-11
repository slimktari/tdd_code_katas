using SumIntList;
using System;
using Xunit;

namespace SumIntListTest
{
    public class SumIntListTest
    {
        Random _generator = new Random();

        [Fact]
        public void ShouldReturnNoElementsWhenNoInput()
        {
            // Arrange
            int[] elements = new int[] { };
            int target = _generator.Next();

            // Act
            int[] actual = SumIntListMain.GetArray(elements, target);

            // Assert
            Assert.NotNull(actual);
            Assert.Empty(actual);
        }

        [Fact]
        public void ShouldReturnElementWhenHaveATargetAndCorrespondingElements()
        {
            // Arrange
            int[] elements = new int[] { 5, 10 };
            int target = 10;
            int[] expected = new int[] { 1 };

            // Act
            int[] actual = SumIntListMain.GetArray(elements, target);

            // Assert
            Assert.NotNull(actual);
            Assert.Equal(expected[0], actual[0]);
        }

        [Fact]
        public void ShouldReturnElementWhenHaveATargetAndCorrespondingElementsWithThreeElements()
        {
            // Arrange
            int[] elements = new int[] { 5, 3, 20 };
            int target = 20;
            int[] expected = new int[] { 2 };

            // Act
            int[] actual = SumIntListMain.GetArray(elements, target);

            // Assert
            Assert.NotNull(actual);
            Assert.Equal(expected[0], actual[0]);
        }

        [Fact]
        public void ShouldReturnTwoElementsWhenTargetIsSumOfTwoElements()
        {
            // Arrange
            int[] element = new int[] { 5, 3, 20 };
            int target = 8;
            int[] expected = new int[] { 0, 1 };

            // Act
            int[] actual = SumIntListMain.GetArray(element, target);

            // Assert
            Assert.NotNull(actual);
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);
        }

        [Fact]
        public void ShouldReturnThreeElementsWhenTargetIsSumOfThreeElements()
        {
            // Arrange
            int[] elements = new int[] { 5, 3, 21, 4 };
            int target = 12;
            int[] expected = new[] { 0, 1, 3 };

            // Act
            int[] actual = SumIntListMain.GetArray(elements, target);

            // Assert
            Assert.NotNull(actual);
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);
            Assert.Equal(expected[2], actual[2]);
        }

        [Fact]
        public void ShouldReturnZeroElementWhenNoMatchedElements()
        {
            // Arrange
            int[] elements = new int[] { 5 };
            int target = 12;
            int[] expected = new int[] { };

            // Act
            int[] actual = SumIntListMain.GetArray(elements, target);

            // Assert
            Assert.NotNull(actual);
            Assert.Equal(expected.Length, actual.Length);
        }
    }
}