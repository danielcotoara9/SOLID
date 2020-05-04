using LSP_The_Liskov_Substitution_Principle.Example_2.Before.Model;
using Xunit;

namespace UnitTests.LSP.Example_2.Before
{
    public class ColorsShould
    {
        [Fact]
        public void GetColorForOrange()
        {
            Lemon lemon = new Orange();

            // This test will fail => Please se the recatored version
            // orange cannot be replaced by lemmon, returning orange's color
            Assert.Equal("green", lemon.GetColor());
        }
    }
}
