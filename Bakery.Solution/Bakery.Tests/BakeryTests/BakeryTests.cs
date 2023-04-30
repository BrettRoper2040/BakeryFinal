using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryBread;
using BakeryDonut;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadCalc
  {
    [TestMethod]
    public void BuyOneGetOne()
    {
      Bread Marge = new Bread();
      Assert.AreEqual(10, Marge.BreadPrice(3, 0));
    }
    [TestMethod]
        public void BuyABunch()
    {
      Bread Marge = new Bread();
      Assert.AreEqual(25, Marge.BreadPrice(7, 0));
    }
    [TestMethod]
        public void BuyZero()
    {
      Bread Marge = new Bread();
      Assert.AreEqual(0, Marge.BreadPrice(0, 0));
    }
        [TestMethod]
        public void HowManyRealBread()
    {
      Bread Marge = new Bread();
      Marge.HowMany = 3;
      Assert.AreEqual(3, Marge.HowMany);
    }
        [TestMethod]
            public void HowManyFakeBread()
    {
      Bread Marge = new Bread();
      Marge.HowMany = 0;
      Assert.AreEqual(0, Marge.HowMany);
    }


          [TestMethod]
    public void DonutUseTheDeal()
    {
      Donut Homer = new Donut();
      Assert.AreEqual(4, Homer.DonutPrice(2, 0));
    }
        [TestMethod]
        public void UseTheDeal()
    {
      Donut Homer = new Donut();
      Assert.AreEqual(5, Homer.DonutPrice(3, 0));
    }
    [TestMethod]
        public void Lotsofdonuts()
    {
      Donut Homer = new Donut();
      Assert.AreEqual(12, Homer.DonutPrice(7, 0));
    }
        [TestMethod]
        public void Nothing()
    {
      Donut Homer = new Donut();
      Assert.AreEqual(0, Homer.DonutPrice(0, 0));
    }

                    [TestMethod]
            public void DealAvalYesBread()
    {
      Bread Marge = new Bread();
      Assert.AreEqual(true, Marge.DealChecker(2));
    }

                [TestMethod]
            public void DealAvalNoBread()
    {
      Bread Marge = new Bread();
      Assert.AreEqual(false, Marge.DealChecker(3));
    }

    
    
            [TestMethod]
        public void HowManyRealDonuts()
    {
      Donut Homer = new Donut();
      Homer.HowMany = 6;
      Assert.AreEqual(6, Homer.HowMany);
    }
        [TestMethod]
            public void HowManyFakeDonuts()
    {
      Donut Homer = new Donut();
      Homer.HowMany = 0;
      Assert.AreEqual(0, Homer.HowMany);
    }
  }
}