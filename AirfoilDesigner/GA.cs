using System;
using AForge.Genetic;


namespace AirfoilDesigner
{
    public class GA
    {
        public static int arrayLen { get; set; }    // Default 50
        public static int arrayMaxVal { get; set; } // Default 150000
        public static void UpdateArrayLen(int x) { arrayLen = x; }
        public static void UpdateArrayMaxVal(int x) { arrayMaxVal = x; }

        // Instanciating objects and creating properties.
        // The two variables in the constructor are for the chromosome's array length,
        // and the maximum value the array elements can be.
        public static ShortArrayChromosome InitialAgent = new ShortArrayChromosome(arrayLen, arrayMaxVal);
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

            ShortArrayChromosome bestAgent = Population.BestChromosome as ShortArrayChromosome;
            double bestValue = FitnessFunction.Translate(bestAgent);

            // Evaluate the fitness of the best agent
            double bestFitness = FitnessFunction.EvaluateShortArrayChromosome(bestAgent);

            // Display the values on the labels in the window.
            Program.form1.lblGenNum.Text = $"Generation Number: {GenerationNumber}";
        }
    }

    public class LiftMaximiser : OptimizationFunction1D
    {
        public LiftMaximiser() : base(new AForge.Range(0, 150000)) { }

        int airfoilCounter = 0;

        public double EvaluateShortArrayChromosome(ShortArrayChromosome chromosome)
        {
            // Cast chromosome to ShortArrayChromosome
            ushort[] shortArray = (chromosome as ShortArrayChromosome).Value;
            double[] parameters = Array.ConvertAll(shortArray, x => (double)x);

            // Calculate fitness based on the optimization function
            double fitness = OptimizationFunction(parameters);

            return fitness;
        }

        public override double OptimizationFunction(double[] x)
        {
            airfoilCounter++;


            // Generate airfoil based on chromosome parameters
            ShortArrayChromosome chromosome = new ShortArrayChromosome(new short[] { (short)x });
            double[] parameters = chromosome.Value;

            // ... your code to generate the airfoil based on the parameters ...

            // Test airfoil and generate log file
            // ... your code to test the airfoil and generate the log file ...

            // Calculate average lift to drag ratio
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
        public override double Evaluate(IChromosome chromosome)
        {
            // Cast chromosome to ShortArrayChromosome
            ShortArrayChromosome shortArrayChromosome = chromosome as ShortArrayChromosome;
            short[] genes = chromosome.Value;

            // Calculate fitness based on the optimization function
            double fitness = OptimizationFunction(shortArrayChromosome.Value[0]);

            return fitness;
        }

        public override double Evaluate(IChromosome chromosome)
        {
            ShortArrayChromosome shortChromosome = (ShortArrayChromosome)chromosome;
            short[] genes = shortChromosome.Value;

            // Use the genes to calculate fitness...
        }
    }
}
