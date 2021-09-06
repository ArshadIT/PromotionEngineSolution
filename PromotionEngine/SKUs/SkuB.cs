using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.SKUs
{
   public  class SkuB : ISku
    {
        public SkuB()
        {
            Price = 30;
        }
        public decimal Price { get; }
    }
}
