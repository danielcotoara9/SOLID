using LSP_The_Liskov_Substitution_Principle.Example_1.Before.Model;

namespace LSP_The_Liskov_Substitution_Principle.Example_1.Before
{
    public class AreaCalculator
    {
        public static int CalculateArea(Lemon rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public static int CalculateArea(Orange square)
        {
            return square.Height * square.Width;
        }
    }
}
