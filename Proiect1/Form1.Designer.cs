﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.intrareDD = new System.Windows.Forms.ComboBox();
            this.intrareTb = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.variableLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alpha = new System.Windows.Forms.NumericUpDown();
            this.tetaUD = new System.Windows.Forms.NumericUpDown();
            this.activareDD = new System.Windows.Forms.ComboBox();
            this.activareTb = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.binarCk = new System.Windows.Forms.CheckBox();
            this.functieIesireTb = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.iesireTb = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nupDendrite = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetaUD)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDendrite)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 410);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nr de intrari :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(116, 381);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.intrareDD);
            this.groupBox2.Controls.Add(this.intrareTb);
            this.groupBox2.Location = new System.Drawing.Point(157, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functia de intrare";
            // 
            // intrareDD
            // 
            this.intrareDD.FormattingEnabled = true;
            this.intrareDD.Items.AddRange(new object[] {
            "Maxim",
            "Minim",
            "Produs",
            "Suma"});
            this.intrareDD.Location = new System.Drawing.Point(15, 54);
            this.intrareDD.Name = "intrareDD";
            this.intrareDD.Size = new System.Drawing.Size(129, 21);
            this.intrareDD.TabIndex = 1;
            this.intrareDD.Text = "Maxim";
            this.intrareDD.SelectedIndexChanged += new System.EventHandler(this.FunctiaIntrareDDRefresh);
            // 
            // intrareTb
            // 
            this.intrareTb.Location = new System.Drawing.Point(15, 19);
            this.intrareTb.Name = "intrareTb";
            this.intrareTb.Size = new System.Drawing.Size(129, 20);
            this.intrareTb.TabIndex = 0;
            this.intrareTb.Text = "0.00000000";
            this.intrareTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.variableLabel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.alpha);
            this.groupBox3.Controls.Add(this.tetaUD);
            this.groupBox3.Controls.Add(this.activareDD);
            this.groupBox3.Controls.Add(this.activareTb);
            this.groupBox3.Location = new System.Drawing.Point(334, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 169);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Functia de activare";
            // 
            // variableLabel
            // 
            this.variableLabel.AutoSize = true;
            this.variableLabel.BackColor = System.Drawing.Color.Transparent;
            this.variableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableLabel.Location = new System.Drawing.Point(59, 122);
            this.variableLabel.Name = "variableLabel";
            this.variableLabel.Size = new System.Drawing.Size(30, 31);
            this.variableLabel.TabIndex = 7;
            this.variableLabel.Text = "α";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "⊖";
            // 
            // alpha
            // 
            this.alpha.Location = new System.Drawing.Point(96, 133);
            this.alpha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(59, 20);
            this.alpha.TabIndex = 5;
            this.alpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.alpha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alpha.ValueChanged += new System.EventHandler(this.AlphaUDRefresh);
            // 
            // tetaUD
            // 
            this.tetaUD.DecimalPlaces = 2;
            this.tetaUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tetaUD.Location = new System.Drawing.Point(96, 98);
            this.tetaUD.Name = "tetaUD";
            this.tetaUD.Size = new System.Drawing.Size(59, 20);
            this.tetaUD.TabIndex = 4;
            this.tetaUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tetaUD.ValueChanged += new System.EventHandler(this.TetaUDRefresh);
            // 
            // activareDD
            // 
            this.activareDD.FormattingEnabled = true;
            this.activareDD.Items.AddRange(new object[] {
            "Liniara",
            "Semn",
            "Sigmoidala",
            "Tangenta Hiperbolica",
            "Treapta"});
            this.activareDD.Location = new System.Drawing.Point(26, 64);
            this.activareDD.Name = "activareDD";
            this.activareDD.Size = new System.Drawing.Size(129, 21);
            this.activareDD.TabIndex = 3;
            this.activareDD.Text = "Liniara";
            this.activareDD.SelectedIndexChanged += new System.EventHandler(this.FunctiaActivareDDRefresh);
            // 
            // activareTb
            // 
            this.activareTb.Location = new System.Drawing.Point(26, 29);
            this.activareTb.Name = "activareTb";
            this.activareTb.Size = new System.Drawing.Size(129, 20);
            this.activareTb.TabIndex = 2;
            this.activareTb.Text = "-0.02000000";
            this.activareTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.binarCk);
            this.groupBox4.Controls.Add(this.functieIesireTb);
            this.groupBox4.Location = new System.Drawing.Point(577, 28);
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
            // functieIesireTb
            // 
            this.functieIesireTb.Location = new System.Drawing.Point(20, 19);
            this.functieIesireTb.Name = "functieIesireTb";
            this.functieIesireTb.Size = new System.Drawing.Size(108, 20);
            this.functieIesireTb.TabIndex = 0;
            this.functieIesireTb.Text = "-0.02000000";
            this.functieIesireTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.iesireTb);
            this.groupBox5.Location = new System.Drawing.Point(577, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(146, 59);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Iesirea";
            // 
            // iesireTb
            // 
            this.iesireTb.Location = new System.Drawing.Point(14, 22);
            this.iesireTb.Name = "iesireTb";
            this.iesireTb.Size = new System.Drawing.Size(114, 20);
            this.iesireTb.TabIndex = 0;
            this.iesireTb.Text = "-0.02000000";
            this.iesireTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chart1);
            this.groupBox6.Location = new System.Drawing.Point(157, 203);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(566, 235);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(15, 19);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Intrare";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(533, 199);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // nupDendrite
            // 
            this.nupDendrite.Location = new System.Drawing.Point(95, 25);
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
            this.ClientSize = new System.Drawing.Size(748, 464);
            this.Controls.Add(this.nupDendrite);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetaUD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox intrareDD;
        private System.Windows.Forms.TextBox intrareTb;
        private System.Windows.Forms.NumericUpDown alpha;
        private System.Windows.Forms.NumericUpDown tetaUD;
        private System.Windows.Forms.ComboBox activareDD;
        private System.Windows.Forms.TextBox activareTb;
        private System.Windows.Forms.CheckBox binarCk;
        private System.Windows.Forms.TextBox functieIesireTb;
        private System.Windows.Forms.TextBox iesireTb;
        private System.Windows.Forms.Label variableLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown nupDendrite;
    }
}

