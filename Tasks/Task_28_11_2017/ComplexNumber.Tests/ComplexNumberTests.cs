using System;
using NUnit.Framework;

namespace ComplexNumber.Tests
{
  [TestFixture]
  public class ComplexNumberTests
  {
    private static object[] sourceConstructorWithValidParams =
    {
      new object[] {0, 0, new ComplexNumber(0,0)},
      new object[] {1, 1, new ComplexNumber(1,1)},
      new object[] {0, 1, new ComplexNumber(0,1)},
      new object[] {1, 0, new ComplexNumber(1,0)},
      new object[] {-1, -1, new ComplexNumber(-1,-1)},
      new object[] {0, -1, new ComplexNumber(0,-1)},
      new object[] {-1, 0, new ComplexNumber(-1,0)},
      new object[] {-1, 1, new ComplexNumber(-1, 1)},
      new object[] {1,-1, new ComplexNumber(1,-1)},
      new object[] {int.MaxValue, int.MaxValue, new ComplexNumber(int.MaxValue, int.MaxValue)},
      new object[] {int.MinValue, int.MinValue, new ComplexNumber(int.MinValue, int.MinValue)},
      new object[] {int.MaxValue, int.MinValue, new ComplexNumber(int.MaxValue, int.MinValue)},
      new object[] {int.MinValue, int.MaxValue, new ComplexNumber(int.MinValue, int.MaxValue)},
      new object[] {0, int.MinValue, new ComplexNumber(0, int.MinValue)},
      new object[] {0, int.MaxValue, new ComplexNumber(0, int.MaxValue)},
      new object[] {int.MaxValue, 0, new ComplexNumber(int.MaxValue, 0)},
      new object[] {int.MinValue, 0, new ComplexNumber(int.MinValue, 0)},

      new object[] {Double.MaxValue, Double.MaxValue, new ComplexNumber(Double.MaxValue, Double.MaxValue)},
      new object[] {Double.MinValue, Double.MinValue, new ComplexNumber(Double.MinValue, Double.MinValue)},
      new object[] {Double.MaxValue, Double.MinValue, new ComplexNumber(Double.MaxValue, Double.MinValue)},
      new object[] {Double.MinValue, Double.MaxValue, new ComplexNumber(Double.MinValue, Double.MaxValue)},
      new object[] {0, Double.MinValue, new ComplexNumber(0, Double.MinValue)},
      new object[] {0, Double.MaxValue, new ComplexNumber(0, Double.MaxValue)},
      new object[] {Double.MaxValue, 0, new ComplexNumber(Double.MaxValue, 0)},
      new object[] {Double.MinValue, 0, new ComplexNumber(Double.MinValue, 0)},
    };

    private static object[] sourceCopyConstructorWithValidParam =
    {
      new object[] {new ComplexNumber(0,0)},
      new object[] {new ComplexNumber(1,1)},
      new object[] {new ComplexNumber(0,1)},
      new object[] {new ComplexNumber(1,0)},
      new object[] {new ComplexNumber(-1,-1)},
      new object[] {new ComplexNumber(0,-1)},
      new object[] {new ComplexNumber(-1,0)},
      new object[] {new ComplexNumber(-1, 1)},
      new object[] {new ComplexNumber(1,-1)},

      new object[] {new ComplexNumber(Double.MaxValue, Double.MaxValue)},
      new object[] {new ComplexNumber(Double.MinValue, Double.MinValue)},
      new object[] {new ComplexNumber(Double.MaxValue, Double.MinValue)},
      new object[] {new ComplexNumber(Double.MinValue, Double.MaxValue)},
      new object[] {new ComplexNumber(0, Double.MinValue)},
      new object[] {new ComplexNumber(0, Double.MaxValue)},
      new object[] {new ComplexNumber(Double.MaxValue, 0)},
      new object[] {new ComplexNumber(Double.MinValue, 0)},
    };

    private static object[] sourceValidSumTwoComplexNumbers =
    {
      new object[] {new ComplexNumber(0,0),new ComplexNumber(0,0),new ComplexNumber(0,0)},
      new object[] {new ComplexNumber(1,1),new ComplexNumber(1,1),new ComplexNumber(2,2)},
      new object[] {new ComplexNumber(0,1),new ComplexNumber(0,1),new ComplexNumber(0,2)},
      new object[] {new ComplexNumber(1,0),new ComplexNumber(1,0),new ComplexNumber(2,0)},
      new object[] {new ComplexNumber(-1,-1),new ComplexNumber(-1,-1),new ComplexNumber(-2,-2)},
      new object[] {new ComplexNumber(0,-1),new ComplexNumber(0,-1),new ComplexNumber(0,-2)},
      new object[] {new ComplexNumber(-1,0),new ComplexNumber(-1,0),new ComplexNumber(-2,0)},
      new object[] {new ComplexNumber(-1, 1),new ComplexNumber(-1, 1),new ComplexNumber(-2, 2)},
      new object[] {new ComplexNumber(1,-1),new ComplexNumber(1,-1),new ComplexNumber(2,-2)},
      new object[] {new ComplexNumber(-1, 1),new ComplexNumber(1, -1),new ComplexNumber(0, 0)},
      new object[] {new ComplexNumber(1,-1),new ComplexNumber(-1,1),new ComplexNumber(0,0)},

