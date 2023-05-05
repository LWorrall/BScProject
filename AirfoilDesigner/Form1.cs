using System.Diagnostics;

namespace AirfoilDesigner
{
    public partial class frmMainWindow : Form
    {
        string xFoilPath = "../../../../xfoilP4.exe";
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void btnRunXFoil_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = xFoilPath;
            p.StartInfo.WorkingDirectory = "../../../../";
            p.Start();
        }

        private void btnAerofoilFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog AeroFoilPath = new OpenFileDialog
            {
                Title = "Select Aerofoil file",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "dat",
                Filter = "Generic data files (*.dat)|*.dat",
            };


            if (AeroFoilPath.ShowDialog() == DialogResult.OK)
                txtAerofoilFile.Text = AeroFoilPath.FileName;
        }

        private void btnLoadAerofoil_Click(object sender, EventArgs e)
        {
            string Aerofoil = txtAerofoilFile.Text;
            Process p = new Process();
            p.StartInfo.FileName = xFoilPath;
            p.StartInfo.WorkingDirectory = "../../../../";
            p.StartInfo.Arguments = $"load {Aerofoil}";
            if (File.Exists(Aerofoil))
                p.Start();
            else
                MessageBox.Show($"No Aerofoil file selected.", "Error");
        }

        private void btnRunTest_Click(object sender, EventArgs e)
        {
            string Aerofoil = txtAerofoilFile.Text;
            if (File.Exists(Aerofoil))
            {
                string name = Path.GetFileNameWithoutExtension(Aerofoil);
                Process xFoil = new Process();
                xFoil.StartInfo.FileName = xFoilPath;
                xFoil.StartInfo.RedirectStandardInput = true;
                xFoil.StartInfo.WorkingDirectory = "../../../../";
                xFoil.Start();

                using (StreamWriter sw = xFoil.StandardInput)
                {
                    if (sw.BaseStream.CanWrite)
                    {
                        sw.WriteLine($"load {Aerofoil}");
                        sw.WriteLine("oper"); // Direct operating points mode
                        sw.WriteLine("vpar"); // Change BL parameters
                        sw.WriteLine("n 9"); // Change critical amplification exponent
                        sw.WriteLine(" ");
                        sw.WriteLine($"visc {txtReynolds.Text}"); // Toggle to viscous mode and set Reynold's number
                        sw.WriteLine("pacc"); // Toggle auto point accumulation to active polar
                        sw.WriteLine($"{name}.log"); // Polar save filename
                        sw.WriteLine(" ");
                        sw.WriteLine("aseq 0.0 15.0 1.0"); // Prescribe a series of alphas
                        sw.WriteLine(" ");
                        sw.WriteLine("quit");
                    }
                }
            }
            else
                MessageBox.Show($"No Aerofoil file selected.", "Error");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLDRatio.Text = String.Empty;
            string Aerofoil = txtAerofoilFile.Text;

            if (File.Exists(Aerofoil))
            {
                string name = Path.GetFileNameWithoutExtension(Aerofoil);
                string[] lines = System.IO.File.ReadAllLines($"{name}.log");
                double highestLDRatio = 0;
                txtLDRatio.AppendText(lines[3]);
                txtLDRatio.AppendText(Environment.NewLine);
                txtLDRatio.AppendText(Environment.NewLine);
                var lDRatioList = new List<double>();

                //for (int i = 12; i < 26; i++)
                for (int i = 12; i < lines.Length; i++)
                {
                    string[] words = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    double ldratio = Convert.ToDouble(words[1]) / Convert.ToDouble(words[2]);
                    lDRatioList.Add(ldratio);
                    txtLDRatio.AppendText($"{words[1]} / {words[2]} = {ldratio}");
                    txtLDRatio.AppendText(Environment.NewLine);
                    Array.Clear(words);
                    if (ldratio > highestLDRatio)
                        highestLDRatio = ldratio;
                }
                txtLDRatio.AppendText(Environment.NewLine);
                txtLDRatio.AppendText($"Highest Lift to Drag Ratio: {highestLDRatio}");
                txtLDRatio.AppendText(Environment.NewLine);
                double average = Queryable.Average(lDRatioList.AsQueryable());
                txtLDRatio.AppendText($"Average of ratios: {average}");
            }
            else
                MessageBox.Show($"No Aerofoil file selected.", "Error");            
        }


        // Code for the GA Tab.

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            txtCritExponent.Text = "9";
            txtReynolds.Text = "40000";
            txtAlphaStart.Text = "0.0";
            txtAlphaEnd.Text = "15.0";
            txtAlphaIncrement.Text = "1.0";
            txtMutationRate.Text = "0.1";
            txtCrossoverRate.Text = "0.75";
            txtPopSize.Text = "10";
            cmbSelectionMethod.SelectedIndex = 0;
        }

        private void btnGenPop_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPopSize.Text, out int intValue))
            {
                // If the population size is less than or equal to 1, disallow it and change it to 10.
                if(Convert.ToInt32(txtPopSize.Text) <= 1)
                    txtPopSize.Text = "10";
                else
                {
                    // If the population size is an integer greater than 0, continue.
                    Task delete = Task.Run(() => {
                        // Delete .dat and .log files of previous aerofoils.
                        foreach (string file in Directory.GetFiles(".", "*.dat"))
                            File.Delete(file);
                        foreach (string file in Directory.GetFiles(".", "*.log"))
                            File.Delete(file);
                    });
                    delete.Wait(-1);

                    GA.GenPop();
                    btnRunEpoch.Enabled = true;
                }
            }
            else
                txtPopSize.Text = "10";
        }

        private void btnRunEpoch_Click(object sender, EventArgs e)
        {
            //txtNormVals.Clear();
            GA.Run1Epoch();
        }

        private void btnXFoilParamsApply_Click(object sender, EventArgs e)
        {
            ValidateNumber(txtCritExponent);
            ValidateNumber(txtReynolds);
            ValidateXfoilInputs(txtAlphaStart);
            ValidateXfoilInputs(txtAlphaEnd);
            ValidateXfoilInputs(txtAlphaIncrement);
        }

        public static void ValidateXfoilInputs(Control control)
        {

            // If the value entered is an integer, concatenate a decimal on the end.
            if (int.TryParse(control.Text, out int intValue))
                control.Text = $"{intValue}.0";
            // If the value is a real number, allow it.
            else if (control.Text.Contains("."))
                control.Text = control.Text;
            // If the value is not an integer or real number, i.e. non-numeric, revert it back to the default value.
            else
            {
                MessageBox.Show("Error: Alpha test values must be real number values.", "Error");
                if (control.Name == "txtAlphaStart")
                    control.Text = "0.0";
                if (control.Name == "txtAlphaEnd")
                    control.Text = "15.0";
                if (control.Name == "txtAlphaIncrement")
                    control.Text = "1.0";
            }
        }

        public static void ValidateNumber(Control control)
        {
            // If the value entered is an integer, concatenate a decimal on the end.
            if (int.TryParse(control.Text, out int intValue))
                control.Text = control.Text;
            else
            {
                MessageBox.Show("Error: Entered value must be an integer.", "Error");
                if (control.Name == "txtCritExponent")
                    control.Text = "9";
                if (control.Name == "txtReynolds")
                    control.Text = "40000";
            }
        }

        public static void ValidateAlgorithmRates(Control control)
        {
            if (double.TryParse(control.Text, out double doubleValue))
            {
                control.Text = $"{doubleValue}";
                // If the values is between 0.1 to 1, allow it.
                if (doubleValue >= 0.1 && doubleValue <= 1)
                    control.Text = $"{doubleValue}";
                else
                {
                    if (control.Name == "txtMutationRate")
                        control.Text = "0.1";
                    if (control.Name == "txtCrossoverRate")
                        control.Text = "0.75";
                }
            }
            // If the value is not an integer or real number, i.e. non-numeric, revert it back to the default value.
            else
            {
                if (control.Name == "txtMutationRate")
                    control.Text = "0.1";
                if (control.Name == "txtCrossoverRate")
                    control.Text = "0.75";
            }
        }

        private void btnApplyMutationRate_Click(object sender, EventArgs e)
        {
            ValidateAlgorithmRates(txtMutationRate);
            ValidateAlgorithmRates(txtCrossoverRate);
        }

        private void lblBestAerofoil_TextChanged(object sender, EventArgs e)
        {
            pctAirfoil.Invalidate();
        }

        private void pctAirfoil_Paint(object sender, PaintEventArgs e)
        {
            string airfoilNumber = lblBestAerofoil.Text;
            AirfoilDrawer.DrawAirfoil(pctAirfoil, airfoilNumber);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        // Function to save generated airfoil files into a new time-stamped folder.
        public static void Save()
        {
            if(File.Exists("1.dat"))
            {
                string formatDateTime = DateTime.Now.ToString("dd.MM.yy HH.mm.ss");
                Directory.CreateDirectory(formatDateTime);
                foreach (string file in Directory.GetFiles(".", "*.dat"))
                    File.Copy(file, $"{formatDateTime}/{file}");
                foreach (string file in Directory.GetFiles(".", "*.log"))
                    File.Copy(file, $"{formatDateTime}/{file}");
                MessageBox.Show($"Aerofoil files saved in folder named: {formatDateTime}.", "Files Saved");
            }
            else
            {
                MessageBox.Show("Error: No aerofoil files to save.", "Errror: No Files");
            }
        }
    }
}