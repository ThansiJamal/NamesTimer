using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamesTimer
{
    public partial class Form1 : Form
       
    {
        int count = 1;
        public Form1()
        {
            InitializeComponent();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count <= 10)
            {
                if (count == 1)
                {
                    this.BackColor = Color.Red;
                    lblNames.Text = "Thansi";
                    count++;
                }
                else if (count == 2)
                {
                    this.BackColor = Color.Green;
                    lblNames.Text = "Thalitha";
                    count++;
                }
                else if (count == 3)
                {
                    this.BackColor = Color.Yellow;
                    lblNames.Text = "Akhil";
                    count++;
                    
                }

                else if (count == 4)
                {
                    this.BackColor = Color.Cyan;
                    lblNames.Text = "Rafsal";
                    count++;
                    
                }
                else if (count == 5)
                {
                    this.BackColor = Color.Brown;
                    lblNames.Text = "Sali";
                    count++;

                }
                else if (count == 6)
                {
                    this.BackColor = Color.Gray;
                    lblNames.Text = "Parvin";
                    count++;

                }
                else if (count == 7)
                {
                    this.BackColor = Color.Maroon;
                    lblNames.Text = "Jubi";
                    count++;

                }
                else if (count == 8)
                {
                    this.BackColor = Color.Magenta;
                    lblNames.Text = "Jerry";
                    count++;

                }
                else if (count == 9)
                {
                    this.BackColor = Color.Violet;
                    lblNames.Text = "Jismy";
                    count++;

                }
                else if (count == 10)
                {
                    this.BackColor = Color.DarkCyan;
                    lblNames.Text = "Thareeq";
                    count++;

                }
             
             }
            else
            {
                Environment.Exit(0);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 2000;
            //timer1.Start();

            btnStart.Visible = false;


            

        }

       
    }
}


      