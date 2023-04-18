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
            this.txtReynolds = new System.Windows.Forms.TextBox();
            this.lblReynolds = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNormVals = new System.Windows.Forms.TextBox();
            this.grpChromosome = new System.Windows.Forms.GroupBox();
            this.txtMaxVal = new System.Windows.Forms.TextBox();
            this.lblMaxVal = new System.Windows.Forms.Label();
            this.txtArrayLen = new System.Windows.Forms.TextBox();
            this.lblArrayLen = new System.Windows.Forms.Label();
            this.lblGenNum = new System.Windows.Forms.Label();
            this.grpPop = new System.Windows.Forms.GroupBox();
            this.btnRunEpoch = new System.Windows.Forms.Button();
            this.lblPopSize = new System.Windows.Forms.Label();
            this.btnGenPop = new System.Windows.Forms.Button();
            this.txtPopSize = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpChromosome.SuspendLayout();
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
            this.btnRunTest.Location = new System.Drawing.Point(120, 92);
            this.btnRunTest.Name = "btnRunTest";
            this.btnRunTest.Size = new System.Drawing.Size(75, 23);
            this.btnRunTest.TabIndex = 8;
            this.btnRunTest.Text = "Run a Test";
            this.btnRunTest.UseVisualStyleBackColor = true;
            this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
            // 
            // txtLDRatio
            // 
            this.txtLDRatio.Location = new System.Drawing.Point(6, 150);
            this.txtLDRatio.Multiline = true;
            this.txtLDRatio.Name = "txtLDRatio";
            this.txtLDRatio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLDRatio.Size = new System.Drawing.Size(373, 287);
            this.txtLDRatio.TabIndex = 9;
            // 
            // btnLDRatio
            // 
            this.btnLDRatio.Location = new System.Drawing.Point(6, 121);
            this.btnLDRatio.Name = "btnLDRatio";
            this.btnLDRatio.Size = new System.Drawing.Size(163, 23);
            this.btnLDRatio.TabIndex = 10;
            this.btnLDRatio.Text = "Calculate Lift to Drag Ratios";
            this.btnLDRatio.UseVisualStyleBackColor = true;
            this.btnLDRatio.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtReynolds
            // 
            this.txtReynolds.Location = new System.Drawing.Point(6, 92);
            this.txtReynolds.Name = "txtReynolds";
            this.txtReynolds.Size = new System.Drawing.Size(108, 23);
            this.txtReynolds.TabIndex = 12;
            // 
            // lblReynolds
            // 
            this.lblReynolds.AutoSize = true;
            this.lblReynolds.Location = new System.Drawing.Point(6, 74);
            this.lblReynolds.Name = "lblReynolds";
            this.lblReynolds.Size = new System.Drawing.Size(108, 15);
            this.lblReynolds.TabIndex = 11;
            this.lblReynolds.Text = "Reynold\'s Number:";
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
            this.tabPage1.Controls.Add(this.txtReynolds);
            this.tabPage1.Controls.Add(this.btnLDRatio);
            this.tabPage1.Controls.Add(this.lblAerofoilFile);
            this.tabPage1.Controls.Add(this.txtLDRatio);
            this.tabPage1.Controls.Add(this.lblReynolds);
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
            this.tabPage2.Controls.Add(this.txtNormVals);
            this.tabPage2.Controls.Add(this.grpChromosome);
            this.tabPage2.Controls.Add(this.lblGenNum);
            this.tabPage2.Controls.Add(this.grpPop);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(655, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNormVals
            // 
            this.txtNormVals.Location = new System.Drawing.Point(374, 6);
            this.txtNormVals.Multiline = true;
            this.txtNormVals.Name = "txtNormVals";
            this.txtNormVals.ReadOnly = true;
            this.txtNormVals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNormVals.Size = new System.Drawing.Size(199, 431);
            this.txtNormVals.TabIndex = 6;
            // 
            // grpChromosome
            // 
            this.grpChromosome.Controls.Add(this.txtMaxVal);
            this.grpChromosome.Controls.Add(this.lblMaxVal);
            this.grpChromosome.Controls.Add(this.txtArrayLen);
            this.grpChromosome.Controls.Add(this.lblArrayLen);
            this.grpChromosome.Location = new System.Drawing.Point(6, 6);
            this.grpChromosome.Name = "grpChromosome";
            this.grpChromosome.Size = new System.Drawing.Size(181, 77);
            this.grpChromosome.TabIndex = 5;
            this.grpChromosome.TabStop = false;
            this.grpChromosome.Text = "Chromosome";
            // 
            // txtMaxVal
            // 
            this.txtMaxVal.Location = new System.Drawing.Point(108, 45);
            this.txtMaxVal.Name = "txtMaxVal";
            this.txtMaxVal.Size = new System.Drawing.Size(61, 23);
            this.txtMaxVal.TabIndex = 7;
            // 
            // lblMaxVal
            // 
            this.lblMaxVal.AutoSize = true;
            this.lblMaxVal.Location = new System.Drawing.Point(6, 48);
            this.lblMaxVal.Name = "lblMaxVal";
            this.lblMaxVal.Size = new System.Drawing.Size(96, 15);
            this.lblMaxVal.TabIndex = 6;
            this.lblMaxVal.Text = "Maximum Value:";
            // 
            // txtArrayLen
            // 
            this.txtArrayLen.Location = new System.Drawing.Point(108, 16);
            this.txtArrayLen.Name = "txtArrayLen";
            this.txtArrayLen.Size = new System.Drawing.Size(61, 23);
            this.txtArrayLen.TabIndex = 5;
            // 
            // lblArrayLen
            // 
            this.lblArrayLen.AutoSize = true;
            this.lblArrayLen.Location = new System.Drawing.Point(6, 19);
            this.lblArrayLen.Name = "lblArrayLen";
            this.lblArrayLen.Size = new System.Drawing.Size(78, 15);
            this.lblArrayLen.TabIndex = 6;
            this.lblArrayLen.Text = "Array Length:";
            // 
            // lblGenNum
            // 
            this.lblGenNum.AutoSize = true;
            this.lblGenNum.Location = new System.Drawing.Point(519, 21);
            this.lblGenNum.Name = "lblGenNum";
            this.lblGenNum.Size = new System.Drawing.Size(115, 15);
            this.lblGenNum.TabIndex = 4;
            this.lblGenNum.Text = "Generation Number:";
            // 
            // grpPop
            // 
            this.grpPop.Controls.Add(this.btnRunEpoch);
            this.grpPop.Controls.Add(this.lblPopSize);
            this.grpPop.Controls.Add(this.btnGenPop);
            this.grpPop.Controls.Add(this.txtPopSize);
            this.grpPop.Location = new System.Drawing.Point(193, 6);
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
            this.ClientSize = new System.Drawing.Size(670, 482);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMainWindow";
            this.Text = "Aerofoil Designer";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpChromosome.ResumeLayout(false);
            this.grpChromosome.PerformLayout();
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
        private Label lblReynolds;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnGenPop;
        public Label lblGenNum;
        private GroupBox grpPop;
        private Button btnRunEpoch;
        private Label lblPopSize;
        private TextBox txtPopSize;
        private GroupBox grpChromosome;
        private TextBox txtArrayLen;
        private Label lblArrayLen;
        private TextBox txtMaxVal;
        private Label lblMaxVal;
        public TextBox txtNormVals;
        public TextBox txtReynolds;
    }
}