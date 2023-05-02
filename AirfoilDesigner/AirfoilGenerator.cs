using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirfoilDesigner
{
    public class AirfoilGenerator
    {
        // This code makes use of the Bezier code to generate aerofoils.
        public static void GenAirfoil(double[] genParams, string name)
        {
            List<double> upperX = new List<double>() { 0, 0, 0.25, 0.5, 0.75, 1 };
            List<double> lowerX = new List<double>() { 0, 0, 0.25, 0.5, 0.75, 1 };
            List<double> upperY = new List<double>() { 0, 0, 0, 0, 0, 0 };
            List<double> lowerY = new List<double>() { 0, 0, 0, 0, 0, 0 };

            // Values for leading edge.
            upperY.Insert(1, genParams[0]);
            lowerY.Insert(1, -genParams[1]);

            // Values for camber.
            // Camber  is the distance between the chord and the centre line of the airfoil.
            upperY.Insert(2, (genParams[2] + genParams[5]));
            upperY.Insert(3, (genParams[3] + genParams[6]));
            upperY.Insert(4, (genParams[4] + genParams[7]));

            // Values for thickness.
            // Thickness is the max distance between the edges of the airfoil
            lowerY.Insert(2, (genParams[2] - genParams[5]));
            lowerY.Insert(3, (genParams[3] - genParams[6]));
            lowerY.Insert(4, (genParams[4] - genParams[7]));

            // Generate an airfoil using the bezier function with 6 degrees.
            int interpolationPoints = 50;
            Bezier BezierCurve = new Bezier(6);

            List<double> bezierUpperX = BezierCurve.Interpolate(upperX.ToList(), interpolationPoints);
            List<double> bezierUpperY = BezierCurve.Interpolate(upperY.ToList(), interpolationPoints);
            List<double> bezierLowerX = BezierCurve.Interpolate(lowerX.ToList(), interpolationPoints);
            List<double> bezierLowerY = BezierCurve.Interpolate(lowerY.ToList(), interpolationPoints);

            // Create a new numbered .dat file and save the coordinates from the bezier curves into the file.
            StreamWriter airfoilCoordsFile = new StreamWriter($"{name}.dat");
            
            airfoilCoordsFile.WriteLine(name);
            for (int i = interpolationPoints; i > 0; i--)
            {
                // Write the coordinates into the file as floating point numbers to 6dp.
                airfoilCoordsFile.Write(" {0:F6}    {1:F6}\n", bezierUpperX[i], bezierUpperY[i]);
            }
            for (int i = 0; i < interpolationPoints + 1; i++)
            {
                airfoilCoordsFile.Write(" {0:F6}    {1:F6}\n", bezierLowerX[i], bezierLowerY[i]);
            }
            airfoilCoordsFile.Close();
        }
    }
}
