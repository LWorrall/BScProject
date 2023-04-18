using AirfoilDesigner.Properties;
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

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            txtCritExponent.Text = "9";
            txtReynolds.Text = "40000";
            txtAlphaStart.Text = "0.0";
            txtAlphaEnd.Text = "15.0";
            txtAlphaIncrement.Text = "1.0";

            
            txtPopSize.Text = "10";
            txtArrayLen.Text = "50";
            GA.UpdateArrayLen(Convert.ToInt32(txtArrayLen.Text));
            txtMaxVal.Text = "150000";
            GA.UpdateArrayMaxVal(Convert.ToInt32(txtMaxVal.Text));
        }

        private void btnGenPop_Click(object sender, EventArgs e)
        {
            txtNormVals.Clear();
            GA.GenPop();
            btnRunEpoch.Enabled = true;
        }

        private void btnRunEpoch_Click(object sender, EventArgs e)
        {
            txtNormVals.Clear();
            GA.Run1Epoch();
        }

        private void btnXFoilParamsApply_Click(object sender, EventArgs e)
        {
            ValidateInputs(txtAlphaStart);
            ValidateInputs(txtAlphaEnd);
            ValidateInputs(txtAlphaIncrement);
        }

        public static void ValidateInputs(Control control)
        {
            string prevText = control.Text;
            // If the value entered is an integer, concatenate a decimal on the end.
            if (int.TryParse(control.Text, out int intValue))
                control.Text = $"{intValue}.0";
            // If the value is a real number, allow it.
            else if (double.TryParse(control.Text, out double doubleValue))
                control.Text = $"{doubleValue}";
            // If the value is not an integer or real number, i.e. non-numeric, revert it back to the previous value.
            else
                control.Text = prevText;
        }
    }
}