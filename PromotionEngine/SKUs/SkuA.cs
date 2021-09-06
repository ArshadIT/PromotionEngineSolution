using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.SKUs
{
    public class SkuA : ISku
    {
        public SkuA()
        {
            Price = 50;
        }
        public decimal Price { get; }
    }
}
