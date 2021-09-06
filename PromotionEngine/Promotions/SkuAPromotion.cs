using PromotionEngine.SKUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public class SkuAPromotion : IPromotion
    {
        public decimal GetPriceAfterPromotion(Dictionary<string, int> keyValueSkus)
        {

            if (keyValueSkus.ContainsKey(nameof(SkuA)))
            {
                var key = nameof(SkuA);
                var val = keyValueSkus[key];
                if (val >= 3)
                {
                    var numberOfPromotions = val / 3;
                    return (numberOfPromotions * 130);

                }
            }
            return 0;
        }
    }
}