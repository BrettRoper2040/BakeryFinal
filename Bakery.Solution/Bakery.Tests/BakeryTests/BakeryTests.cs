using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryBread;

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
  }
}