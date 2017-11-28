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

      new object[] {0, Double.MinValue, new ComplexNumber(0, Double.MinValue)},
      new object[] {0, Double.MaxValue, new ComplexNumber(0, Double.MaxValue)},
      new object[] {Double.MaxValue, 0, new ComplexNumber(Double.MaxValue, 0)},
      new object[] {Double.MinValue, 0, new ComplexNumber(Double.MinValue, 0)},
      new object[] {Double.MaxValue, Double.MaxValue, new ComplexNumber(Double.MaxValue, Double.MaxValue)},
      new object[] {Double.MinValue, Double.MinValue, new ComplexNumber(Double.MinValue, Double.MinValue)},
      new object[] {Double.MaxValue, Double.MinValue, new ComplexNumber(Double.MaxValue, Double.MinValue)},
      new object[] {Double.MinValue, Double.MaxValue, new ComplexNumber(Double.MinValue, Double.MaxValue)},
    };

    private static object[] sourceConstructorWithInvalidParams =
    {
      new object[] {0, Double.MinValue - 1, new ComplexNumber(0, Double.NegativeInfinity)},
      new object[] {0, Double.MaxValue + 1, new ComplexNumber(0, Double.PositiveInfinity)},
      new object[] {Double.MaxValue + 1, 0, new ComplexNumber(Double.PositiveInfinity, 0)},
      new object[] {Double.MinValue - 1, 0, new ComplexNumber(Double.NegativeInfinity, 0)},
      new object[] {Double.MaxValue + 1, Double.MaxValue, new ComplexNumber(Double.PositiveInfinity, Double.MaxValue)},
      new object[] {Double.MaxValue, Double.MaxValue + 1, new ComplexNumber(Double.MaxValue, Double.PositiveInfinity)},
      new object[] {Double.MinValue - 1, Double.MinValue, new ComplexNumber(Double.NegativeInfinity, Double.MinValue)},
      new object[] {Double.MinValue, Double.MinValue - 1, new ComplexNumber(Double.MinValue, Double.NegativeInfinity)},
      new object[] {Double.MinValue - 1, Double.MaxValue + 1, new ComplexNumber(Double.NegativeInfinity, Double.PositiveInfinity)},
      new object[] {Double.MinValue - 1, Double.MinValue - 1, new ComplexNumber(Double.NegativeInfinity, Double.NegativeInfinity)},
      new object[] {Double.MaxValue + 1, Double.MaxValue + 1, new ComplexNumber(Double.PositiveInfinity, Double.PositiveInfinity)},
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

    private static object[] sourceValidDiffTwoComplexNumbers =
    {
      new object[] {new ComplexNumber(0,0),new ComplexNumber(0,0),new ComplexNumber(0,0)},
      new object[] {new ComplexNumber(1,1),new ComplexNumber(1,1),new ComplexNumber(0,0)},
      new object[] {new ComplexNumber(0,1),new ComplexNumber(0,1),new ComplexNumber(0,0)},
      new object[] {new ComplexNumber(1,0),new ComplexNumber(1,0),new ComplexNumber(0,0)},
      new object[] {new ComplexNumber(-1,-1),new ComplexNumber(-1,-1),new ComplexNumber(0,0)},
      new object[] {new ComplexNumber(0,-1),new ComplexNumber(0,-1),new ComplexNumber(0,0)},
      new object[] {new ComplexNumber(-1,0),new ComplexNumber(-1,0),new ComplexNumber(0,0)},
      new object[] {new ComplexNumber(-1, 1),new ComplexNumber(-1, 1),new ComplexNumber(0, 0)},
      new object[] {new ComplexNumber(1,-1),new ComplexNumber(1,-1),new ComplexNumber(0,0)},
      new object[] {new ComplexNumber(-1, 1),new ComplexNumber(1, -1),new ComplexNumber(-2, 2)},
      new object[] {new ComplexNumber(1,-1),new ComplexNumber(-1,1),new ComplexNumber(2,-2)},

      new object[] {new ComplexNumber(Double.MaxValue, Double.MaxValue),
                    new ComplexNumber(Double.MaxValue, Double.MaxValue),
                    new ComplexNumber(0, 0)},
      new object[] {new ComplexNumber(Double.MinValue, Double.MinValue),
                    new ComplexNumber(Double.MinValue, Double.MinValue),
                    new ComplexNumber(0, 0)},
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

    /// <summary>
    /// All numbers must lead to infinity, but some tests do not fix this
    /// </summary>
    [Test, TestCaseSource("sourceConstructorWithInvalidParams")]
    public void CreateComplexNumberFromInvalidParams(double realPart, double imaginaryPart, ComplexNumber complexNumber)
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

    /// <summary>
    /// All sums of numbers must lead to infinity, but some tests do not fix this
    /// </summary>
    [Test, TestCaseSource("sourceInvalidSumTwoComplexNumbers")]
    public void SumInvalidComplexNumbers(ComplexNumber firstNumber, ComplexNumber secondNumber, ComplexNumber sum)
    {
      Assert.AreEqual(firstNumber + secondNumber, sum);
    }

    [Test, TestCaseSource("sourceValidDiffTwoComplexNumbers")]
    public void DiffValidComplexNumbers(ComplexNumber firstNumber, ComplexNumber secondNumber, ComplexNumber sum)
    {
      Assert.AreEqual(firstNumber - secondNumber, sum);
    }
  }
}
