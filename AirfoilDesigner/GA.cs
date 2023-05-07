using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using AForge.Genetic;


namespace AirfoilDesigner
{
    public class GA
    {
        // Instanciating objects and creating properties.
        public static void UpdateMutationRate(string value)
        { Population.MutationRate = Convert.ToDouble(value); }

        public static void UpdateCrossoverRate(string value)
        { Population.CrossoverRate = Convert.ToDouble(value); }

        public static ShortArrayChromosome InitialAgent = new ShortArrayChromosome(8, 100);

        public static AirfoilFitness FitnessFunction = new AirfoilFitness();
        
        // Use elite selection; a limited number of the best agents are passed into the next generation.
        //public static EliteSelection SelectionMethod = new EliteSelection();

        public static int GenerationNumber { get; set; }
        public static string BestAerofoil { get; set; }
        public static double BestFitness { get; set; }
        public static int ChromosomeNumber { get; set; }
        public static Population Population { get; set; }
        
        // Function to assign which selection method will be used based on user input.
        public static ISelectionMethod ChooseSelection(int selectionIndex)
        {
            switch(selectionIndex)
            {
                case 0:
                    EliteSelection eliteSelectionMethod = new EliteSelection();
                    return eliteSelectionMethod;
                case 1:
                    RankSelection rankSelectionMethod = new RankSelection();
                    return rankSelectionMethod;
                case 2:
                    RouletteWheelSelection rouletteSelectionMethod = new RouletteWheelSelection();
                    return rouletteSelectionMethod;
            }
            return null;
        }

        public static void GenPop()
        {
            var p = Program.form1;

            
            // Create a new genetic population.
            Population = new Population(
                Convert.ToInt32(p.txtPopSize.Text), // This value is the population size.
                InitialAgent,
                FitnessFunction,
                ChooseSelection(p.cmbSelectionMethod.SelectedIndex));

            UpdateMutationRate(p.txtMutationRate.Text);
            UpdateCrossoverRate(p.txtCrossoverRate.Text);

            GenerationNumber = 0;   // Reset the generation counter to 0.
            BestAerofoil = "";      //Clear best aerofoil.
            BestFitness = 0;        // Reset the best fitness to 0.
            ChromosomeNumber = 0;   // Reset the chromosome counter to 0.

        }

        public static void Run1Epoch()
        {
            Population.MutationRate = Convert.ToDouble(Program.form1.txtMutationRate.Text);
            Population.CrossoverRate = Convert.ToDouble(Program.form1.txtCrossoverRate.Text);
            
            // Run one epoch.

            GenerationNumber++;
            Program.form1.lblGenNum.Text = $"Generation Number: {GenerationNumber}";
            // The 'RunEpoch' method performs crossover, mutation and selection.
            // THe mutation rate is specified by Population.MutationRate, which is 0.1 by default.
            Debug.WriteLine(Population.MutationRate);
            Population.RunEpoch();  // This function runs crossover, mutation, and selection.

            ShortArrayChromosome bestAgent = Population.BestChromosome as ShortArrayChromosome;
            double bestValue = FitnessFunction.Evaluate(bestAgent);
        }

        public static void testAirfoil()
        {
            // This method will load the airfoil file created by the GenAirfoil method into xFoil.
            // The streamwriter enters commands into xFoil to run a series of tests, and generate a log file.
            string xFoilPath = "xfoilP4.exe";
            string name = Convert.ToString(ChromosomeNumber);
            Process xFoil = new Process();
            xFoil.StartInfo.FileName = xFoilPath;
            xFoil.StartInfo.CreateNoWindow = true;
            xFoil.StartInfo.RedirectStandardInput = true;

            xFoil.Start();

            var p = Program.form1;
            using (StreamWriter sw = xFoil.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine($"load {name}.dat");
                    sw.WriteLine("oper"); // Direct operating points mode
                    sw.WriteLine("vpar"); // Change BL parameters
                    sw.WriteLine($"n {p.txtCritExponent.Text}"); // Change critical amplification exponent
                    sw.WriteLine(" ");
                    sw.WriteLine($"visc {p.txtReynolds.Text}"); // Toggle to viscous mode and set Reynold's number
                    sw.WriteLine("pacc"); // Toggle auto point accumulation to active polar
                    sw.WriteLine($"{name}.log"); // Polar save filename
                    sw.WriteLine(" ");
                    sw.WriteLine($"aseq {p.txtAlphaStart.Text} {p.txtAlphaEnd.Text} {p.txtAlphaIncrement.Text}"); // Prescribe a series of alphas
                    sw.WriteLine(" ");
                    sw.WriteLine("quit"); 
                }
            }
        }

        public static double CalculateLDRatio()
        {
            string name = Convert.ToString(ChromosomeNumber);
            string[] lines;
            if (File.Exists($"{name}.log"))
            {
                lines = File.ReadAllLines($"{name}.log");
            }
            else
            {
                Thread.Sleep(500);
                lines = File.ReadAllLines($"{name}.log");
            }

            var lDRatioList = new List<double>();
            Debug.WriteLine($"Log file length: {lines.Length}");


            for (int i = 12; i < lines.Length; i++)
            {
                // Get the values in the .log file by going line by line and getting only the numbers.
                string[] words = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                // Calculate a ratio of lift to drag from the values.
                double ldratio = Convert.ToDouble(words[1]) / Convert.ToDouble(words[2]);
                lDRatioList.Add(ldratio);
                Array.Clear(words);
            }

            if (lDRatioList.Count == 0)
            {
                // If the list contains no values, return 0
                return 0;
            }

            // The greater the value of lift to drag ratio, the better the chromosome.
            double average = Queryable.Average(lDRatioList.AsQueryable());
            if (average > BestFitness)
            {
                BestAerofoil = name;
                Program.form1.lblBestAerofoilNum.Text = $"{BestAerofoil}";
                BestFitness = average;
                Program.form1.lblBestFitness.Text = $"Best Fitness: {Convert.ToString(BestFitness)}";
            }
            return average;
        }

        public static List<double> Normalise(IChromosome chromosome)
        {
            // Method to normalise the values given by the chromosome into values that can be used by the program.
            double[] maxRange = { 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1, 0.1 };
            double[] minRange = { 0.01, 0.01, 0.0, 0.0, 0.0, 0.01, 0.01, 0.01 };
            // Cast the chromosome to the appropriate type
            ShortArrayChromosome shortArrayChromosome = (ShortArrayChromosome)chromosome;
            ushort[] chromosomeValues = shortArrayChromosome.Value;

            List<double> normalised = new List<double>();

            // Normalise the chromosomes' values into decimal values ranging between minRange and maxRange.
            for (int i = 0; i < chromosomeValues.Length; i++)
            {
                double currentValue;
                currentValue = Convert.ToDouble(chromosomeValues[i]) / 1000;
                // Limit the value to the range set by minRange and maxRange.
                if (currentValue > maxRange[i])
                    currentValue = maxRange[i];
                if (currentValue < minRange[i])
                    currentValue = minRange[i];
                normalised.Add(currentValue);
            }
            return normalised;
        }

        public class AirfoilFitness : IFitnessFunction
        {
            public double Evaluate(IChromosome chromosome)
            {
                List<double> normalised = Normalise(chromosome);
                
                GA.ChromosomeNumber++;
                // Pass in the normalised values as parameters for generating an airfoil.
                AirfoilGenerator.GenAirfoil(normalised.ToArray(), Convert.ToString(GA.ChromosomeNumber));
                testAirfoil();
                // Calculate the fitness score and return it.
                return CalculateLDRatio();
            }
        }
    }
}
