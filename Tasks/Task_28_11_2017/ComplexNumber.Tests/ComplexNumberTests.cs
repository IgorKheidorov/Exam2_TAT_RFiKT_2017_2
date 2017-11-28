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

      new object[] {double.MaxValue, double.MaxValue, new ComplexNumber(double.MaxValue, double.MaxValue)},
      new object[] {double.MinValue, double.MinValue, new ComplexNumber(double.MinValue, double.MinValue)},
      new object[] {double.MaxValue, double.MinValue, new ComplexNumber(double.MaxValue, double.MinValue)},
      new object[] {double.MinValue, double.MaxValue, new ComplexNumber(double.MinValue, double.MaxValue)},
      new object[] {0, double.MinValue, new ComplexNumber(0, double.MinValue)},
      new object[] {0, double.MaxValue, new ComplexNumber(0, double.MaxValue)},
      new object[] {double.MaxValue, 0, new ComplexNumber(double.MaxValue, 0)},
      new object[] {double.MinValue, 0, new ComplexNumber(double.MinValue, 0)},
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
      new object[] {new ComplexNumber(int.MaxValue, int.MaxValue)},
      new object[] {new ComplexNumber(int.MinValue, int.MinValue)},
      new object[] {new ComplexNumber(int.MaxValue, int.MinValue)},
      new object[] {new ComplexNumber(int.MinValue, int.MaxValue)},
      new object[] {new ComplexNumber(0, int.MinValue)},
      new object[] {new ComplexNumber(0, int.MaxValue)},
      new object[] {new ComplexNumber(int.MaxValue, 0)},
      new object[] {new ComplexNumber(int.MinValue, 0)},

      new object[] {new ComplexNumber(double.MaxValue, double.MaxValue)},
      new object[] {new ComplexNumber(double.MinValue, double.MinValue)},
      new object[] {new ComplexNumber(double.MaxValue, double.MinValue)},
      new object[] {new ComplexNumber(double.MinValue, double.MaxValue)},
      new object[] {new ComplexNumber(0, double.MinValue)},
      new object[] {new ComplexNumber(0, double.MaxValue)},
      new object[] {new ComplexNumber(double.MaxValue, 0)},
      new object[] {new ComplexNumber(double.MinValue, 0)},
    };

    [Test]
    public void CreateComplexNumberWithDefaultConstructor()
    {
      Assert.AreEqual(new ComplexNumber(), new ComplexNumber(0,0));
    }

    [Test, TestCaseSource("sourceConstructorWithValidParams")]
    public void CreateComplexNumberFromValidParams(double realPart, double imaginaryPart, ComplexNumber complexNumber)
    {
      //Assert.AreSame(new ComplexNumber(realPart, imaginaryPart), complexNumber);
      Assert.AreEqual(new ComplexNumber(realPart, imaginaryPart), complexNumber);
    }

    [Test, TestCaseSource("sourceCopyConstructorWithValidParam")]
    public void CreateComplexNumberFromValidComplexNumber(ComplexNumber complexNumber)
    {
      //Assert.AreSame(new ComplexNumber(complexNumber), complexNumber);
      Assert.AreEqual(new ComplexNumber(complexNumber), complexNumber);
    }
  }
}
