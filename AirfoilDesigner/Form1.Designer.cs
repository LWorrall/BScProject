namespace AirfoilDesigner
{
    partial class frmMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRunXFoil = new System.Windows.Forms.Button();
            this.lblAerofoilFile = new System.Windows.Forms.Label();
            this.txtAerofoilFile = new System.Windows.Forms.TextBox();
            this.btnAerofoilFile = new System.Windows.Forms.Button();
            this.btnLoadAerofoil = new System.Windows.Forms.Button();
            this.btnRunTest = new System.Windows.Forms.Button();
            this.txtLDRatio = new System.Windows.Forms.TextBox();
            this.btnLDRatio = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblBestAerofoilText = new System.Windows.Forms.Label();
            this.pctAirfoil = new System.Windows.Forms.PictureBox();
            this.grpRates = new System.Windows.Forms.GroupBox();
            this.lblCrossoverRate = new System.Windows.Forms.Label();
            this.txtCrossoverRate = new System.Windows.Forms.TextBox();
            this.btnApplyMutationRate = new System.Windows.Forms.Button();
            this.lblMutationRate = new System.Windows.Forms.Label();
            this.txtMutationRate = new System.Windows.Forms.TextBox();
            this.lblBestFitness = new System.Windows.Forms.Label();
            this.lblBestAerofoil = new System.Windows.Forms.Label();
            this.lblGenNum = new System.Windows.Forms.Label();
            this.grpXFoilTest = new System.Windows.Forms.GroupBox();
            this.btnXFoilParamsApply = new System.Windows.Forms.Button();
            this.txtAlphaStart = new System.Windows.Forms.TextBox();
            this.lblAlphaIncrement = new System.Windows.Forms.Label();
            this.txtAlphaEnd = new System.Windows.Forms.TextBox();
            this.txtAlphaIncrement = new System.Windows.Forms.TextBox();
            this.lblAlphaEnd = new System.Windows.Forms.Label();
            this.lblAlphaStart = new System.Windows.Forms.Label();
            this.lblReynolds = new System.Windows.Forms.Label();
            this.txtReynolds = new System.Windows.Forms.TextBox();
            this.txtCritExponent = new System.Windows.Forms.TextBox();
            this.lblCritExponent = new System.Windows.Forms.Label();
            this.grpPop = new System.Windows.Forms.GroupBox();
            this.btnRunEpoch = new System.Windows.Forms.Button();
            this.lblPopSize = new System.Windows.Forms.Label();
            this.btnGenPop = new System.Windows.Forms.Button();
            this.txtPopSize = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAirfoil)).BeginInit();
            this.grpRates.SuspendLayout();
            this.grpXFoilTest.SuspendLayout();
            this.grpPop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRunXFoil
            // 
            this.btnRunXFoil.Location = new System.Drawing.Point(6, 5);
            this.btnRunXFoil.Name = "btnRunXFoil";
            this.btnRunXFoil.Size = new System.Drawing.Size(75, 23);
            this.btnRunXFoil.TabIndex = 3;
            this.btnRunXFoil.Text = "Run XFoil";
            this.btnRunXFoil.UseVisualStyleBackColor = true;
            this.btnRunXFoil.Click += new System.EventHandler(this.btnRunXFoil_Click);
            // 
            // lblAerofoilFile
            // 
            this.lblAerofoilFile.AutoSize = true;
            this.lblAerofoilFile.Location = new System.Drawing.Point(6, 31);
            this.lblAerofoilFile.Name = "lblAerofoilFile";
            this.lblAerofoilFile.Size = new System.Drawing.Size(116, 15);
            this.lblAerofoilFile.TabIndex = 4;
            this.lblAerofoilFile.Text = "Choose Aerofoil File:";
            // 
            // txtAerofoilFile
            // 
            this.txtAerofoilFile.Location = new System.Drawing.Point(6, 48);
            this.txtAerofoilFile.Name = "txtAerofoilFile";
            this.txtAerofoilFile.Size = new System.Drawing.Size(448, 23);
            this.txtAerofoilFile.TabIndex = 5;
            // 
            // btnAerofoilFile
            // 
            this.btnAerofoilFile.Location = new System.Drawing.Point(460, 48);
            this.btnAerofoilFile.Name = "btnAerofoilFile";
            this.btnAerofoilFile.Size = new System.Drawing.Size(75, 23);
            this.btnAerofoilFile.TabIndex = 6;
            this.btnAerofoilFile.Text = "Browse...";
            this.btnAerofoilFile.UseVisualStyleBackColor = true;
            this.btnAerofoilFile.Click += new System.EventHandler(this.btnAerofoilFile_Click);
            // 
            // btnLoadAerofoil
            // 
            this.btnLoadAerofoil.Location = new System.Drawing.Point(541, 48);
            this.btnLoadAerofoil.Name = "btnLoadAerofoil";
            this.btnLoadAerofoil.Size = new System.Drawing.Size(105, 23);
            this.btnLoadAerofoil.TabIndex = 7;
            this.btnLoadAerofoil.Text = "Load File in XFoil";
            this.btnLoadAerofoil.UseVisualStyleBackColor = true;
            this.btnLoadAerofoil.Click += new System.EventHandler(this.btnLoadAerofoil_Click);
            // 
            // btnRunTest
            // 
            this.btnRunTest.Location = new System.Drawing.Point(6, 77);
            this.btnRunTest.Name = "btnRunTest";
            this.btnRunTest.Size = new System.Drawing.Size(75, 23);
            this.btnRunTest.TabIndex = 8;
            this.btnRunTest.Text = "Run a Test";
            this.btnRunTest.UseVisualStyleBackColor = true;
            this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
            // 
            // txtLDRatio
            // 
            this.txtLDRatio.Location = new System.Drawing.Point(6, 135);
            this.txtLDRatio.Multiline = true;
            this.txtLDRatio.Name = "txtLDRatio";
            this.txtLDRatio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLDRatio.Size = new System.Drawing.Size(279, 287);
            this.txtLDRatio.TabIndex = 9;
            // 
            // btnLDRatio
            // 
            this.btnLDRatio.Location = new System.Drawing.Point(6, 106);
            this.btnLDRatio.Name = "btnLDRatio";
            this.btnLDRatio.Size = new System.Drawing.Size(163, 23);
            this.btnLDRatio.TabIndex = 10;
            this.btnLDRatio.Text = "Calculate Lift to Drag Ratios";
            this.btnLDRatio.UseVisualStyleBackColor = true;
            this.btnLDRatio.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 471);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRunXFoil);
            this.tabPage1.Controls.Add(this.btnLDRatio);
            this.tabPage1.Controls.Add(this.lblAerofoilFile);
            this.tabPage1.Controls.Add(this.txtLDRatio);
            this.tabPage1.Controls.Add(this.btnRunTest);
            this.tabPage1.Controls.Add(this.txtAerofoilFile);
            this.tabPage1.Controls.Add(this.btnAerofoilFile);
            this.tabPage1.Controls.Add(this.btnLoadAerofoil);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(655, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Testing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblBestAerofoilText);
            this.tabPage2.Controls.Add(this.pctAirfoil);
            this.tabPage2.Controls.Add(this.grpRates);
            this.tabPage2.Controls.Add(this.lblBestFitness);
            this.tabPage2.Controls.Add(this.lblBestAerofoil);
            this.tabPage2.Controls.Add(this.lblGenNum);
            this.tabPage2.Controls.Add(this.grpXFoilTest);
            this.tabPage2.Controls.Add(this.grpPop);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(655, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblBestAerofoilText
            // 
            this.lblBestAerofoilText.AutoSize = true;
            this.lblBestAerofoilText.Location = new System.Drawing.Point(365, 50);
            this.lblBestAerofoilText.Name = "lblBestAerofoilText";
            this.lblBestAerofoilText.Size = new System.Drawing.Size(77, 15);
            this.lblBestAerofoilText.TabIndex = 23;
            this.lblBestAerofoilText.Text = "Best Aerofoil:";
            // 
            // pctAirfoil
            // 
            this.pctAirfoil.Location = new System.Drawing.Point(365, 83);
            this.pctAirfoil.Name = "pctAirfoil";
            this.pctAirfoil.Size = new System.Drawing.Size(257, 85);
            this.pctAirfoil.TabIndex = 22;
            this.pctAirfoil.TabStop = false;
            this.pctAirfoil.Paint += new System.Windows.Forms.PaintEventHandler(this.pctAirfoil_Paint);
            // 
            // grpRates
            // 
            this.grpRates.Controls.Add(this.lblCrossoverRate);
            this.grpRates.Controls.Add(this.txtCrossoverRate);
            this.grpRates.Controls.Add(this.btnApplyMutationRate);
            this.grpRates.Controls.Add(this.lblMutationRate);
            this.grpRates.Controls.Add(this.txtMutationRate);
            this.grpRates.Location = new System.Drawing.Point(4, 120);
            this.grpRates.Name = "grpRates";
            this.grpRates.Size = new System.Drawing.Size(175, 107);
            this.grpRates.TabIndex = 5;
            this.grpRates.TabStop = false;
            this.grpRates.Text = "Mutator";
            // 
            // lblCrossoverRate
            // 
            this.lblCrossoverRate.AutoSize = true;
            this.lblCrossoverRate.Location = new System.Drawing.Point(6, 47);
            this.lblCrossoverRate.Name = "lblCrossoverRate";
            this.lblCrossoverRate.Size = new System.Drawing.Size(88, 15);
            this.lblCrossoverRate.TabIndex = 6;
            this.lblCrossoverRate.Text = "Crossover Rate:";
            // 
            // txtCrossoverRate
            // 
            this.txtCrossoverRate.Location = new System.Drawing.Point(103, 44);
            this.txtCrossoverRate.Name = "txtCrossoverRate";
            this.txtCrossoverRate.Size = new System.Drawing.Size(61, 23);
            this.txtCrossoverRate.TabIndex = 5;
            // 
            // btnApplyMutationRate
            // 
            this.btnApplyMutationRate.Location = new System.Drawing.Point(6, 73);
            this.btnApplyMutationRate.Name = "btnApplyMutationRate";
            this.btnApplyMutationRate.Size = new System.Drawing.Size(158, 23);
            this.btnApplyMutationRate.TabIndex = 4;
            this.btnApplyMutationRate.Text = "Apply";
            this.btnApplyMutationRate.UseVisualStyleBackColor = true;
            this.btnApplyMutationRate.Click += new System.EventHandler(this.btnApplyMutationRate_Click);
            // 
            // lblMutationRate
            // 
            this.lblMutationRate.AutoSize = true;
            this.lblMutationRate.Location = new System.Drawing.Point(6, 19);
            this.lblMutationRate.Name = "lblMutationRate";
            this.lblMutationRate.Size = new System.Drawing.Size(85, 15);
            this.lblMutationRate.TabIndex = 1;
            this.lblMutationRate.Text = "Mutation Rate:";
            // 
            // txtMutationRate
            // 
            this.txtMutationRate.Location = new System.Drawing.Point(103, 15);
            this.txtMutationRate.Name = "txtMutationRate";
            this.txtMutationRate.Size = new System.Drawing.Size(61, 23);
            this.txtMutationRate.TabIndex = 2;
            // 
            // lblBestFitness
            // 
            this.lblBestFitness.AutoSize = true;
            this.lblBestFitness.Location = new System.Drawing.Point(365, 65);
            this.lblBestFitness.Name = "lblBestFitness";
            this.lblBestFitness.Size = new System.Drawing.Size(71, 15);
            this.lblBestFitness.TabIndex = 21;
            this.lblBestFitness.Text = "Best Fitness:";
            // 
            // lblBestAerofoil
            // 
            this.lblBestAerofoil.AutoSize = true;
            this.lblBestAerofoil.Location = new System.Drawing.Point(474, 50);
            this.lblBestAerofoil.Name = "lblBestAerofoil";
            this.lblBestAerofoil.Size = new System.Drawing.Size(0, 15);
            this.lblBestAerofoil.TabIndex = 20;
            this.lblBestAerofoil.TextChanged += new System.EventHandler(this.lblBestAerofoil_TextChanged);
            // 
            // lblGenNum
            // 
            this.lblGenNum.AutoSize = true;
            this.lblGenNum.Location = new System.Drawing.Point(365, 21);
            this.lblGenNum.Name = "lblGenNum";
            this.lblGenNum.Size = new System.Drawing.Size(115, 15);
            this.lblGenNum.TabIndex = 19;
            this.lblGenNum.Text = "Generation Number:";
            // 
            // grpXFoilTest
            // 
            this.grpXFoilTest.Controls.Add(this.btnXFoilParamsApply);
            this.grpXFoilTest.Controls.Add(this.txtAlphaStart);
            this.grpXFoilTest.Controls.Add(this.lblAlphaIncrement);
            this.grpXFoilTest.Controls.Add(this.txtAlphaEnd);
            this.grpXFoilTest.Controls.Add(this.txtAlphaIncrement);
            this.grpXFoilTest.Controls.Add(this.lblAlphaEnd);
            this.grpXFoilTest.Controls.Add(this.lblAlphaStart);
            this.grpXFoilTest.Controls.Add(this.lblReynolds);
            this.grpXFoilTest.Controls.Add(this.txtReynolds);
            this.grpXFoilTest.Controls.Add(this.txtCritExponent);
            this.grpXFoilTest.Controls.Add(this.lblCritExponent);
            this.grpXFoilTest.Location = new System.Drawing.Point(6, 245);
            this.grpXFoilTest.Name = "grpXFoilTest";
            this.grpXFoilTest.Size = new System.Drawing.Size(254, 192);
            this.grpXFoilTest.TabIndex = 7;
            this.grpXFoilTest.TabStop = false;
            this.grpXFoilTest.Text = "XFOIL Test Parameters";
            // 
            // btnXFoilParamsApply
            // 
            this.btnXFoilParamsApply.Location = new System.Drawing.Point(150, 161);
            this.btnXFoilParamsApply.Name = "btnXFoilParamsApply";
            this.btnXFoilParamsApply.Size = new System.Drawing.Size(75, 23);
            this.btnXFoilParamsApply.TabIndex = 20;
            this.btnXFoilParamsApply.Text = "Apply";
            this.btnXFoilParamsApply.UseVisualStyleBackColor = true;
            this.btnXFoilParamsApply.Click += new System.EventHandler(this.btnXFoilParamsApply_Click);
            // 
            // txtAlphaStart
            // 
            this.txtAlphaStart.Location = new System.Drawing.Point(187, 74);
            this.txtAlphaStart.Name = "txtAlphaStart";
            this.txtAlphaStart.Size = new System.Drawing.Size(38, 23);
            this.txtAlphaStart.TabIndex = 17;
            // 
            // lblAlphaIncrement
            // 
            this.lblAlphaIncrement.AutoSize = true;
            this.lblAlphaIncrement.Location = new System.Drawing.Point(6, 135);
            this.lblAlphaIncrement.Name = "lblAlphaIncrement";
            this.lblAlphaIncrement.Size = new System.Drawing.Size(157, 15);
            this.lblAlphaIncrement.TabIndex = 17;
            this.lblAlphaIncrement.Text = "Alpha Tests Increment Value:";
            // 
            // txtAlphaEnd
            // 
            this.txtAlphaEnd.Location = new System.Drawing.Point(187, 103);
            this.txtAlphaEnd.Name = "txtAlphaEnd";
            this.txtAlphaEnd.Size = new System.Drawing.Size(38, 23);
            this.txtAlphaEnd.TabIndex = 19;
            // 
            // txtAlphaIncrement
            // 
            this.txtAlphaIncrement.Location = new System.Drawing.Point(187, 132);
            this.txtAlphaIncrement.Name = "txtAlphaIncrement";
            this.txtAlphaIncrement.Size = new System.Drawing.Size(38, 23);
            this.txtAlphaIncrement.TabIndex = 18;
            // 
            // lblAlphaEnd
            // 
            this.lblAlphaEnd.AutoSize = true;
            this.lblAlphaEnd.Location = new System.Drawing.Point(6, 106);
            this.lblAlphaEnd.Name = "lblAlphaEnd";
            this.lblAlphaEnd.Size = new System.Drawing.Size(126, 15);
            this.lblAlphaEnd.TabIndex = 16;
            this.lblAlphaEnd.Text = "Alpha Tests End Angle:";
            // 
            // lblAlphaStart
            // 
            this.lblAlphaStart.AutoSize = true;
            this.lblAlphaStart.Location = new System.Drawing.Point(6, 77);
            this.lblAlphaStart.Name = "lblAlphaStart";
            this.lblAlphaStart.Size = new System.Drawing.Size(130, 15);
            this.lblAlphaStart.TabIndex = 15;
            this.lblAlphaStart.Text = "Alpha Tests Start Angle:";
            // 
            // lblReynolds
            // 
            this.lblReynolds.AutoSize = true;
            this.lblReynolds.Location = new System.Drawing.Point(6, 48);
            this.lblReynolds.Name = "lblReynolds";
            this.lblReynolds.Size = new System.Drawing.Size(108, 15);
            this.lblReynolds.TabIndex = 14;
            this.lblReynolds.Text = "Reynold\'s Number:";
            // 
            // txtReynolds
            // 
            this.txtReynolds.Location = new System.Drawing.Point(187, 45);
            this.txtReynolds.Name = "txtReynolds";
            this.txtReynolds.Size = new System.Drawing.Size(56, 23);
            this.txtReynolds.TabIndex = 13;
            // 
            // txtCritExponent
            // 
            this.txtCritExponent.Location = new System.Drawing.Point(187, 16);
            this.txtCritExponent.Name = "txtCritExponent";
            this.txtCritExponent.Size = new System.Drawing.Size(38, 23);
            this.txtCritExponent.TabIndex = 1;
            // 
            // lblCritExponent
            // 
            this.lblCritExponent.AutoSize = true;
            this.lblCritExponent.Location = new System.Drawing.Point(6, 19);
            this.lblCritExponent.Name = "lblCritExponent";
            this.lblCritExponent.Size = new System.Drawing.Size(175, 15);
            this.lblCritExponent.TabIndex = 0;
            this.lblCritExponent.Text = "Critical Amplification Exponent:";
            // 
            // grpPop
            // 
            this.grpPop.Controls.Add(this.btnRunEpoch);
            this.grpPop.Controls.Add(this.lblPopSize);
            this.grpPop.Controls.Add(this.btnGenPop);
            this.grpPop.Controls.Add(this.txtPopSize);
            this.grpPop.Location = new System.Drawing.Point(6, 6);
            this.grpPop.Name = "grpPop";
            this.grpPop.Size = new System.Drawing.Size(175, 108);
            this.grpPop.TabIndex = 3;
            this.grpPop.TabStop = false;
            this.grpPop.Text = "Population";
            // 
            // btnRunEpoch
            // 
            this.btnRunEpoch.Enabled = false;
            this.btnRunEpoch.Location = new System.Drawing.Point(6, 73);
            this.btnRunEpoch.Name = "btnRunEpoch";
            this.btnRunEpoch.Size = new System.Drawing.Size(158, 23);
            this.btnRunEpoch.TabIndex = 4;
            this.btnRunEpoch.Text = "Run One Epoch";
            this.btnRunEpoch.UseVisualStyleBackColor = true;
            this.btnRunEpoch.Click += new System.EventHandler(this.btnRunEpoch_Click);
            // 
            // lblPopSize
            // 
            this.lblPopSize.AutoSize = true;
            this.lblPopSize.Location = new System.Drawing.Point(6, 19);
            this.lblPopSize.Name = "lblPopSize";
            this.lblPopSize.Size = new System.Drawing.Size(91, 15);
            this.lblPopSize.TabIndex = 1;
            this.lblPopSize.Text = "Population Size:";
            // 
            // btnGenPop
            // 
            this.btnGenPop.Location = new System.Drawing.Point(6, 44);
            this.btnGenPop.Name = "btnGenPop";
            this.btnGenPop.Size = new System.Drawing.Size(158, 23);
            this.btnGenPop.TabIndex = 0;
            this.btnGenPop.Text = "Generate Population";
            this.btnGenPop.UseVisualStyleBackColor = true;
            this.btnGenPop.Click += new System.EventHandler(this.btnGenPop_Click);
            // 
            // txtPopSize
            // 
            this.txtPopSize.Location = new System.Drawing.Point(103, 15);
            this.txtPopSize.Name = "txtPopSize";
            this.txtPopSize.Size = new System.Drawing.Size(61, 23);
            this.txtPopSize.TabIndex = 2;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMainWindow";
            this.Text = "Aerofoil Designer";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAirfoil)).EndInit();
            this.grpRates.ResumeLayout(false);
            this.grpRates.PerformLayout();
            this.grpXFoilTest.ResumeLayout(false);
            this.grpXFoilTest.PerformLayout();
            this.grpPop.ResumeLayout(false);
            this.grpPop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnRunXFoil;
        private Label lblAerofoilFile;
        private TextBox txtAerofoilFile;
        private Button btnAerofoilFile;
        private Button btnLoadAerofoil;
        private Button btnRunTest;
        private TextBox txtLDRatio;
        private Button btnLDRatio;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnGenPop;
        private GroupBox grpPop;
        private Button btnRunEpoch;
        private Label lblPopSize;
        private GroupBox grpXFoilTest;
        private Label lblCritExponent;
        public TextBox txtReynolds;
        private Label lblReynolds;
        private Label lblAlphaIncrement;
        private Label lblAlphaEnd;
        private Label lblAlphaStart;
        public TextBox txtCritExponent;
        public TextBox txtAlphaIncrement;
        public TextBox txtAlphaStart;
        public TextBox txtAlphaEnd;
        private Button btnXFoilParamsApply;
        public Label lblGenNum;
        public TextBox txtPopSize;
        public Label lblBestAerofoil;
        public Label lblBestFitness;
        private GroupBox grpRates;
        private Button btnApplyMutationRate;
        private Label lblMutationRate;
        public TextBox txtMutationRate;
        public Label lblBestAerofoilText;
        private PictureBox pctAirfoil;
        private Label lblCrossoverRate;
        public TextBox txtCrossoverRate;
    }
}