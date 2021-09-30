﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect1
{
    public partial class Form1 : Form
    {
        int nrintrari;
        List<Intrari> intrari=new List<Intrari>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            flowLayoutPanel1.AutoScroll = true;

        }
        private void deleteRows()
        {
            flowLayoutPanel1.Controls.Clear();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nrintrari = Convert.ToInt32(numericUpDown1.Value);
         if(nrintrari > flowLayoutPanel1.Controls.Count / 2)
            for(int i = flowLayoutPanel1.Controls.Count /2 ; i<nrintrari;i++)
            {
                    NumericUpDown newTextbox = new NumericUpDown();
                    newTextbox.Text = i.ToString();
                    newTextbox.Tag = i;
                    newTextbox.Increment = Convert.ToDecimal(0.01);
                    newTextbox.DecimalPlaces = 2;
                    newTextbox.Size = new Size(40, 20);

                    NumericUpDown newTextbox2 = new NumericUpDown();
                    newTextbox2.Text = i.ToString();
                    newTextbox2.Tag = i;
                    newTextbox2.Size = new Size(40, 20);
                    newTextbox2.Increment = Convert.ToDecimal(0.01);
                    newTextbox2.DecimalPlaces = 2;
                    flowLayoutPanel1.Controls.Add(newTextbox);
                    flowLayoutPanel1.Controls.Add(newTextbox2);
            }
            else
                if (nrintrari < flowLayoutPanel1.Controls.Count / 2 && flowLayoutPanel1.Controls.Count%2==0)
            {
                for (int i = flowLayoutPanel1.Controls.Count-1; i >= nrintrari*2 ; i--)
                {
                    flowLayoutPanel1.Controls.RemoveAt(i);
                    
                }
                    
                //    foreach (Control control in flowLayoutPanel1.Controls)
                //{

                //    if (control is NumericUpDown)
                //    {
                //        NumericUpDown NumericControl = (NumericUpDown)control;
                //        if (NumericControl.Tag.Equals(i) )
                //        {
                //             flowLayoutPanel1.Controls.Remove(NumericControl);
                //        }
                //    }
                //}
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
    }
}
