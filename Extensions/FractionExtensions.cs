namespace Fractions.Extensions;

public static class FractionExtensions
{
    /// <summary>
    /// Create a new revert fraction from another fraction.
    /// </summary>
    /// <param name="fraction"></param>
    /// <returns>Return</returns>
    public static Fraction Revert(this Fraction fraction)
    {
        int numerator = fraction.Denominator;
        int denominator = fraction.Numerator;

        return new Fraction(numerator, denominator);        
    }
}