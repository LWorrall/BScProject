using System;
using AForge.Genetic;


namespace AirfoilDesigner
{
    public class GA
    {
        // Instanciating objects and creating properties.
        public static int arrayLen { get; set; }    // Default 50
        public static int arrayMaxVal { get; set; } // Default 150000
        public static void UpdateArrayLen(int x) { arrayLen = x; }
        public static void UpdateArrayMaxVal(int x) { arrayMaxVal = x; }

        //public static ShortArrayChromosome InitialAgent = new ShortArrayChromosome(arrayLen, arrayMaxVal);
        public static ShortArrayChromosome InitialAgent = new ShortArrayChromosome(50, 150000);

        //public static BinaryChromosome InitialAgent = new BinaryChromosome(64);
        //public static LiftMaximiser FitnessFunction = new LiftMaximiser();

        public static AirfoilFitness FitnessFunction = new AirfoilFitness();
        public static EliteSelection SelectionMethod = new EliteSelection();

        public static int GenerationNumber { get; set; }
        public static Population Population { get; set; }

        public static void GenPop()
        {
            // Create a new genetic population.
            Population = new Population(
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
            double bestValue = FitnessFunction.Evaluate(bestAgent);

            // Display the values on the labels in the window.
            Program.form1.lblGenNum.Text = $"Generation Number: {GenerationNumber}";
        }
    }

    /*
    public class LiftMaximiser : OptimizationFunction1D
    {
        public LiftMaximiser() : base(new AForge.Range(0, 15)) { }
        // The range specifies the range of values that the chromosome can have.

        int airfoilCounter = 0;
        public override double OptimizationFunction(double x) // x is what the chromosome's input value.
        {
            airfoilCounter++;   // Counter will be used to number each airfoil file.

            // Needs code to take each chromosome and generate an airfoil with them, then save it as an airfoil file.

            // Needs code to test airfoil and generate the log file.

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
            // The greater the value of lift to drag ratio, the better the chromosome.
            double average = Queryable.Average(lDRatioList.AsQueryable());
            return average;
        }
    }
    */

    public class AirfoilFitness : IFitnessFunction
    {
        public double Evaluate(IChromosome chromosome)
        {
            // Cast the chromosome to the appropriate type
            ShortArrayChromosome shortArrayChromosome = (ShortArrayChromosome)chromosome;

            // Access the values of the chromosome and perform any calculations necessary

            
            var sum = 0;
            ushort[] chromosomeValues = shortArrayChromosome.Value;
            List<int> normalised = new List<int>(); ;

            // Normalise the chromosomes elements so that the values are between 0 and 1.
            ushort min = chromosomeValues.Min();
            ushort max = chromosomeValues.Max();
            int range = max - min;

            // Subtract the minimum value from each element, and divide each element by the range.
            for (int i = 0; i < chromosomeValues.Length; i++)
            {
                normalised.Add((chromosomeValues[i] - min) / range);
            }

            foreach(int item in normalised) 
            {
                Program.form1.txtNormVals.Text += item + Environment.NewLine;
            }
            //Program.form1.txtNormVals.AppendText(Environment.NewLine);
            //Program.form1.txtNormVals.AppendText(Convert.ToString(normalised));
            //Program.form1.txtNormVals.AppendText(Environment.NewLine);

            // Return the fitness score
            return sum;
        }
    }

}
