using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.SKUs
{
    public class SkuC : ISku
    {
        public SkuC()
        {
            Price = 20;
        }

        public decimal Price { get; }
    }
}