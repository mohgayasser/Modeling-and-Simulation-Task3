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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

            int totalDelay = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            int Lcount = Form1.ListcurrentSimulation.Count;
            
            for (int i = 0; i < Lcount; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = Form1.ListcurrentSimulation[i].Bearing.Index;
                row.Cells[1].Value = Form1.ListcurrentSimulation[i].Bearing.RandomHours;
                row.Cells[2].Value = Form1.ListcurrentSimulation[i].Bearing.Hours;
                row.Cells[3].Value = Form1.ListcurrentSimulation[i].AccumulatedHours;
                row.Cells[4].Value = Form1.ListcurrentSimulation[i].RandomDelay;
                row.Cells[5].Value = Form1.ListcurrentSimulation[i].Delay;
                dataGridView1.Rows.Add(row);
                totalDelay += Form1.ListcurrentSimulation[i].Delay;
            }
            TotalDelay.Text = totalDelay.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void NumofBearing_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