      new object[] {new ComplexNumber(Double.MaxValue, Double.MaxValue),
                    new ComplexNumber(Double.MinValue, Double.MinValue),
                    new ComplexNumber(0, 0)},
      new object[] {new ComplexNumber(Double.MinValue, Double.MinValue),
                    new ComplexNumber(Double.MaxValue, Double.MaxValue),
                    new ComplexNumber(0, 0)},
    };

    private static object[] sourceInvalidSumTwoComplexNumbers =
    {
      new object[] {new ComplexNumber(0, 1),
                    new ComplexNumber(0, Double.MaxValue),
                    new ComplexNumber(0, Double.PositiveInfinity)},
      new object[] {new ComplexNumber(0, -1),
                    new ComplexNumber(0, Double.MinValue),
                    new ComplexNumber(0, Double.NegativeInfinity)},
      new object[] {new ComplexNumber(1, 0),
                    new ComplexNumber(Double.MaxValue, 0),
                    new ComplexNumber(Double.PositiveInfinity,0)},
      new object[] {new ComplexNumber(-1, 0),
                    new ComplexNumber(Double.MinValue, 0),
                    new ComplexNumber(Double.PositiveInfinity,0)},

      new object[] {new ComplexNumber(0, Double.MaxValue),
                    new ComplexNumber(0, 1),
                    new ComplexNumber(0, Double.PositiveInfinity)},
      new object[] {new ComplexNumber(0, Double.MinValue),
                    new ComplexNumber(0, -1),
                    new ComplexNumber(0, Double.NegativeInfinity)},
      new object[] {new ComplexNumber(Double.MaxValue, 0),
                    new ComplexNumber(1, 0),
                    new ComplexNumber(Double.PositiveInfinity,0)},
      new object[] {new ComplexNumber(Double.MinValue, 0),
                    new ComplexNumber(-1, 0),
                    new ComplexNumber(Double.PositiveInfinity,0)},

      new object[] {new ComplexNumber(0, Double.MaxValue),
                    new ComplexNumber(0, Double.MaxValue),
                    new ComplexNumber(0, Double.PositiveInfinity)},
      new object[] {new ComplexNumber(0, Double.MinValue),
                    new ComplexNumber(0, Double.MinValue),
                    new ComplexNumber(0, Double.NegativeInfinity)},
      new object[] {new ComplexNumber(Double.MaxValue, 0),
                    new ComplexNumber(Double.MaxValue, 0),
                    new ComplexNumber(Double.PositiveInfinity,0)},
      new object[] {new ComplexNumber(Double.MinValue, 0),
                    new ComplexNumber(Double.MinValue, 0),
                    new ComplexNumber(Double.PositiveInfinity,0)},

      new object[] {new ComplexNumber(Double.MaxValue, Double.MaxValue),
                    new ComplexNumber(Double.MaxValue, Double.MaxValue),
                    new ComplexNumber(Double.PositiveInfinity, Double.PositiveInfinity)},
      new object[] {new ComplexNumber(Double.MinValue, Double.MinValue),
                    new ComplexNumber(Double.MinValue, Double.MinValue),
                    new ComplexNumber(Double.NegativeInfinity, Double.NegativeInfinity)},
      new object[] {new ComplexNumber(Double.MaxValue, Double.MinValue),
                    new ComplexNumber(Double.MaxValue, Double.MinValue),
                    new ComplexNumber(Double.PositiveInfinity,Double.NegativeInfinity)},
      new object[] {new ComplexNumber(Double.MinValue, Double.MaxValue),
                    new ComplexNumber(Double.MinValue, Double.MaxValue),
                    new ComplexNumber(Double.NegativeInfinity,Double.PositiveInfinity)},
    };

    [Test]
    public void CreateComplexNumberWithDefaultConstructor()
    {
      Assert.AreEqual(new ComplexNumber(), new ComplexNumber(0, 0));
    }

    [Test, TestCaseSource("sourceConstructorWithValidParams")]
    public void CreateComplexNumberFromValidParams(double realPart, double imaginaryPart, ComplexNumber complexNumber)
    {
      Assert.AreEqual(new ComplexNumber(realPart, imaginaryPart), complexNumber);
    }

    [Test, TestCaseSource("sourceCopyConstructorWithValidParam")]
    public void CreateComplexNumberFromValidComplexNumber(ComplexNumber complexNumber)
    {
      Assert.AreEqual(new ComplexNumber(complexNumber), complexNumber);
    }

    [Test, TestCaseSource("sourceValidSumTwoComplexNumbers")]
    public void SumValidComplexNumbers(ComplexNumber firstNumber, ComplexNumber secondNumber, ComplexNumber sum)
    {
      Assert.AreEqual(firstNumber + secondNumber, sum);
    }

    [Test, TestCaseSource("sourceInvalidSumTwoComplexNumbers")]
    public void SumInvalidComplexNumbers(ComplexNumber firstNumber, ComplexNumber secondNumber, ComplexNumber sum)
    {
      Assert.AreEqual(firstNumber + secondNumber, sum);
    }
  }
}
