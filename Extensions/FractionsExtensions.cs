namespace Fractions.Extensions;

/// <summary>
/// Implents extension method Revert().
/// </summary>
public static class FractionsExtensions
{
    /// <summary>
    /// Swaps numerator and denominator of the passed fraction and returns a new fraction.
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