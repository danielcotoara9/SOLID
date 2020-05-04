namespace LSP_The_Liskov_Substitution_Principle.Example_1.After.Model
{
    // this means that Rectangle and Square are childs of this => are the same type
    public abstract class Shape
    {
        // access this polymorphically. Everytime the childs want this we will know what implementation will choose
        public abstract int Area();
    }
}
