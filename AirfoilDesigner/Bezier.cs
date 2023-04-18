using System;
using System.Drawing;

public static class Bezier
{
    public static PointF[] GetAirfoilCoordinates(float chord, float thickness, float camber, float camberLocation, float leadingEdgeRadius, int numberOfPoints)
    {
        // Define the control points of the airfoil shape
        float x, y;
        float t = 0;
        PointF[] controlPoints = new PointF[numberOfPoints];
        for (int i = 0; i < numberOfPoints; i++)
        {
            x = chord * t;
            //
            y = (float)(thickness / 2 * (2 * camber * t - t * t - 2 * camberLocation) + 
                (thickness / 10 * (0.2969f * Math.Sqrt(x) - 0.1260f * x - 0.3516f * Math.Pow(x, 2) + 0.2843f * Math.Pow(x, 3) - 0.1015f * Math.Pow(x, 4))));
            controlPoints[i] = new PointF(x, y);
            t += 1.0f / (numberOfPoints - 1);
        }

        // Add the control points for the leading edge radius
        float radius = leadingEdgeRadius / chord;
        controlPoints[0].Y -= radius * thickness / 2;
        controlPoints[numberOfPoints - 1].Y += radius * thickness / 2;
        controlPoints[0].X += radius * chord;
        controlPoints[numberOfPoints - 1].X += radius * chord;

        // Calculate the curve coordinates
        PointF[] airfoilCoordinates = new PointF[numberOfPoints];
        for (int i = 0; i < numberOfPoints; i++)
        {
            float t2 = (float)i / (numberOfPoints - 1);
            airfoilCoordinates[i] = CalculateBezierPoint(t2, controlPoints);
        }

        // Draw the airfoil using Graphics.DrawLines
        using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
        {
            Pen pen = new Pen(Color.Black);
            graphics.DrawLines(pen, airfoilCoordinates);
        }

        return airfoilCoordinates;
    }

    private static PointF CalculateBezierPoint(float t, PointF[] controlPoints)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;

        float x = uu * controlPoints[0].X;
        x += 2 * u * t * controlPoints[1].X;
        x += tt * controlPoints[2].X;

        float y = uu * controlPoints[0].Y;
        y += 2 * u * t * controlPoints[1].Y;
        y += tt * controlPoints[2].Y;

        return new PointF(x, y);
    }
}
