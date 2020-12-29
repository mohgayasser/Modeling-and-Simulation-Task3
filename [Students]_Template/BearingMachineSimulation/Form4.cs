using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BearingMachineSimulation
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.performance.BearingCost.ToString();
            textBox2.Text = Form1.performance.DelayCost.ToString();
            textBox3.Text = Form1.performance.DowntimeCost.ToString();
            textBox4.Text = Form1.performance.RepairPersonCost.ToString();
            textBox5.Text = Form1.performance.TotalCost.ToString();

            textBox10.Text= Form3.performanceMeasures.BearingCost.ToString();
            textBox7.Text = Form3.performanceMeasures.DelayCost.ToString();
            textBox8.Text = Form3.performanceMeasures.DowntimeCost.ToString();
            textBox9.Text = Form3.performanceMeasures.RepairPersonCost.ToString();
            textBox6.Text = Form3.performanceMeasures.TotalCost.ToString();
            if(Form1.performance.TotalCost - Form3.performanceMeasures.TotalCost>0)
            label6.Text= "The Proposed Simulation policy generates a savings of $" + Math.Abs(Form1.performance.TotalCost-Form3.performanceMeasures.TotalCost).ToString()+ " over a "+ Form1.ss.NumberOfHours.ToString() + "-hour simulation";
            else
            {
                label6.Text = "The Current Simulation policy generates a savings of $" + Math.Abs(Form1.performance.TotalCost - Form3.performanceMeasures.TotalCost).ToString() + " over a " + Form1.ss.NumberOfHours.ToString() + "-hour simulation";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.f2.Dispose();
            Form1.f3.Dispose();
            Form1.f4.Dispose();
        }

    }
}
