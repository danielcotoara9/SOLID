using LSP_The_Liskov_Substitution_Principle.Example_2.After.Model;
using Xunit;

namespace UnitTests.LSP.Example_2.After
{
    public class FruitsShould
    {
        [Fact]
        public void GetColorForOrange()
        {
            Fruit orange = new Orange();

            Assert.Equal("orange", orange.GetColor());
        }

        [Fact]
        public void GetColorForLemon()
        {
            Fruit lemon = new Lemon();

            Assert.Equal("green", lemon.GetColor());
        }
    }
}
