using PromotionEngine.Promotions;
using System;
using System.Collections.Generic;
using Xunit;
using PromotionEngine.SKUs;

namespace PromotionEngine.Unit.Tests
{
    public class PromotionEngineTests
    {
        [Fact]
        public void Test1_WithPromotionsAsku()
        {
            List<IPromotion> promotions = new List<IPromotion>();
            promotions.Add(new SkuAPromotion());    //130

            //Arrange
            Cart cart = new Cart(promotions);


            cart.SKUs.Add(new SkuA());  //50
            cart.SKUs.Add(new SkuA());  //50
            cart.SKUs.Add(new SkuA());  //50
            cart.SKUs.Add(new SkuB());  //30 
            cart.SKUs.Add(new SkuC());  //20

            decimal actual = 50 + 50 + 50 + 30 + 20 + 130;
            var total = cart.GetTotalPriceAfterPromotion();

            Assert.True(actual == total);
        }
        [Fact]
        public void Test2_WithPromotionsBsku()
        {

            List<IPromotion> promotions = new List<IPromotion>();
            promotions.Add(new SkuBPromotion()); //45

            //Arrange 
            Cart cart = new Cart(promotions);

            cart.SKUs.Add(new SkuA());  //50
            cart.SKUs.Add(new SkuB());  //30
            cart.SKUs.Add(new SkuB());  //30
            cart.SKUs.Add(new SkuC());  //20

            decimal actual = 50 + 30 + 30 + 20 + 45;
            var total = cart.GetTotalPriceAfterPromotion();

            Assert.True(actual == total);
        }

        [Fact]
        public void Test3_WithPromotionsCAndDSku()
        {

            List<IPromotion> promotions = new List<IPromotion>();
            promotions.Add(new SkuCAndDPromotion()); //30

            //Arrange 
            Cart cart = new Cart(promotions);

            cart.SKUs.Add(new SkuA());  //50
            cart.SKUs.Add(new SkuB());  //30
            cart.SKUs.Add(new SkuC());  //20
            cart.SKUs.Add(new SkuD());  //15

            decimal actual = 50 + 30 + 20 + 15 + 30;
            var total = cart.GetTotalPriceAfterPromotion();

            Assert.True(actual == total);
        }
    }
}
