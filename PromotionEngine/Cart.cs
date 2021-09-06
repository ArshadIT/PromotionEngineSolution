using PromotionEngine.Promotions;
using PromotionEngine.SKUs;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class Cart
    {
        private readonly List<IPromotion> _promotions;
        public decimal total = 0;
        public Cart(List<IPromotion> promotions)
        {
            _promotions = promotions;
            SKUs = new List<ISku>();
        }
        public List<ISku> SKUs { get; set; }

        private decimal GetTotal()
        {
            foreach (ISku sku in SKUs)
            {
                total += sku.Price;
            }

            return total;
        }

        public decimal GetTotalPriceAfterPromotion()
        {
            var dic = new Dictionary<string, int>();

            foreach (var sku in SKUs)
            {
                if (sku is SkuA)
                {
                    var key = nameof(SkuA);
                    if (dic.ContainsKey(key))
                    {
                        var val = dic[key];
                        dic[key] = val + 1;
                    }
                    else
                    {
                        dic.Add(key, 1);
                    }

                }

                if (sku is SkuB)
                {
                    var key = nameof(SkuB);
                    if (dic.ContainsKey(key))
                    {
                        var val = dic[key];
                        dic[key] = val + 1;
                    }
                    else
                    {
                        dic.Add(key, 1);
                    }

                }

                if (sku is SkuC)
                {
                    var key = nameof(SkuC);
                    if (dic.ContainsKey(key))
                    {
                        var val = dic[key];
                        dic[key] = val + 1;
                    }
                    else
                    {
                        dic.Add(key, 1);
                    }
                }
                if (sku is SkuD)
                {
                    var key = nameof(SkuD);
                    if (dic.ContainsKey(key))
                    {
                        var val = dic[key];
                        dic[key] = val + 1;
                    }
                    else
                    {
                        dic.Add(key, 1);
                    }
                }

            }

            decimal promotionsPrice = 0;
            foreach (var promotion in _promotions)
            {
                promotionsPrice += promotion.GetPriceAfterPromotion(dic);
            }


            return GetTotal() + promotionsPrice;

        }

    }
}
