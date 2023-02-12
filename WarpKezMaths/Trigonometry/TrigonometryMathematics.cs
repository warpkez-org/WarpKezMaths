using WarpKezMaths.Models;

namespace WarpKezMaths.Trigonometry;

public class TrigonometryMathematics
{
    /// <summary>
    /// Calculates the Opposite from the Hypotenuse and Adjacent
    /// </summary>
    /// <param name="hypotenuse"></param>
    /// <param name="adjacent"></param>
    /// <returns>The length of the Opposite line</returns>
    public static double RightAngleTriangleOpposite(double hypotenuse, double adjacent) => Math.Sqrt((hypotenuse * hypotenuse) - (adjacent * adjacent));

    /// <summary>
    /// Calculates the adjacent from the Hypotenyse and Opposite
    /// </summary>
    /// <param name="hypotenuse"></param>
    /// <param name="opposite"></param>
    /// <returns>The length of the Adjacent line</returns>
    public static double RightAngleTriangleAdjacent(double hypotenuse, double opposite) => Math.Sqrt((hypotenuse * hypotenuse) - (opposite * opposite));

    /// <summary>
    /// Calculates the Hypotenuse from Adjacent and Opposite
    /// </summary>
    /// <param name="adjacent"></param>
    /// <param name="opposite"></param>
    /// <returns>The length of the Hypotenuse line</returns>
    public static double RightAngleTriangleHypotenuse(double adjacent, double opposite) => Math.Sqrt((adjacent * adjacent) + (opposite * opposite));

    public static double SinA(double opposite, double hypotenuse) => opposite / hypotenuse;

    public static double CosA(double adjacent, double hypotenuse) => adjacent / hypotenuse;

    public static double TanA(double opposite, double adjacent) => opposite / adjacent;

    public static double ArcSinA(double opposite, double hypotenuse) => Math.Asin(opposite / hypotenuse);

    public static double ArcCosA(double adjacent, double hypotenuse) => Math.Acos(adjacent / hypotenuse);

    public static double ArcTanA(double opposite, double adjacent) => Math.Atan(opposite / adjacent);
}
