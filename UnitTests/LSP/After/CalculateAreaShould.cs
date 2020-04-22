using LSP_The_Liskov_Substitution_Principle.After.Model;
using Xunit;

namespace UnitTests.LSP.After
{
    public class CalculateAreaShould
    {
        [Fact]
        public void SixFor2X3Rectangle()
        {
            var rectangle = new Rectangle { Height = 2, Width = 3 };
            Assert.Equal(6, rectangle.Area());
        }

        [Fact]
        public void NineFor3X3Square()
        {
            var square = new Square { Height = 3, Width = 3 };
            Assert.Equal(9, square.Area());
        }

        [Fact]
        public void TwentyFor4X5ShapeFromRectangle()
        {
            // The square is not substitutibable for a rectangle
            Shape rectangle = new Rectangle
            {
                Width = 4,
                Height = 5
            };
            Assert.Equal(20, rectangle.Area());
        }

        [Fact]
        public void TwentyFor4X5ShapeFromSquare()
        {
            // The square is not substitutibable for a rectangle
            Shape square = new Square
            {
                Width = 5,
                Height = 5
            };
            Assert.Equal(25, square.Area());
        }
    }
}
