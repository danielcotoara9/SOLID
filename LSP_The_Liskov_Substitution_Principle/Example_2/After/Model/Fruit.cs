namespace LSP_The_Liskov_Substitution_Principle.Example_2.After.Model
{
    // this means that Lemon and Orange are childs of this => are the same type
    public abstract class Fruit
    {
        // access this polymorphically. Everytime the childs want this we will know what implementation will choose
        public abstract string GetColor();
    }
}
