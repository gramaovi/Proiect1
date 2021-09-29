using System;
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
            intrari.Add(new Intrari(0,0));

            deleteRows();
            int locationx = 15;
            int locationy = 60;
            for(int i = 1; i <= numericUpDown1.Value; i++)
            {
                NumericUpDown newTextbox = new NumericUpDown();        
                newTextbox.Text = "1";
                newTextbox.Tag = i;
                newTextbox.Size = new Size(40, 20);
                // newTextbox.Location = new Point(locationx, locationy);
                NumericUpDown newTextbox2 = new NumericUpDown();
                newTextbox2.Text = "1";
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
                    if(NumericControl.Tag.Equals(1))
                    {
                        Console.WriteLine("TEST");
                    }
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
