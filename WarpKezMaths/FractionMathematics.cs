
using WarpKezMaths.Models;

namespace WarpKezMaths;

public class FractionMathematics
{
    public static FractionModel ComplexFraction (CompoundFractionModel compoundFraction)
    {
        return new FractionModel
        {
            numerator = (compoundFraction.unit * compoundFraction.denominator) + compoundFraction.numerator,
            denominator = compoundFraction.denominator
        };
    }

    public static FractionModel ComplexFraction (int Unit, int Numerator, int Denominator)
    {
        return new FractionModel
        {
            numerator = (Unit * Denominator) + Numerator,
            denominator = Denominator
        };
    }
}
