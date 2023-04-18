using System;
using System.Diagnostics;
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
        public static ShortArrayChromosome InitialAgent = new ShortArrayChromosome(8, 100);

        //public static BinaryChromosome InitialAgent = new BinaryChromosome(64);
        //public static LiftMaximiser FitnessFunction = new LiftMaximiser();

        public static AirfoilFitness FitnessFunction = new AirfoilFitness();
        public static EliteSelection SelectionMethod = new EliteSelection();

        public static int GenerationNumber { get; set; }
        public static int ChromosomeNumber { get; set; }
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
            ChromosomeNumber = 0;   // Reset the chromosome counter to 0.
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

        public static void testAirfoil()
        {
            // This method will load the airfoil file created by the GenAirfoil method into xFoil.
            // The streamwriter enters commands into xFoil to run a series of tests, and generate a log file.
            //string xFoilPath = "../../../../xfoilP4.exe";
            string xFoilPath = "xfoilP4.exe";
            string name = Convert.ToString(ChromosomeNumber);
            Process xFoil = new Process();
            xFoil.StartInfo.FileName = xFoilPath;
            xFoil.StartInfo.RedirectStandardInput = true;
            //xFoil.StartInfo.WorkingDirectory = "../../../../";

            xFoil.Start();

            using (StreamWriter sw = xFoil.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine($"load {name}.dat");
                    sw.WriteLine("oper"); // Direct operating points mode
                    sw.WriteLine("vpar"); // Change BL parameters
                    sw.WriteLine("n 9"); // Change critical amplification exponent
                    sw.WriteLine(" ");
                    sw.WriteLine($"visc {Program.form1.txtReynolds.Text}"); // Toggle to viscous mode and set Reynold's number
                    sw.WriteLine("pacc"); // Toggle auto point accumulation to active polar
                    sw.WriteLine($"{name}.log"); // Polar save filename
                    sw.WriteLine(" ");
                    sw.WriteLine("aseq 0.0 15.0 1.0"); // Prescribe a series of alphas
                    sw.WriteLine(" ");
                    sw.WriteLine("quit"); 
                }
            }
        }

        public static double CalculateLDRatio()
        {
            string name = Convert.ToString(ChromosomeNumber);
            string[] lines = System.IO.File.ReadAllLines($"{name}.log");

            var lDRatioList = new List<double>();
            for (int i = 12; i < lines.Length; i++)
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
                double[] maxRange = { 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1 };
                double[] minRange = { 0.01, 0.01, 0.0, 0.0, 0.0, 0.01, 0.01, 0.01 };
                // Cast the chromosome to the appropriate type
                ShortArrayChromosome shortArrayChromosome = (ShortArrayChromosome)chromosome;
                ushort[] chromosomeValues = shortArrayChromosome.Value;


                List<double> normalised = new List<double>();



                // Normalise the chromosomes' values into decimal values ranging between 0 - 1.
                /*
                for (int i = 0; i < chromosomeValues.Length; i++)
                {
                    if (chromosomeValues[i] == 0)
                        chromosomeValues[i] = 1;
                    
                        normalised.Add( Convert.ToDouble($"0.0{Convert.ToString(chromosomeValues[i])}"));
                }
                */

                // Normalise the chromosomes' values into decimal values ranging between minRange and 0.1.
                for (int i = 0; i < chromosomeValues.Length; i++)
                {
                    double currentValue;
                    currentValue = Convert.ToDouble(chromosomeValues[i]) / 1000;
                    if (currentValue < minRange[i])
                        currentValue = minRange[i];
                    normalised.Add(currentValue);
                }

                foreach (double item in normalised)
                {
                    Program.form1.txtNormVals.Text += item + Environment.NewLine;
                }
                GA.ChromosomeNumber++;
                // Pass in the normalised values as parameters for generating an airfoil.
                AirfoilGenerator.GenAirfoil(normalised.ToArray(), Convert.ToString(GA.ChromosomeNumber));
                testAirfoil();
                // Calculate the fitness score and return it.
                return CalculateLDRatio();
                //return 1;
            }
        }
    }
}
