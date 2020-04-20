using OCP_Open_Closed_Principle.After.Interfaces;
using OCP_Open_Closed_Principle.Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace OCP_Open_Closed_Principle.After.Implementation
{
    public class PricingCalculator : IPricingCalculator
    {
        private readonly List<IPriceRule> _pricingRules;

        public PricingCalculator()
        {
            _pricingRules = new List<IPriceRule>
            {
                new EachPriceRule(),
                new PerGramPriceRule(),
                new SpecialPriceRule()
            };

        }
        public decimal CalculatePrice(OrderItem orderItem)
        {
            return _pricingRules.First(r => r.IsMatch(orderItem)).CalculatePrice(orderItem);
        }
    }
}
