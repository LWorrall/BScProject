using System;
using AForge.Genetic;

namespace AirfoilDesigner
{
    public class GA
    {
        // Instanciating objects and creating properties.
        public static BinaryChromosome InitialAgent = new BinaryChromosome(64);
        public static LiftMaximiser FitnessFunction = new LiftMaximiser();
        public static EliteSelection SelectionMethod = new EliteSelection();

        public static int GenerationNumber { get; set; }

        public static void GenPop()
        {
            Population population = new Population(
                10,
                InitialAgent,
                FitnessFunction,
                SelectionMethod);
        }
    }

    public class LiftMaximiser : OptimizationFunction1D
    {
        public LiftMaximiser() : base( new AForge.Range( 0, 15 ) ) { }

        int airfoilCounter = 0;
        public override double OptimizationFunction(double x)
        {
            
            // Needs code to take each chromosome and generate an airfoil with them, then save it as an airfoil file.

            // Function to calculate the average Lift to Drag ratio of the tested aerofoil.
            airfoilCounter++;   // Counter will be used to number each airfoil file.
            string[] lines = System.IO.File.ReadAllLines($"{airfoilCounter}.log");

            var lDRatioList = new List<double>();
            for (int i = 12; i < 26; i++)
            {
                string[] words = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                double ldratio = Convert.ToDouble(words[1]) / Convert.ToDouble(words[2]);
                lDRatioList.Add(ldratio);
                Array.Clear(words);
            }
            double average = Queryable.Average(lDRatioList.AsQueryable());
            return average;
        }
    }
}
