using PromotionEngine.SKUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public class SkuBPromotion : IPromotion
    {

        public decimal GetPriceAfterPromotion(Dictionary<string, int> keyValueSkus)
        {
            var key = nameof(SkuB);
            if (keyValueSkus.ContainsKey(key))
            {
                var val = keyValueSkus[key];
                if (val >= 2)
                {
                    var numberOfPromotions = val / 2;
                    return (numberOfPromotions * 45);

                }
            }
            return 0;
        }
    }
}