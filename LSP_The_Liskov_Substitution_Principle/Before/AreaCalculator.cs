using LSP_The_Liskov_Substitution_Principle.Before.Model;

namespace LSP_The_Liskov_Substitution_Principle.Before
{
    public class AreaCalculator
    {
        public static int CalculateArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public static int CalculateArea(Square square)
        {
            return square.Height * square.Width;
        }
    }
}
