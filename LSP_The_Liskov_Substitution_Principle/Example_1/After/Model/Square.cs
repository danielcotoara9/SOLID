namespace LSP_The_Liskov_Substitution_Principle.Example_1.After.Model
{
    public class Lemon : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        // Since square has Height = Width we can use only one property 
        //public int SideLength { get; set; }

        public override int Area()
        {
            // if we decide to use only one property
            //return SideLength * SideLength;
            return Width * Height;
        }
    }
}
