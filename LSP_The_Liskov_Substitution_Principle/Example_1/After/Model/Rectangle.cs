namespace LSP_The_Liskov_Substitution_Principle.Example_1.After.Model
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override int Area()
        {
            return Height * Width;
        }
    }
}
