using OCP_Open_Closed_Principle.Before;
using OCP_Open_Closed_Principle.Common.Model;
using Xunit;

namespace UnitTests.OCP.Before
{
    public class CartShould
    {
        private Cart _cart;

        public CartShould()
        {
            _cart = new Cart();

        }

        [Fact]
        public void ZeroWhenEmpty()
        {
            Assert.Equal(0, _cart.TotalAmount());
        }

        [Fact]
        public void FiveWithOneEachItem()
        {
            _cart.Add(new OrderItem { Quantity = 1, Sku = "EACH_WIDGET" });
            Assert.Equal(5.0m, _cart.TotalAmount());
        }

        [Fact]
        public void TwoWithHalfKiloWeightItem()
        {
            _cart.Add(new OrderItem { Quantity = 500, Sku = "WEIGHT_PEANUTS" });
            Assert.Equal(2m, _cart.TotalAmount());
        }

        [Fact]
        public void EightyCentsWithTwoSpecialItem()
        {
            _cart.Add(new OrderItem { Quantity = 2, Sku = "SPECIAL_CANDYBAR" });
            Assert.Equal(0.8m, _cart.TotalAmount());
        }

        [Fact]
        public void TwoDollarWithSixSpecialItem()
        {
            _cart.Add(new OrderItem { Quantity = 6, Sku = "SPECIAL_CANDYBAR" });
            Assert.Equal(2m, _cart.TotalAmount());
        }
    }
}
