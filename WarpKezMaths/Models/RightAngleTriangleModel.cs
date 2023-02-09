
namespace WarpKezMaths.Models;

/// <summary>
/// Model for a Right Angle Triangle
/// </summary>
public class RightAngleTriangleModel
{
    /// <summary>
    /// Hypotenuse and adjacent    
    /// eg /_
    /// </summary>
    public double Angle_A { get; set; }

    /// <summary>
    /// Hypotenuse and opposite    
    /// eg /|
    /// </summary>
    public double Angle_B { get; set; }

    /// <summary>
    /// Adjacent and opposite    
    /// eg _|
    /// </summary>
    public double Angle_C { get; set; } = 90;

    public double Adjacent { get; set; }
    public double Opposite { get; set; }
    public double Hypotenuse { get; set; }
}
