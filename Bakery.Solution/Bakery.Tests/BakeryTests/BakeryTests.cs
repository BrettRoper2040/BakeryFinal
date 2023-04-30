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
  }
}