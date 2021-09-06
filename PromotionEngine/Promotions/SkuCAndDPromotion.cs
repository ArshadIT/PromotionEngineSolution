using PromotionEngine.SKUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public class SkuCAndDPromotion : IPromotion
    {

        public decimal GetPriceAfterPromotion(Dictionary<string, int> keyValueSkus)
        {
            var cKey = nameof(SkuC);
            var dKey = nameof(SkuD);
            if (keyValueSkus.ContainsKey(cKey) && keyValueSkus.ContainsKey(dKey))
            {
                return 30;
            }

            return 0;
        }
    }
}