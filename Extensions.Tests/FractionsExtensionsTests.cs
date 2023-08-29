using Fractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VV.Fractions.Extensions;

namespace FractionsExtensions.Tests;

[TestClass]
public class FractionsExtensionsTests
{
    /// <summary>
    /// Test for extension method Revert(). 
    /// </summary>
    /// <param name="numeratorInput"></param>
    /// <param name="denominatorInput"></param>
    /// <param name="numeratorExpected"></param>
    /// <param name="denominatorExpected"></param>
    [DataTestMethod]
    [DynamicData(nameof(RevertFraction_Successfuly_TestData), DynamicDataSourceType.Method)]

    public void RevertFraction_Successfuly(
        int numeratorInput,
        int denominatorInput,
        int numeratorExpected,
        int denominatorExpected)
    {
        //Arrange
        var fr = new Fraction(numeratorInput, denominatorInput);

        //Act
        Fraction fraction = fr.Revert();

        //Assert
        Assert.AreEqual(fraction.Numerator, numeratorExpected, "numerator is not reverted");
        Assert.AreEqual(fraction.Denominator, denominatorExpected, "denominator is not reverted");
    }

    private static IEnumerable<object[]> RevertFraction_Successfuly_TestData()
    {
        yield return new RevertFraction_Successfuly_TestData2Type(3, 6, 2, 1).ToObjectArray(); 
        yield return new RevertFraction_Successfuly_TestData2Type(-1, 2, -2, 1).ToObjectArray();
        yield return new RevertFraction_Successfuly_TestData2Type(-3, -4, 4, 3).ToObjectArray();
        yield return new RevertFraction_Successfuly_TestData2Type(1, -5, -5, 1).ToObjectArray(); 
    }

    private struct RevertFraction_Successfuly_TestData2Type
    {
        public int NumeratorInput { get; set; }
        public int DenominatorInput { get; set; }
        public int NumeratorExpected { get; set; }
        public int DenominatorExpected { get; set; }

        public RevertFraction_Successfuly_TestData2Type(int numInput, int denInput, int numExp, int denExp)
        {
            NumeratorInput = numInput;
            DenominatorInput = denInput;
            NumeratorExpected = numExp;
            DenominatorExpected = denExp;
        }

        public object[] ToObjectArray() =>
            new object[] { NumeratorInput, DenominatorInput, NumeratorExpected, DenominatorExpected };
    }
}
