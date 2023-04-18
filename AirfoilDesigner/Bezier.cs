using System;
using System.Collections.Generic;

public class Bezier
{
    private int bezierDegree;
    private List<int> binomialCoeffs = new List<int>();
    private List<double> tList = new List<double>();
    private List<double> tSquaredList = new List<double>();

    public Bezier(int degree)
    {
        this.bezierDegree = degree;

        // initialise the lists' values to 0.
        for (int i = 0; i < bezierDegree; i++)
        {
            binomialCoeffs.Add(0);
            tList.Add(0);
            tSquaredList.Add(0);
        }
        binomialCoeffs[0] = 1;


        for (int i = 1; i <= bezierDegree; i++)
        {
            int temp = binomialCoeffs[0];
            for (int j = 1; j < i; j++)
            {
                int temp2 = binomialCoeffs[j];
                binomialCoeffs[j] = temp + binomialCoeffs[j];
                temp = temp2;
            }
        }
    }

    public List<double> Interpolate(List<double> coefs, int n)
    {
        List<double> output = new List<double>();
        for (int i = 0; i <= n; i++)
        {
            output.Add(0);
        }
        double step = 1.0 / (double)n;
        double t = 0;
        output[0] = coefs[0];
        for (int i = 1; i <= n; i++)
        {
            t += step;
            double tt = 1.0 - t;
            double ttemp = 1.0;
            double tttemp = 1.0;
            for (int j = 0; j < bezierDegree; j++)
            {
                tList[j] = ttemp;
                tSquaredList[bezierDegree - j - 1] = tttemp;
                ttemp *= t;
                tttemp *= tt;
            }
            output[i] = 0;
            for (int j = 0; j < bezierDegree; j++)
            {
                output[i] += coefs[j] * tSquaredList[j] * tList[j] * binomialCoeffs[j];
            }
        }
        return output;
    }
}

/*
public class Program
{
    public static void Main()
    {
        Bezier MyBezier = new Bezier(5);
        List<double> bezierout = MyBezier.Interpolate(new List<int>() { 0, 3, 2, 1, 0 }, 100);
        foreach (double d in bezierout)
        {
            Console.WriteLine(d);
        }
    }
}
*/