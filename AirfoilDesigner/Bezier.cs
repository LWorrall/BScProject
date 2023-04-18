using System;
using System.Collections.Generic;

public class Bezier
{
    private int bezierDegree;
    private List<int> binomialCoeffs = new List<int>();
    private List<double> tList = new List<double>();
    private List<double> tSquaredList = new List<double>();

    // Constructor for the Bezier class.
    // The degree variable is the degree of the curve. 
    public Bezier(int degree)
    {
        this.bezierDegree = degree;

        // initialise the lists' values to 0.
        for (int i = 0; i < bezierDegree; i++)
        {
            binomialCoeffs.Add(0);  // Will store coefficients.
            tList.Add(0);   // Will store values of t.
            tSquaredList.Add(0);    // Will store values of t^2.
        }
        binomialCoeffs[0] = 1;

        // For each degree of the bezier curve...
        for (int i = 1; i <= bezierDegree; i++)
        {
            int initialValue = binomialCoeffs[0];
            for (int j = 1; j < i; j++)
            {
                // Calculate each binomial coefficient for each element in the list.
                // Then update the list with the correct value.
                int prevValue = binomialCoeffs[j];
                binomialCoeffs[j] = initialValue + binomialCoeffs[j];
                initialValue = prevValue;
            }
        }
        // The 'binomialCoeffs' list contains binomial coefficients for the curve to the given degree.
        // THe coefficients will be used in the 'Interpolate' method
    }

    // The 'Interpolate' method will calculate the weighted sum of control points.
    // The 'controlPoints' list is a list of control points for the Bezier curve.
    // The 'interpolationPoints' variable is the number of points to be interpolated.
    public List<double> Interpolate(List<double> controlPoints, int interpolationPoints)
    {
        // Store the interpolated points in the 'outputPoints' list.
        List<double> outputPoints = new List<double>();

        for (int i = 0; i <= interpolationPoints; i++)
            outputPoints.Add(0);

        double stepSize = 1 / (double)interpolationPoints;    // Calculate step size.
        double t = 0;
        outputPoints[0] = controlPoints[0];
        
        for (int i = 1; i <= interpolationPoints; i++)
        {
            // Increment 't' by the step size and calculate its complement, 'tComplement'.
            t += stepSize;
            double tComplement = 1 - t;
            double tTemp = 1;
            double tSquaredTemp = 1;
            for (int j = 0; j < bezierDegree; j++)
            {
                // Calculate values that will be added to the lists by using 't' and 'tComplement'.
                tList[j] = tTemp;
                tSquaredList[bezierDegree - j - 1] = tSquaredTemp;
                tTemp *= t;
                tSquaredTemp *= tComplement;
            }
            outputPoints[i] = 0;
            for (int j = 0; j < bezierDegree; j++)
            {
                // Iterate each control point and multiply them by the values from each list.
                outputPoints[i] += controlPoints[j] * tSquaredList[j] * tList[j] * binomialCoeffs[j];
            }
        }
        return outputPoints;
    }
}