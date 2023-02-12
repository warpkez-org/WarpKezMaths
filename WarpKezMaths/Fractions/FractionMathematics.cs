using WarpKezMaths.Models;

namespace WarpKezMaths.Fractions;


public class FractionMathematics
{
    public static FractionModel ComplexFraction(CompoundFractionModel compoundFraction)
    {
        return new FractionModel
        {
            numerator = compoundFraction.unit * compoundFraction.denominator + compoundFraction.numerator,
            denominator = compoundFraction.denominator
        };
    }

    public static FractionModel ComplexFraction(int Unit, int Numerator, int Denominator)
    {
        return new FractionModel
        {
            numerator = Unit * Denominator + Numerator,
            denominator = Denominator
        };
    }

    public static CompoundFractionModel CompoundFraction(FractionModel Fraction)
    {
        int _unit = Math.Abs(Fraction.numerator / Fraction.denominator);

        return new()
        {
            unit = _unit,
            numerator = Fraction.numerator - _unit * Fraction.denominator,
            denominator = Fraction.denominator
        };
    }

    public static CompoundFractionModel CompoundFraction(int Numerator, int Denominator)
    {
        int _unit = Math.Abs(Numerator / Denominator);

        return new()
        {
            unit = _unit,
            numerator = Numerator - _unit * Denominator,
            denominator = Denominator
        };
    }

    public static CompoundFractionModel SimplifyFraction(int Numerator, int Denominator)
    {
        int HighComDivisor = 0;
        int[] values = new int[2];
        CompoundFractionModel simplifiedFraction = new();

        // If the numerator is 0 why are we even here then?
        if (Numerator > 0)
        {
            for (int _HighComDivisor = 1; _HighComDivisor <= Denominator; _HighComDivisor++)
            {
                // Check for highest common denominator if both have no remainder than _HighComDivisor is a common divisor
                if (Numerator % _HighComDivisor == 0 && Denominator % _HighComDivisor == 0)
                {
                    HighComDivisor = _HighComDivisor;
                }

                // Test if dividing by zero otherwise return the simplified fraction
                if (HighComDivisor == 0)
                {
                    values[0] = HighComDivisor;
                    values[1] = HighComDivisor;
                }
                else
                {
                    // Divide both the numerator and the denominator by the highest common divisor
                    values[0] = Numerator / HighComDivisor;
                    values[1] = Denominator / HighComDivisor;
                }
            }
        }
        else
        {
            values[0] = Numerator;
            values[1] = Denominator;
        }

        if (values[0] > values[1])
        {
            int unit = Math.Abs(values[0] / values[1]);
            int newNumerator = values[0] - unit * values[1];
            simplifiedFraction.unit = unit;
            simplifiedFraction.numerator = newNumerator;
            simplifiedFraction.denominator = values[1];
        }
        else
        {
            simplifiedFraction.unit = 0;
            simplifiedFraction.numerator = values[0];
            simplifiedFraction.denominator = values[1];
        }

        return simplifiedFraction;
    }
}