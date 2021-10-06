﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect1
{
    public partial class Form1 : Form
    {
        private const double e = Math.E;
        int nrintrari;
        List<Intrari> intrariList=new List<Intrari>();
        List<decimal> produsIntrariList = new List<decimal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            flowLayoutPanel1.AutoScroll = true;
            updateIntrari();
            refreshUI();


        }
        private void updateIntrari()
        {
            nrintrari = Convert.ToInt32(nupDendrite.Value);
            if (nrintrari > flowLayoutPanel1.Controls.Count / 3)
                for (int i = flowLayoutPanel1.Controls.Count / 3; i < nrintrari; i++)
                {
                    Label label = new Label();
                    label.Text = "   X["+i.ToString()+"]" + "            W[" + i.ToString()+"]";

                    NumericUpDown numericUpDown = new NumericUpDown();
                    numericUpDown.Text = "0.00";
                    numericUpDown.Tag = "in";
                    numericUpDown.Increment = Convert.ToDecimal(0.01);
                    numericUpDown.DecimalPlaces = 2;
                    numericUpDown.Size = new Size(50, 20);
                    numericUpDown.Minimum = (decimal)-1.00;
                    numericUpDown.Maximum = (decimal)1.00;
                    numericUpDown.ValueChanged += new EventHandler(refreshValues);

                    NumericUpDown numericUpDown2 = new NumericUpDown();
                    numericUpDown2.Text = "0.00";
                    numericUpDown2.Tag = "w";
                    numericUpDown2.Size = new Size(50, 20);
                    numericUpDown2.Minimum = (decimal)-1.00;
                    numericUpDown2.Maximum = (decimal)1.00;
                    numericUpDown2.Increment = Convert.ToDecimal(0.01);
                    numericUpDown2.DecimalPlaces = 2;
                    numericUpDown2.ValueChanged += new EventHandler(refreshValues);
                    flowLayoutPanel1.Controls.Add(label);

                    flowLayoutPanel1.Controls.Add(numericUpDown);
                    flowLayoutPanel1.Controls.Add(numericUpDown2);
                }
            else
                   if (nrintrari < flowLayoutPanel1.Controls.Count / 3 && flowLayoutPanel1.Controls.Count % 3 == 0)
            {
                for (int i = flowLayoutPanel1.Controls.Count - 1; i >= nrintrari * 3; i--)
                {
                    flowLayoutPanel1.Controls.RemoveAt(i);
                }
            }
        }
        private void deleteRows()
        {
            flowLayoutPanel1.Controls.Clear();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            updateIntrari();
        }

        private void refreshValues(object sender, EventArgs e)
        {
            refreshUI();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addIntrariObjToList()
        {
            intrariList.Clear();
            bool addFlag = false;
            decimal inV=0;
            decimal wV=0;
          
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is NumericUpDown)
                {
                    if (addFlag == true)
                        addFlag = false;
                    else
                        addFlag = true;

                    NumericUpDown NumericControl = (NumericUpDown)control;
                    switch (NumericControl.Tag)
                    {
                        case "in": inV = Convert.ToDecimal(NumericControl.Value);
                            break;
                        case "w": wV = Convert.ToDecimal(NumericControl.Value);
                            break;
                    }
                
                    if(addFlag==false)
                    intrariList.Add(new Intrari(inV, wV));
                }
               
            }
            
        }
        private void addIntrariToList()
        {
            produsIntrariList.Clear();
            foreach (Intrari intrari in intrariList)
            {
                produsIntrariList.Add(intrari.intr * intrari.w);
            }
        }

        private void refreshFunction()
        {
            
            //Refresh functie intrare
            
            switch (dropDownIntrare.SelectedItem.ToString())
            {

                case "Maxim": textBoxIntrare.Text= produsIntrariList.Max<decimal>().ToString();
                    break;

                case "Minim": textBoxIntrare.Text = produsIntrariList.Min<decimal>().ToString();
                    break;

                case "Produs":
                    {
                        decimal produs = 1;
                        foreach(decimal intrare in produsIntrariList)
                        {
                            produs *= intrare;
                        }
                        textBoxIntrare.Text = produs.ToString();
                    }
                    break;
                case "Suma":
                    {
                        decimal suma = 0;
                        foreach (decimal intrare in produsIntrariList)
                        {
                            suma += intrare;
                        }
                        textBoxIntrare.Text = suma.ToString();
                    }
                    break;
            }
            //---Refresh functie intrare

            //---Refresh functie activare
            switch (dropDownActivare.SelectedItem.ToString())
            {
                case "Liniara":
                    {
                        binarCk.Visible = true;
                        labelVariable.Visible = true;
                        nupVariable.Visible = true;
                        labelVariable.Text = "α";
                        
                        nupTeta.Minimum = -1;
                        nupTeta.Maximum = 1;
                        if (Convert.ToDecimal(textBoxIntrare.Text) > nupVariable.Value)
                        {
                            textBoxActivare.Text = 1.ToString();
                        }
                        else
                            if (Convert.ToDecimal(textBoxIntrare.Text) >= -nupVariable.Value && Convert.ToDecimal(textBoxIntrare.Text) <= nupVariable.Value)
                            {
                            textBoxActivare.Text = ((Convert.ToDecimal(textBoxIntrare.Text) - nupTeta.Value) / nupVariable.Value).ToString();
                            }
                        else
                            if(Convert.ToDecimal(textBoxIntrare.Text)<-nupVariable.Value)
                        {
                            textBoxActivare.Text = "-1";
                        }
                    } 
                    break;

                case "Sigmoidala":
                    {
                        binarCk.Visible = true;
                        labelVariable.Visible = true;
                        nupVariable.Visible = true;
                        labelVariable.Text = "g";
                        textBoxActivare.Text = (1.0 / (1.0 + Math.Pow(Math.E, (double)-nupVariable.Value*(Convert.ToDouble(textBoxIntrare.Text) - Convert.ToDouble(nupTeta.Value))))).ToString();
                        break;
                    }

                case "Treapta":
                    {
                        binarCk.Visible = false;
                        labelVariable.Visible = false;
                        nupVariable.Visible = false ;
                        if (Convert.ToDouble(textBoxIntrare.Text) >= Convert.ToDouble(nupTeta.Value)) textBoxActivare.Text = 1.ToString();
                        if (Convert.ToDouble(textBoxIntrare.Text) < Convert.ToDouble(nupTeta.Value)) textBoxActivare.Text = 0.ToString();
                    }
                    break;

                case "Semn":
                    {
                        binarCk.Visible = true;
                        labelVariable.Visible = false;
                        nupVariable.Visible = false;
                        if (Convert.ToDouble(textBoxIntrare.Text) >= Convert.ToDouble(nupTeta.Value)) textBoxActivare.Text = 1.ToString();
                        if (Convert.ToDouble(textBoxIntrare.Text) < Convert.ToDouble(nupTeta.Value)) textBoxActivare.Text = "-1";
                    }
                    break;

                case "Tangenta Hiperbolica":
                    {
                        binarCk.Visible = true;
                        labelVariable.Visible = true;
                        nupVariable.Visible = true;
                        labelVariable.Text = "g";
                        textBoxActivare.Text = (
                            (Math.Pow(e, (double)nupVariable.Value * (Convert.ToDouble(textBoxIntrare.Text) - Convert.ToDouble(nupTeta.Value))) - Math.Pow(e, (double)-nupVariable.Value * (Convert.ToDouble(textBoxIntrare.Text) - Convert.ToDouble(nupTeta.Value)))) / (Math.Pow(e, (double)nupVariable.Value * (Convert.ToDouble(textBoxIntrare.Text) - Convert.ToDouble(nupTeta.Value))) + Math.Pow(e, (double)-nupVariable.Value * (Convert.ToDouble(textBoxIntrare.Text) - Convert.ToDouble(nupTeta.Value))))).ToString();
                        break;
                    }
            }
            //---Refresh functie activare

            //---Refresh functie iesire/iesire
            if(binarCk.Checked==true)
            {
                if(dropDownActivare.SelectedItem.ToString().Equals("Treapta"))
                {
                    if (Convert.ToDouble(textBoxActivare.Text) > 0)
                        textBoxIesire.Text = 1.ToString();
                    else
                        textBoxIesire.Text = 0.ToString();
                }
                if (dropDownActivare.SelectedItem.ToString().Equals("Liniara"))
                {
                    if (Convert.ToDouble(textBoxActivare.Text) > 0)
                        textBoxIesire.Text = 1.ToString();
                    else
                        textBoxIesire.Text = 0.ToString();
                }
                else
                    if(dropDownActivare.SelectedItem.ToString().Equals("Semn"))
                {
                    if(Convert.ToDouble(textBoxActivare.Text) >= 0)
                        textBoxIesire.Text = 1.ToString();
                    else
                        textBoxIesire.Text = 0.ToString();
                }
                else
                     if (dropDownActivare.SelectedItem.ToString().Equals("Sigmoidala"))
                {
                    if (Convert.ToDouble(textBoxActivare.Text) >= 0.5)
                        textBoxIesire.Text = 1.ToString();
                    else
                        textBoxIesire.Text = 0.ToString();
                }
                else
                if (dropDownActivare.SelectedItem.ToString().Equals("Tangenta Hiperbolica"))
                {
                    if (Convert.ToDouble(textBoxActivare.Text) >= 0)
                        textBoxIesire.Text = 1.ToString();
                    else
                        textBoxIesire.Text = 0.ToString();
                }


            }
            else
            {  
                textBoxIesire.Text = textBoxActivare.Text;
            }
            //---Refresh functie iesire/iesire

            // Refresh chart
            chart1.Series["Intrare"].Points.Clear();
            this.chart1.Series["Intrare"].Points.AddXY(-5 , -1);
           // this.chart1.Series["Intrare"].Points.AddXY()
            this.chart1.Series["Intrare"].Points.AddXY(textBoxIntrare.Text, textBoxActivare.Text);
            this.chart1.Series["Intrare"].Points.AddXY(6, 1);
            // --Refresh chart
        }
        private void refreshUI()
        {
            
            addIntrariObjToList();
            addIntrariToList();
            refreshFunction();
      
        }
        private void refereshNrIntrari(object sender, EventArgs e)
        {
            //refreshUI();
        }

        private void FunctiaIntrareDDRefresh(object sender, EventArgs e)
        {
            refreshUI();
        }

        private void FunctiaActivareDDRefresh(object sender, EventArgs e)
        {
            refreshUI();
        }

        private void TetaUDRefresh(object sender, EventArgs e)
        {
            refreshUI();
        }

        private void AlphaUDRefresh(object sender, EventArgs e)
        {
            refreshUI();
        }

        private void BinarCkRefresh(object sender, EventArgs e)
        {
            refreshUI();
        }
    }
}
