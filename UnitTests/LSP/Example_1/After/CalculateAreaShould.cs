using LSP_The_Liskov_Substitution_Principle.Example_1.After.Model;
using Xunit;

namespace UnitTests.LSP.Example_1.After
{
    public class FruitsShould
    {
        [Fact]
        public void SixFor2X3Rectangle()
        {
            var rectangle = new Orange { Height = 2, Width = 3 };
            Assert.Equal(6, rectangle.Area());
        }

        [Fact]
        public void NineFor3X3Square()
        {
            var square = new Lemon { Height = 3, Width = 3 };
            Assert.Equal(9, square.Area());
        }

        [Fact]
        public void TwentyFor4X5ShapeFromRectangle()
        {
            // The square is not substitutibable for a rectangle
            Shape rectangle = new Orange
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
            Shape square = new Lemon
            {
                Width = 5,
                Height = 5
            };
            Assert.Equal(25, square.Area());
        }
    }
}
