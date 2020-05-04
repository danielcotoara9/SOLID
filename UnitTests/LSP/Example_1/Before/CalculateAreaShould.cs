using LSP_The_Liskov_Substitution_Principle.Example_1.Before;
using LSP_The_Liskov_Substitution_Principle.Example_1.Before.Model;
using Xunit;

namespace UnitTests.LSP.Example_1.Before
{
    public class ColorTests
    {
        [Fact]
        public void SixFor2X3Rectangle()
        {
            var rectangle = new Lemon { Height = 2, Width = 3 };
            Assert.Equal(6, AreaCalculator.CalculateArea(rectangle));
        }

        [Fact]
        public void NineFor3X3Square()
        {
            var square = new Orange { Height = 3, Width = 3 };
            Assert.Equal(9, AreaCalculator.CalculateArea(square));
        }

        [Fact]
        public void TwentyFor4X5RectangleFromSquare()
        {
            // This test will not pass !!
            // The square is not substitutibable for a rectangle
            // Base class Rectangle should be substitutable for child Square
            Lemon rectangle = new Orange
            {
                Width = 4,
                Height = 5
            };
            Assert.Equal(20, AreaCalculator.CalculateArea(rectangle));
        }

    }
}
