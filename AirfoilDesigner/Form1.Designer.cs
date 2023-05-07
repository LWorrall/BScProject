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
            this.tabFunctions = new System.Windows.Forms.TabControl();
            this.tabPageGA = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRunEpoch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenPop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPopSize = new System.Windows.Forms.TextBox();
            this.cmbSelectionMethod = new System.Windows.Forms.ComboBox();
            this.txtCrossoverRate = new System.Windows.Forms.TextBox();
            this.btnApplyMutationRate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMutationRate = new System.Windows.Forms.TextBox();
            this.lblBestAerofoil = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXFoilParamsApply = new System.Windows.Forms.Button();
            this.txtAlphaStart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAlphaEnd = new System.Windows.Forms.TextBox();
            this.txtAlphaIncrement = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReynolds = new System.Windows.Forms.TextBox();
            this.txtCritExponent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pctAirfoil = new System.Windows.Forms.PictureBox();
            this.lblGenNum = new System.Windows.Forms.Label();
            this.lblBestAerofoilNum = new System.Windows.Forms.Label();
            this.lblBestFitness = new System.Windows.Forms.Label();
            this.tabPageTesting = new System.Windows.Forms.TabPage();
            this.btnRunXFoil = new System.Windows.Forms.Button();
            this.btnLDRatio = new System.Windows.Forms.Button();
            this.btnLoadAerofoil = new System.Windows.Forms.Button();
            this.lblAerofoilFile = new System.Windows.Forms.Label();
            this.btnAerofoilFile = new System.Windows.Forms.Button();
            this.txtLDRatio = new System.Windows.Forms.TextBox();
            this.txtAerofoilFile = new System.Windows.Forms.TextBox();
            this.btnRunTest = new System.Windows.Forms.Button();
            this.tabFunctions.SuspendLayout();
            this.tabPageGA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAirfoil)).BeginInit();
            this.tabPageTesting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFunctions
            // 
            this.tabFunctions.Controls.Add(this.tabPageGA);
            this.tabFunctions.Controls.Add(this.tabPageTesting);
            this.tabFunctions.Location = new System.Drawing.Point(4, 6);
            this.tabFunctions.Name = "tabFunctions";
            this.tabFunctions.SelectedIndex = 0;
            this.tabFunctions.Size = new System.Drawing.Size(539, 465);
            this.tabFunctions.TabIndex = 13;
            // 
            // tabPageGA
            // 
            this.tabPageGA.Controls.Add(this.btnSave);
            this.tabPageGA.Controls.Add(this.groupBox1);
            this.tabPageGA.Controls.Add(this.lblBestAerofoil);
            this.tabPageGA.Controls.Add(this.groupBox2);
            this.tabPageGA.Controls.Add(this.pctAirfoil);
            this.tabPageGA.Controls.Add(this.lblGenNum);
            this.tabPageGA.Controls.Add(this.lblBestAerofoilNum);
            this.tabPageGA.Controls.Add(this.lblBestFitness);
            this.tabPageGA.Location = new System.Drawing.Point(4, 24);
            this.tabPageGA.Name = "tabPageGA";
            this.tabPageGA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGA.Size = new System.Drawing.Size(531, 437);
            this.tabPageGA.TabIndex = 0;
            this.tabPageGA.Text = "GA";
            this.tabPageGA.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(266, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save Generated Aerofoils";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRunEpoch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGenPop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPopSize);
            this.groupBox1.Controls.Add(this.cmbSelectionMethod);
            this.groupBox1.Controls.Add(this.txtCrossoverRate);
            this.groupBox1.Controls.Add(this.btnApplyMutationRate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMutationRate);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 224);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genetic Algorithm Parameters";
            // 
            // btnRunEpoch
            // 
            this.btnRunEpoch.Enabled = false;
            this.btnRunEpoch.Location = new System.Drawing.Point(6, 189);
            this.btnRunEpoch.Name = "btnRunEpoch";
            this.btnRunEpoch.Size = new System.Drawing.Size(186, 23);
            this.btnRunEpoch.TabIndex = 4;
            this.btnRunEpoch.Text = "Run One Epoch";
            this.btnRunEpoch.UseVisualStyleBackColor = true;
            this.btnRunEpoch.Click += new System.EventHandler(this.btnRunEpoch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selection Method:";
            // 
            // btnGenPop
            // 
            this.btnGenPop.Enabled = false;
            this.btnGenPop.Location = new System.Drawing.Point(6, 160);
            this.btnGenPop.Name = "btnGenPop";
            this.btnGenPop.Size = new System.Drawing.Size(186, 23);
            this.btnGenPop.TabIndex = 0;
            this.btnGenPop.Text = "Generate Population";
            this.btnGenPop.UseVisualStyleBackColor = true;
            this.btnGenPop.Click += new System.EventHandler(this.btnGenPop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Population Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Crossover Rate:";
            // 
            // txtPopSize
            // 
            this.txtPopSize.Location = new System.Drawing.Point(115, 15);
            this.txtPopSize.Name = "txtPopSize";
            this.txtPopSize.Size = new System.Drawing.Size(61, 23);
            this.txtPopSize.TabIndex = 2;
            // 
            // cmbSelectionMethod
            // 
            this.cmbSelectionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectionMethod.FormattingEnabled = true;
            this.cmbSelectionMethod.Items.AddRange(new object[] {
            "Elite",
            "Rank",
            "Roulette"});
            this.cmbSelectionMethod.Location = new System.Drawing.Point(115, 102);
            this.cmbSelectionMethod.Name = "cmbSelectionMethod";
            this.cmbSelectionMethod.Size = new System.Drawing.Size(77, 23);
            this.cmbSelectionMethod.TabIndex = 24;
            // 
            // txtCrossoverRate
            // 
            this.txtCrossoverRate.Location = new System.Drawing.Point(115, 73);
            this.txtCrossoverRate.Name = "txtCrossoverRate";
            this.txtCrossoverRate.Size = new System.Drawing.Size(48, 23);
            this.txtCrossoverRate.TabIndex = 5;
            // 
            // btnApplyMutationRate
            // 
            this.btnApplyMutationRate.Location = new System.Drawing.Point(6, 131);
            this.btnApplyMutationRate.Name = "btnApplyMutationRate";
            this.btnApplyMutationRate.Size = new System.Drawing.Size(186, 23);
            this.btnApplyMutationRate.TabIndex = 4;
            this.btnApplyMutationRate.Text = "Apply";
            this.btnApplyMutationRate.UseVisualStyleBackColor = true;
            this.btnApplyMutationRate.Click += new System.EventHandler(this.btnApplyMutationRate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mutation Rate:";
            // 
            // txtMutationRate
            // 
            this.txtMutationRate.Location = new System.Drawing.Point(115, 44);
            this.txtMutationRate.Name = "txtMutationRate";
            this.txtMutationRate.Size = new System.Drawing.Size(48, 23);
            this.txtMutationRate.TabIndex = 2;
            // 
            // lblBestAerofoil
            // 
            this.lblBestAerofoil.AutoSize = true;
            this.lblBestAerofoil.Location = new System.Drawing.Point(266, 21);
            this.lblBestAerofoil.Name = "lblBestAerofoil";
            this.lblBestAerofoil.Size = new System.Drawing.Size(77, 15);
            this.lblBestAerofoil.TabIndex = 31;
            this.lblBestAerofoil.Text = "Best Aerofoil:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXFoilParamsApply);
            this.groupBox2.Controls.Add(this.txtAlphaStart);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtAlphaEnd);
            this.groupBox2.Controls.Add(this.txtAlphaIncrement);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtReynolds);
            this.groupBox2.Controls.Add(this.txtCritExponent);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(6, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 192);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XFOIL Test Parameters";
            // 
            // btnXFoilParamsApply
            // 
            this.btnXFoilParamsApply.Location = new System.Drawing.Point(6, 161);
            this.btnXFoilParamsApply.Name = "btnXFoilParamsApply";
            this.btnXFoilParamsApply.Size = new System.Drawing.Size(242, 23);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Alpha Tests Increment Value:";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Alpha Tests End Angle:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Alpha Tests Start Angle:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Reynold\'s Number:";
            // 
            // txtReynolds
            // 
            this.txtReynolds.Location = new System.Drawing.Point(187, 45);
            this.txtReynolds.Name = "txtReynolds";
            this.txtReynolds.Size = new System.Drawing.Size(61, 23);
            this.txtReynolds.TabIndex = 13;
            // 
            // txtCritExponent
            // 
            this.txtCritExponent.Location = new System.Drawing.Point(187, 16);
            this.txtCritExponent.Name = "txtCritExponent";
            this.txtCritExponent.Size = new System.Drawing.Size(38, 23);
            this.txtCritExponent.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Critical Amplification Exponent:";
            // 
            // pctAirfoil
            // 
            this.pctAirfoil.Location = new System.Drawing.Point(266, 57);
            this.pctAirfoil.Name = "pctAirfoil";
            this.pctAirfoil.Size = new System.Drawing.Size(259, 85);
            this.pctAirfoil.TabIndex = 30;
            this.pctAirfoil.TabStop = false;
            // 
            // lblGenNum
            // 
            this.lblGenNum.AutoSize = true;
            this.lblGenNum.Location = new System.Drawing.Point(266, 6);
            this.lblGenNum.Name = "lblGenNum";
            this.lblGenNum.Size = new System.Drawing.Size(115, 15);
            this.lblGenNum.TabIndex = 27;
            this.lblGenNum.Text = "Generation Number:";
            // 
            // lblBestAerofoilNum
            // 
            this.lblBestAerofoilNum.AutoSize = true;
            this.lblBestAerofoilNum.Location = new System.Drawing.Point(343, 24);
            this.lblBestAerofoilNum.Name = "lblBestAerofoilNum";
            this.lblBestAerofoilNum.Size = new System.Drawing.Size(0, 15);
            this.lblBestAerofoilNum.TabIndex = 28;
            // 
            // lblBestFitness
            // 
            this.lblBestFitness.AutoSize = true;
            this.lblBestFitness.Location = new System.Drawing.Point(266, 39);
            this.lblBestFitness.Name = "lblBestFitness";
            this.lblBestFitness.Size = new System.Drawing.Size(71, 15);
            this.lblBestFitness.TabIndex = 29;
            this.lblBestFitness.Text = "Best Fitness:";
            // 
            // tabPageTesting
            // 
            this.tabPageTesting.Controls.Add(this.btnRunXFoil);
            this.tabPageTesting.Controls.Add(this.btnLDRatio);
            this.tabPageTesting.Controls.Add(this.btnLoadAerofoil);
            this.tabPageTesting.Controls.Add(this.lblAerofoilFile);
            this.tabPageTesting.Controls.Add(this.btnAerofoilFile);
            this.tabPageTesting.Controls.Add(this.txtLDRatio);
            this.tabPageTesting.Controls.Add(this.txtAerofoilFile);
            this.tabPageTesting.Controls.Add(this.btnRunTest);
            this.tabPageTesting.Location = new System.Drawing.Point(4, 24);
            this.tabPageTesting.Name = "tabPageTesting";
            this.tabPageTesting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTesting.Size = new System.Drawing.Size(531, 437);
            this.tabPageTesting.TabIndex = 1;
            this.tabPageTesting.Text = "Testing";
            this.tabPageTesting.UseVisualStyleBackColor = true;
            // 
            // btnRunXFoil
            // 
            this.btnRunXFoil.Location = new System.Drawing.Point(6, 6);
            this.btnRunXFoil.Name = "btnRunXFoil";
            this.btnRunXFoil.Size = new System.Drawing.Size(75, 23);
            this.btnRunXFoil.TabIndex = 14;
            this.btnRunXFoil.Text = "Run XFoil";
            this.btnRunXFoil.UseVisualStyleBackColor = true;
            this.btnRunXFoil.Click += new System.EventHandler(this.btnRunXFoil_Click);
            // 
            // btnLDRatio
            // 
            this.btnLDRatio.Location = new System.Drawing.Point(6, 107);
            this.btnLDRatio.Name = "btnLDRatio";
            this.btnLDRatio.Size = new System.Drawing.Size(163, 23);
            this.btnLDRatio.TabIndex = 21;
            this.btnLDRatio.Text = "Calculate Lift to Drag Ratios";
            this.btnLDRatio.UseVisualStyleBackColor = true;
            this.btnLDRatio.Click += new System.EventHandler(this.btnLDRatio_Click);
            // 
            // btnLoadAerofoil
            // 
            this.btnLoadAerofoil.Location = new System.Drawing.Point(420, 48);
            this.btnLoadAerofoil.Name = "btnLoadAerofoil";
            this.btnLoadAerofoil.Size = new System.Drawing.Size(105, 23);
            this.btnLoadAerofoil.TabIndex = 18;
            this.btnLoadAerofoil.Text = "Load File in XFoil";
            this.btnLoadAerofoil.UseVisualStyleBackColor = true;
            this.btnLoadAerofoil.Click += new System.EventHandler(this.btnLoadAerofoil_Click);
            // 
            // lblAerofoilFile
            // 
            this.lblAerofoilFile.AutoSize = true;
            this.lblAerofoilFile.Location = new System.Drawing.Point(6, 32);
            this.lblAerofoilFile.Name = "lblAerofoilFile";
            this.lblAerofoilFile.Size = new System.Drawing.Size(116, 15);
            this.lblAerofoilFile.TabIndex = 15;
            this.lblAerofoilFile.Text = "Choose Aerofoil File:";
            // 
            // btnAerofoilFile
            // 
            this.btnAerofoilFile.Location = new System.Drawing.Point(339, 49);
            this.btnAerofoilFile.Name = "btnAerofoilFile";
            this.btnAerofoilFile.Size = new System.Drawing.Size(75, 23);
            this.btnAerofoilFile.TabIndex = 17;
            this.btnAerofoilFile.Text = "Browse...";
            this.btnAerofoilFile.UseVisualStyleBackColor = true;
            this.btnAerofoilFile.Click += new System.EventHandler(this.btnAerofoilFile_Click);
            // 
            // txtLDRatio
            // 
            this.txtLDRatio.Location = new System.Drawing.Point(6, 136);
            this.txtLDRatio.Multiline = true;
            this.txtLDRatio.Name = "txtLDRatio";
            this.txtLDRatio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLDRatio.Size = new System.Drawing.Size(163, 296);
            this.txtLDRatio.TabIndex = 20;
            // 
            // txtAerofoilFile
            // 
            this.txtAerofoilFile.Location = new System.Drawing.Point(6, 49);
            this.txtAerofoilFile.Name = "txtAerofoilFile";
            this.txtAerofoilFile.Size = new System.Drawing.Size(327, 23);
            this.txtAerofoilFile.TabIndex = 16;
            // 
            // btnRunTest
            // 
            this.btnRunTest.Location = new System.Drawing.Point(6, 78);
            this.btnRunTest.Name = "btnRunTest";
            this.btnRunTest.Size = new System.Drawing.Size(75, 23);
            this.btnRunTest.TabIndex = 19;
            this.btnRunTest.Text = "Run a Test";
            this.btnRunTest.UseVisualStyleBackColor = true;
            this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 475);
            this.Controls.Add(this.tabFunctions);
            this.Name = "frmMainWindow";
            this.Text = "Aerofoil Designer";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.tabFunctions.ResumeLayout(false);
            this.tabPageGA.ResumeLayout(false);
            this.tabPageGA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAirfoil)).EndInit();
            this.tabPageTesting.ResumeLayout(false);
            this.tabPageTesting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabFunctions;
        private TabPage tabPageGA;
        private TabPage tabPageTesting;
        private Button btnSave;
        private GroupBox groupBox1;
        private Button btnRunEpoch;
        private Label label2;
        private Button btnGenPop;
        private Label label3;
        private Label label4;
        public TextBox txtPopSize;
        public ComboBox cmbSelectionMethod;
        public TextBox txtCrossoverRate;
        private Button btnApplyMutationRate;
        private Label label5;
        public TextBox txtMutationRate;
        public Label lblBestAerofoil;
        private GroupBox groupBox2;
        private Button btnXFoilParamsApply;
        public TextBox txtAlphaStart;
        private Label label9;
        public TextBox txtAlphaEnd;
        public TextBox txtAlphaIncrement;
        private Label label10;
        private Label label11;
        private Label label12;
        public TextBox txtReynolds;
        public TextBox txtCritExponent;
        private Label label13;
        private PictureBox pctAirfoil;
        public Label lblGenNum;
        public Label lblBestAerofoilNum;
        public Label lblBestFitness;
        private Button btnRunXFoil;
        private Button btnLDRatio;
        private Button btnLoadAerofoil;
        private Label lblAerofoilFile;
        private Button btnAerofoilFile;
        private TextBox txtLDRatio;
        private TextBox txtAerofoilFile;
        private Button btnRunTest;
    }
}