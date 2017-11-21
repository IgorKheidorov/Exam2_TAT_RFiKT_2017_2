using System;
using NUnit.Framework;
using Task1;

namespace Task1.Tests
{
  [TestFixture]
  public class StringConverterTests
  {
    private static object[] SuccessfullConvert =
    {
      new object[] { "0", 0},
      new object[] { "00", 0},
      new object[] {"1",1},
      new object[] { "01", 1},
      new object[] {"+1",1},
      new object[] {"-1", -1},
      new object[] {"2147483647", int.MaxValue},
      new object[] {"-2147483648", int.MinValue},
      new object[] {"2147483646", int.MaxValue - 1},
      new object[] {"-2147483647", int.MinValue + 1}
    };

    private static object[] UnsuccessfullConvertBecauseWrongArgument =
    {
      new object[] {"a"},
      new object[] {"0a"},
      new object[] {"1a"},
      new object[] {"a0"},
      new object[] {"a1"},
      new object[] {"ab"},
      new object[] {"a4c"}
    };

    private static object[] UnsuccessfullConvertBecauseOverflow =
    {
      new object[] {"2147483648"},
      new object[] {"-2147483648"},
      new object[] {"1111111111111111111111111"},
      new object[] {"-11111111111111111111111"},
    };

    [Test, TestCaseSource("SuccessfullConvert")]
    public void ConvertToIntValidStringReturnValidInt(string input, int output)
    {
      Assert.AreEqual(new StringConverter().ConvertToInt(input), output);
    }

    [Test, TestCaseSource("UnsuccessfullConvertBecauseWrongArgument")]
    public void ConvertToIntInvalidStringArgumentException(string input)
    {
      Assert.That(()=>new StringConverter().ConvertToInt(input), Throws.TypeOf<ArgumentException>());
    }

    [Test, TestCaseSource("UnsuccessfullConvertBecauseOverflow")]
    public void ConvertToIntInvalidStringOverflowException(string input)
    {
      Assert.That(() => new StringConverter().ConvertToInt(input), Throws.TypeOf<OverflowException>());
    }
  }
}
