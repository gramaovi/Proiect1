using System;
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
        int nrintrari;
        List<Intrari> intrariList=new List<Intrari>();
        List<decimal> produsIntrariList = new List<decimal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //new Thread(() =>
            //{
            //    Thread.CurrentThread.IsBackground = true;
            //    /* run your code here */
            //    addIntrariObjToList();
            //    addIntrariToList();
            //    refreshFunction();
            //}).Start();
            flowLayoutPanel1.AutoScroll = true;
            


        }
        private void deleteRows()
        {
            flowLayoutPanel1.Controls.Clear();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nrintrari = Convert.ToInt32(numericUpDown1.Value);
         if(nrintrari > flowLayoutPanel1.Controls.Count / 3)
            for(int i = flowLayoutPanel1.Controls.Count /3 ; i<nrintrari;i++)
            {
                    Label label = new Label();
                    label.Text = "In i="+i.ToString() + "           W i=" + i.ToString();
                   // Label label2 = new Label();
                  //  label2.Text = "W i=" + i.ToString();
                    NumericUpDown numericUpDown = new NumericUpDown();
                    numericUpDown.Text = i.ToString();
                    numericUpDown.Tag = "in";
                    numericUpDown.Increment = Convert.ToDecimal(0.01);
                    numericUpDown.DecimalPlaces = 2;
                    numericUpDown.Size = new Size(50, 20);

                    NumericUpDown numericUpDown2 = new NumericUpDown();
                    numericUpDown2.Text = i.ToString();
                    numericUpDown2.Tag = "w";
                    numericUpDown2.Size = new Size(50, 20);
                    numericUpDown2.Increment = Convert.ToDecimal(0.01);
                    numericUpDown2.DecimalPlaces = 2;
                    flowLayoutPanel1.Controls.Add(label);
                  //  flowLayoutPanel1.Controls.Add(label2);
                    flowLayoutPanel1.Controls.Add(numericUpDown);
                    flowLayoutPanel1.Controls.Add(numericUpDown2);
            }
            else
                if (nrintrari < flowLayoutPanel1.Controls.Count / 3 && flowLayoutPanel1.Controls.Count%3==0)
            {
                for (int i = flowLayoutPanel1.Controls.Count-1; i >= nrintrari*3 ; i--)
                {
                    flowLayoutPanel1.Controls.RemoveAt(i);
                    
                }
                    
             
            }
            //   while(flowLayoutPanel1.Controls.Count/2<nrintrari)
            //   {
            //       if (numericUpDown1.Value > nrintrari)
            //       {
            //           nrintrari++;
            //           NumericUpDown newTextbox = new NumericUpDown();
            //           newTextbox.Text = nrintrari.ToString();
            //           newTextbox.Tag = nrintrari;
            //           newTextbox.Size = new Size(40, 20);

            //           NumericUpDown newTextbox2 = new NumericUpDown();
            //           newTextbox2.Text = nrintrari.ToString();
            //           newTextbox2.Tag = nrintrari;
            //           newTextbox2.Size = new Size(40, 20);

            //           flowLayoutPanel1.Controls.Add(newTextbox);
            //           flowLayoutPanel1.Controls.Add(newTextbox2);
            //       }
            //       else
            //if (numericUpDown1.Value < nrintrari)
            //       {
            //           flowLayoutPanel1.Controls.RemoveAt(nrintrari);
            //           foreach (Control control in flowLayoutPanel1.Controls)
            //           {
            //               if (control is NumericUpDown)
            //               {
            //                   NumericUpDown NumericControl = (NumericUpDown)control;
            //                   if (NumericControl.Tag.Equals(nrintrari))
            //                   {
            //                       flowLayoutPanel1.Controls.Remove(NumericControl);

            //                   }

            //               }
            //           }
            //           nrintrari--;
            //       }
            //   }

            //  intrari.Add(new Intrari(0,0));

            //  deleteRows();
            /*
              int locationx = 15;
              int locationy = 60;
              for(int i = 1; i <= numericUpDown1.Value; i++)
              {
                  NumericUpDown newTextbox = new NumericUpDown();        
                  newTextbox.Text = i.ToString();
                  newTextbox.Tag = i;
                  newTextbox.Size = new Size(40, 20);
                  // newTextbox.Location = new Point(locationx, locationy);
                  NumericUpDown newTextbox2 = new NumericUpDown();
                  newTextbox2.Text = i.ToString();
                  newTextbox2.Tag = i;
                  newTextbox2.Size = new Size(40, 20);
               //   newTextbox2.Location = new Point(locationx+65, locationy);
                  flowLayoutPanel1.Controls.Add(newTextbox);
                  flowLayoutPanel1.Controls.Add(newTextbox2);
                  // locationy += 20;

              }
              Console.WriteLine(flowLayoutPanel1.Controls);
              Console.WriteLine(intrari.Count);

              foreach(Control control in flowLayoutPanel1.Controls)
              {
                  if(control is NumericUpDown)
                  {
                      NumericUpDown NumericControl = (NumericUpDown)control;
                      if(NumericControl.Tag.Equals(1) || NumericControl.Tag.Equals(2))
                      {
                         // flowLayoutPanel1.Controls.Remove(NumericControl);
                      }
                  }
              }
            */
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
            foreach(Intrari intrari in intrariList)
            {
                produsIntrariList.Add(intrari.intr * intrari.w);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            addIntrariObjToList();
            addIntrariToList();
            refreshFunction();

        }

        private void refreshFunction()
        {
            //Refresh functie activare
            
            switch (intrareDD.SelectedItem.ToString())
            {

                case "Maxim": intrareTb.Text= produsIntrariList.Max<decimal>().ToString();
                    break;

                case "Minim": intrareTb.Text = produsIntrariList.Min<decimal>().ToString();
                    break;

                case "Produs":
                    {
                        double produs = 1;
                        foreach(double intrare in produsIntrariList)
                        {
                            produs *= intrare;
                        }
                        intrareTb.Text = produs.ToString();
                    }
                    break;
                case "Suma":
                    {
                        double suma = 0;
                        foreach (double intrare in produsIntrariList)
                        {
                            suma += intrare;
                        }
                        intrareTb.Text = suma.ToString();
                    }
                    break;
            }
            //---Refresh functie activare
            switch(activareDD.SelectedItem.ToString())
            {
                case "Liniara":
                    {
                        tetaUD.Minimum = -1;
                        tetaUD.Maximum = 1;
                        if (Convert.ToDecimal(intrareTb.Text) > alpha.Value)
                        {
                            activareTb.Text = 1.ToString();
                        }
                        else
                            if (Convert.ToDecimal(intrareTb.Text) >= -alpha.Value && Convert.ToDecimal(intrareTb.Text) <= alpha.Value)
                            {
                            activareTb.Text = ((Convert.ToDecimal(intrareTb.Text) - tetaUD.Value) / alpha.Value).ToString();
                            }
                        else
                            if(Convert.ToDecimal(intrareTb.Text)<-alpha.Value)
                        {
                            activareTb.Text = "-1";
                        }
                    } 
                    break;

                case "Sigmoidala":
                    {
                        activareTb.Text = 1 / (1 + Math.Pow(Math.E, (double)-alpha.Value)).ToString();
                    }
            }
        }

    }
}
