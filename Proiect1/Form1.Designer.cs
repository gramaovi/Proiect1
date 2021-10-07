
namespace Proiect1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dropDownIntrare = new System.Windows.Forms.ComboBox();
            this.textBoxIntrare = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelVariable = new System.Windows.Forms.Label();
            this.labelTeta = new System.Windows.Forms.Label();
            this.nupVariable = new System.Windows.Forms.NumericUpDown();
            this.nupTeta = new System.Windows.Forms.NumericUpDown();
            this.dropDownActivare = new System.Windows.Forms.ComboBox();
            this.textBoxActivare = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.binarCk = new System.Windows.Forms.CheckBox();
            this.textBoxIesire = new System.Windows.Forms.TextBox();
            this.Grafic = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nupDendrite = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupVariable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTeta)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.Grafic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDendrite)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 410);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nr de intrari - dendrite:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(235, 381);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dropDownIntrare);
            this.groupBox2.Controls.Add(this.textBoxIntrare);
            this.groupBox2.Location = new System.Drawing.Point(276, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functia de intrare";
            // 
            // dropDownIntrare
            // 
            this.dropDownIntrare.FormattingEnabled = true;
            this.dropDownIntrare.Items.AddRange(new object[] {
            "Maxim",
            "Minim",
            "Produs",
            "Suma"});
            this.dropDownIntrare.Location = new System.Drawing.Point(15, 54);
            this.dropDownIntrare.Name = "dropDownIntrare";
            this.dropDownIntrare.Size = new System.Drawing.Size(129, 21);
            this.dropDownIntrare.TabIndex = 1;
            this.dropDownIntrare.Text = "Maxim";
            this.dropDownIntrare.SelectedIndexChanged += new System.EventHandler(this.FunctiaIntrareDDRefresh);
            // 
            // textBoxIntrare
            // 
            this.textBoxIntrare.Location = new System.Drawing.Point(15, 19);
            this.textBoxIntrare.Name = "textBoxIntrare";
            this.textBoxIntrare.Size = new System.Drawing.Size(129, 20);
            this.textBoxIntrare.TabIndex = 0;
            this.textBoxIntrare.Text = "0.00000000";
            this.textBoxIntrare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.labelVariable);
            this.groupBox3.Controls.Add(this.labelTeta);
            this.groupBox3.Controls.Add(this.nupVariable);
            this.groupBox3.Controls.Add(this.nupTeta);
            this.groupBox3.Controls.Add(this.dropDownActivare);
            this.groupBox3.Controls.Add(this.textBoxActivare);
            this.groupBox3.Location = new System.Drawing.Point(459, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 169);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Functia de activare";
            // 
            // labelVariable
            // 
            this.labelVariable.AutoSize = true;
            this.labelVariable.BackColor = System.Drawing.Color.Transparent;
            this.labelVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVariable.Location = new System.Drawing.Point(59, 122);
            this.labelVariable.Name = "labelVariable";
            this.labelVariable.Size = new System.Drawing.Size(30, 31);
            this.labelVariable.TabIndex = 7;
            this.labelVariable.Text = "α";
            // 
            // labelTeta
            // 
            this.labelTeta.AutoSize = true;
            this.labelTeta.BackColor = System.Drawing.Color.Transparent;
            this.labelTeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeta.Location = new System.Drawing.Point(56, 86);
            this.labelTeta.Name = "labelTeta";
            this.labelTeta.Size = new System.Drawing.Size(37, 37);
            this.labelTeta.TabIndex = 6;
            this.labelTeta.Text = "⊖";
            // 
            // nupVariable
            // 
            this.nupVariable.DecimalPlaces = 2;
            this.nupVariable.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupVariable.Location = new System.Drawing.Point(96, 133);
            this.nupVariable.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupVariable.Name = "nupVariable";
            this.nupVariable.Size = new System.Drawing.Size(59, 20);
            this.nupVariable.TabIndex = 5;
            this.nupVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupVariable.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupVariable.ValueChanged += new System.EventHandler(this.AlphaUDRefresh);
            // 
            // nupTeta
            // 
            this.nupTeta.DecimalPlaces = 2;
            this.nupTeta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupTeta.Location = new System.Drawing.Point(96, 98);
            this.nupTeta.Name = "nupTeta";
            this.nupTeta.Size = new System.Drawing.Size(59, 20);
            this.nupTeta.TabIndex = 4;
            this.nupTeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupTeta.ValueChanged += new System.EventHandler(this.TetaUDRefresh);
            // 
            // dropDownActivare
            // 
            this.dropDownActivare.FormattingEnabled = true;
            this.dropDownActivare.Items.AddRange(new object[] {
            "Liniara",
            "Semn",
            "Sigmoidala",
            "Tangenta Hiperbolica",
            "Treapta"});
            this.dropDownActivare.Location = new System.Drawing.Point(26, 64);
            this.dropDownActivare.Name = "dropDownActivare";
            this.dropDownActivare.Size = new System.Drawing.Size(129, 21);
            this.dropDownActivare.TabIndex = 3;
            this.dropDownActivare.Text = "Liniara";
            this.dropDownActivare.SelectedIndexChanged += new System.EventHandler(this.FunctiaActivareDDRefresh);
            // 
            // textBoxActivare
            // 
            this.textBoxActivare.Location = new System.Drawing.Point(26, 29);
            this.textBoxActivare.Name = "textBoxActivare";
            this.textBoxActivare.Size = new System.Drawing.Size(129, 20);
            this.textBoxActivare.TabIndex = 2;
            this.textBoxActivare.Text = "-0.00000000";
            this.textBoxActivare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.binarCk);
            this.groupBox4.Controls.Add(this.textBoxIesire);
            this.groupBox4.Location = new System.Drawing.Point(666, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(146, 75);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Functia de iesire";
            // 
            // binarCk
            // 
            this.binarCk.AutoSize = true;
            this.binarCk.Location = new System.Drawing.Point(23, 49);
            this.binarCk.Name = "binarCk";
            this.binarCk.Size = new System.Drawing.Size(50, 17);
            this.binarCk.TabIndex = 1;
            this.binarCk.Text = "Binar";
            this.binarCk.UseVisualStyleBackColor = true;
            this.binarCk.CheckedChanged += new System.EventHandler(this.BinarCkRefresh);
            // 
            // textBoxIesire
            // 
            this.textBoxIesire.Location = new System.Drawing.Point(20, 19);
            this.textBoxIesire.Name = "textBoxIesire";
            this.textBoxIesire.Size = new System.Drawing.Size(108, 20);
            this.textBoxIesire.TabIndex = 0;
            this.textBoxIesire.Text = "-0.00000000";
            this.textBoxIesire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Grafic
            // 
            this.Grafic.BackColor = System.Drawing.Color.Transparent;
            this.Grafic.Controls.Add(this.chart1);
            this.Grafic.Location = new System.Drawing.Point(276, 203);
            this.Grafic.Name = "Grafic";
            this.Grafic.Size = new System.Drawing.Size(527, 235);
            this.Grafic.TabIndex = 6;
            this.Grafic.TabStop = false;
            this.Grafic.Text = "Grafic";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 19);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Intrare";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "vertical";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Marker";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(476, 199);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // nupDendrite
            // 
            this.nupDendrite.Location = new System.Drawing.Point(137, 24);
            this.nupDendrite.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupDendrite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDendrite.Name = "nupDendrite";
            this.nupDendrite.Size = new System.Drawing.Size(39, 20);
            this.nupDendrite.TabIndex = 0;
            this.nupDendrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupDendrite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDendrite.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Proiect1.Properties.Resources.Neuron_Background_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 464);
            this.Controls.Add(this.nupDendrite);
            this.Controls.Add(this.Grafic);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Neuronul artificial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupVariable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTeta)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Grafic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDendrite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox Grafic;
        private System.Windows.Forms.ComboBox dropDownIntrare;
        private System.Windows.Forms.TextBox textBoxIntrare;
        private System.Windows.Forms.NumericUpDown nupVariable;
        private System.Windows.Forms.NumericUpDown nupTeta;
        private System.Windows.Forms.ComboBox dropDownActivare;
        private System.Windows.Forms.TextBox textBoxActivare;
        private System.Windows.Forms.CheckBox binarCk;
        private System.Windows.Forms.TextBox textBoxIesire;
        private System.Windows.Forms.Label labelVariable;
        private System.Windows.Forms.Label labelTeta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown nupDendrite;
    }
}

