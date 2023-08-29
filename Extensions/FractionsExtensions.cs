using Fractions;

namespace VV.Fractions.Extensions;

/// <summary>
/// Implements extension method Revert().
/// </summary>
public static class FractionsExtensions
{
    /// <summary>
    /// Flips numerator and denominator of the given fraction.
    /// </summary>
    /// <param name="fraction">Fraction to be revert.</param>
    /// <returns>Returns a new fraction as a result of flipping the given fraction.</returns>
    public static Fraction Revert(this Fraction fraction)
    {
        var numerator = fraction.Denominator;
        var denominator = fraction.Numerator;

        return new Fraction(numerator, denominator);        
    }
}