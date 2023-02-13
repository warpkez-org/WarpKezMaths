using WarpKezMaths.Models;

namespace WarpKezMaths.Fractions;


public class FractionMathematics
{
    public static FractionModel ComplexFraction(CompoundFractionModel compoundFraction)
    {
        return new FractionModel
        {
            Numerator = compoundFraction.Unit * compoundFraction.Denominator + compoundFraction.Numerator,
            Denominator = compoundFraction.Denominator
        };
    }

    public static FractionModel ComplexFraction(int Unit, int Numerator, int Denominator)
    {
        return new FractionModel
        {
            Numerator = Unit * Denominator + Numerator,
            Denominator = Denominator
        };
    }

    public static CompoundFractionModel CompoundFraction(FractionModel Fraction)
    {
        int _unit = Math.Abs(Fraction.Numerator / Fraction.Denominator);

        return new()
        {
            Unit = _unit,
            Numerator = Fraction.Numerator - _unit * Fraction.Denominator,
            Denominator = Fraction.Denominator
        };
    }

    public static CompoundFractionModel CompoundFraction(int Numerator, int Denominator)
    {
        int _unit = Math.Abs(Numerator / Denominator);

        return new()
        {
            Unit = _unit,
            Numerator = Numerator - _unit * Denominator,
            Denominator = Denominator
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
            simplifiedFraction.Unit = unit;
            simplifiedFraction.Numerator = newNumerator;
            simplifiedFraction.Denominator = values[1];
        }
        else
        {
            simplifiedFraction.Unit = 0;
            simplifiedFraction.Numerator = values[0];
            simplifiedFraction.Denominator = values[1];
        }

        return simplifiedFraction;
    }
}