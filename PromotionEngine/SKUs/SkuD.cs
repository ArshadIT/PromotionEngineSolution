using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.SKUs
{
    public class SkuD : ISku
    {
        public SkuD()
        {
            Price = 15;
        }

        public decimal Price { get; }
    }
}