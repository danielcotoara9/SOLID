namespace LSP_The_Liskov_Substitution_Principle.Example_1.Before.Model
{
    public class Orange : Lemon
    {
        private int _height;
        private int _width;

        public override int Width 
        {
            get { return _width; }
            set
            {
                _height = value;
                _width = value;
            }
        }

        public override int Height 
        {
            get { return _height; }
            set
            {
                _height = value;
                _width = value;
            }
        }
    }
}
