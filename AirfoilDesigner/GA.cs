using System;
using AForge.Genetic;

namespace AirfoilDesigner
{
    public class GA
    {
        // Instanciating objects and creating properties.
        public static BinaryChromosome InitialAgent = new BinaryChromosome(60);
        public static LiftMaximiser FitnessFunction = new LiftMaximiser();
        public static EliteSelection SelectionMethod = new EliteSelection();

        public static int GenerationNumber { get; set; }
        public static Population Population { get; set; }

        public static void GenPop()
        {
            // Create a new genetic population.
            Population population = new Population(
                10, // This value is the population size.
                InitialAgent,
                FitnessFunction,
                SelectionMethod);

            GenerationNumber = 0;   // Reset the generation counter to 0.
        }

        public static void Run1Epoch()
        {
            // Run one epoch.

            GenerationNumber++;
            Population.RunEpoch();

            BinaryChromosome bestAgent = Population.BestChromosome as BinaryChromosome;
            double bestValue = FitnessFunction.Translate(bestAgent);

            // Display the values on the labels in the window.
            Program.form1.lblGenNum.Text = $"Generation Number: {GenerationNumber}";
        }
    }

    public class LiftMaximiser : OptimizationFunction1D
    {
        public LiftMaximiser() : base( new AForge.Range( 0, 15 ) ) { }
        // The range specifies the range of values that the chromosome can have.

        int airfoilCounter = 0;
        public override double OptimizationFunction(double x) // x is what the chromosome's input value.
        {
            airfoilCounter++;   // Counter will be used to number each airfoil file.

            // Needs code to take each chromosome and generate an airfoil with them, then save it as an airfoil file.



            // Function to calculate the average Lift to Drag ratio of the tested aerofoil.
            string[] lines = System.IO.File.ReadAllLines($"{airfoilCounter}.log");

            var lDRatioList = new List<double>();
            for (int i = 12; i < 26; i++)
            {
                // Get the values in the .log file by going line by line and getting only the numbers.
                string[] words = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                // Calculate a ratio of lift to drag from the values.
                double ldratio = Convert.ToDouble(words[1]) / Convert.ToDouble(words[2]);
                lDRatioList.Add(ldratio);
                Array.Clear(words);
            }
            double average = Queryable.Average(lDRatioList.AsQueryable());
            return average;
        }
    }
}
