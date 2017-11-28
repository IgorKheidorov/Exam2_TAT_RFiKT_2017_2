using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComplexNumbers.Tests
{
  [TestClass]
  public class ComplexNumberPositiveTests
  {
    [TestMethod]
    public void Compare_twoComplexNumbersWhereFirstIsHigher_positiveValue()
    {
      Assert.AreEqual(1, new ComplexNumber(2, 1).Compare(new ComplexNumber(1, 1)));
    }

    [TestMethod]
    public void Compare_twoComplexNumbersWhereFirstIsLower_negativeValue()
    {
      Assert.AreEqual(-1, new ComplexNumber(1, 1).Compare(new ComplexNumber(-1, 1)));
    }

    [TestMethod]
    public void Sum_twoComplexNumbers_sumValue()
    {
      Assert.AreEqual("2+2i", (new ComplexNumber(1, 1) + new ComplexNumber(1, 1)).ToString());
    }

    [TestMethod]
    public void Multiplication_twoComplexNumbers_multiplicityValue()
    {
      Assert.AreEqual("0+2i", (new ComplexNumber(1, 1) * new ComplexNumber(1, 1)).ToString());
    }

    [TestMethod]
    public void Division_twoComplexNumbers_divisionValue()
    {
      Assert.AreEqual("1+0i", (new ComplexNumber(1, 1) / new ComplexNumber(1, 1)).ToString());
    }

    [TestMethod]
    public void DIfference_twoComplexNumbers_differenceValue()
    {
      Assert.AreEqual("0+0i", (new ComplexNumber(1, 1) - new ComplexNumber(1, 1)).ToString());
    }
  }
}