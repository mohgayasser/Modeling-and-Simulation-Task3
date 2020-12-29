using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BearingMachineTesting;
using BearingMachineModels;
namespace BearingMachineSimulation
{

    public partial class Form1 : Form
    {
        List<BearingMachineModels.TimeDistribution> BearLife = new List<BearingMachineModels.TimeDistribution>();
        List<BearingMachineModels.TimeDistribution> DelayTime = new List<BearingMachineModels.TimeDistribution>();
        BearingMachineModels.CurrentSimulationCase currentSimulation = new BearingMachineModels.CurrentSimulationCase();
        BearingMachineModels.Bearing bear = new BearingMachineModels.Bearing();
        public static List<int> Coutofeachbear = new List<int>();
        public static PerformanceMeasures performance = new PerformanceMeasures();
        public static List<BearingMachineModels.CurrentSimulationCase> ListcurrentSimulation = new List<BearingMachineModels.CurrentSimulationCase>();
        public static BearingMachineModels.SimulationSystem ss = new BearingMachineModels.SimulationSystem();
        Random randomBearLife = new Random();
        Random randomDelay = new Random();
        public static Form3 f3 = new Form3(); public static Form2 f2 = new Form2();
        public static Form4 f4 = new Form4();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File_Read();
            current_Simulation_Table_FUN();
    
            f2.Show();


            f3.Show();

            f4.Show();
        }
        void current_Simulation_Table_FUN()

        {
            int TotalHour = 0;
            int indexBearing = 1;
            randomBearLife = new Random();
            int count = 0;
            int SystemCounter = 0;
            int TotalDelay = 0;
            int bearingCount = -1;
            while (TotalHour < ss.NumberOfHours)
            {
                currentSimulation = new BearingMachineModels.CurrentSimulationCase();
                bear = new BearingMachineModels.Bearing();
                int numRandom = randomBearLife.Next(1, 100);
                bear.RandomHours = numRandom;

                for (int j = 0; j < ss.BearingLifeDistribution.Count; j++)
                {
                    if (numRandom <= ss.BearingLifeDistribution[j].MaxRange && numRandom >= ss.BearingLifeDistribution[j].MinRange)
                    {
                        bear.Hours = ss.BearingLifeDistribution[j].Time;
                        break;
                    }
                }
                if (bear.Index > bearingCount) bearingCount++;
                bear.Index = indexBearing;

                if (ListcurrentSimulation.Count > 0 &&
                ListcurrentSimulation[ListcurrentSimulation.Count - 1].Bearing.Index == indexBearing
                )
                    currentSimulation.AccumulatedHours =
                        bear.Hours
                        + ListcurrentSimulation[ListcurrentSimulation.Count - 1].AccumulatedHours;
                else
                    currentSimulation.AccumulatedHours = bear.Hours;


                currentSimulation.Bearing = bear;



                int numRandom2 = randomDelay.Next(1, 100);
                currentSimulation.RandomDelay = numRandom2;

                for (int j = 0; j < ss.DelayTimeDistribution.Count; j++)
                {
                    if (numRandom2 <= ss.DelayTimeDistribution[j].MaxRange && numRandom2 >= ss.DelayTimeDistribution[j].MinRange)
                    {
                        currentSimulation.Delay = ss.DelayTimeDistribution[j].Time;
                        break;
                    }
                }
                count++;
                TotalHour = currentSimulation.AccumulatedHours;
                TotalDelay += currentSimulation.Delay;
                ListcurrentSimulation.Add(currentSimulation);
                if (currentSimulation.AccumulatedHours >= ss.NumberOfHours)
                {
                    Coutofeachbear.Add(count);
                    count = 0;
                    indexBearing++;
                    TotalHour = 0;
                    if (indexBearing > ss.NumberOfBearings)
                        break;
                    continue;
                };
                SystemCounter++;

            }
            ss.CurrentSimulationTable = ListcurrentSimulation;

            performance.BearingCost = (decimal) (ListcurrentSimulation.Count) * ss.BearingCost;
            performance.DelayCost = (decimal)TotalDelay * ss.DowntimeCost;
            performance.DowntimeCost = (decimal)(ListcurrentSimulation.Count) * ss.RepairTimeForOneBearing * ss.DowntimeCost;
            performance.RepairPersonCost = (decimal)(ListcurrentSimulation.Count) * ss.RepairTimeForOneBearing * ss.RepairPersonCost / 60;
            performance.TotalCost = (decimal) (performance.BearingCost + performance.DelayCost + performance.DowntimeCost + performance.RepairPersonCost);
            ss.CurrentPerformanceMeasures = performance;
            
        }



        void File_Read()
        {
            string[] lines = System.IO.File.ReadAllLines(@"E:\Fouth Year\Modeling and Simulation\Tasks\[Students]_Template\BearingMachineSimulation\TestCases\TestCase2.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].ToString() == "DowntimeCost")
                {
                    Downtime.Text = lines[i + 1];
                    ss.DowntimeCost = int.Parse(lines[i + 1]);
                    i++;
                }
                else if (lines[i].ToString() == "RepairPersonCost")
                {
                    Repairperson.Text = lines[i + 1];
                    ss.RepairPersonCost = int.Parse(lines[i + 1]);
                    i++;
                }
                else if (lines[i].ToString() == "BearingCost")
                {
                    BearingCost.Text = lines[i + 1];
                    ss.BearingCost = int.Parse(lines[i + 1]);
                    i++;
                }
                else if (lines[i].ToString() == "NumberOfHours")
                {
                    NumofHours.Text = lines[i + 1];
                    ss.NumberOfHours = int.Parse(lines[i + 1]);
                    i++;
                }
                else if (lines[i].ToString() == "NumberOfBearings")
                {
                    NumofBearing.Text = lines[i + 1];
                    ss.NumberOfBearings = int.Parse(lines[i + 1]);
                    i++;
                }
                else if (lines[i].ToString() == "RepairTimeForOneBearing")
                {
                    RepairTime.Text = lines[i + 1];
                    ss.RepairTimeForOneBearing = int.Parse(lines[i + 1]);
                    i++;
                }
                else if (lines[i].ToString() == "RepairTimeForAllBearings")
                {
                    Repair2Time.Text = lines[i + 1];
                    ss.RepairTimeForAllBearings = int.Parse(lines[i + 1]);
                    i++;
                }

                else if (lines[i].ToString() == "DelayTimeDistribution")
                {
                    i++;
                    decimal cum1 = 0;
                    while (lines[i].ToString() != "")
                    {
                        BearingMachineModels.TimeDistribution td = new BearingMachineModels.TimeDistribution();

                        string[] words = lines[i].Split(new string[] { ", " }, StringSplitOptions.None);

                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        td.Time = int.Parse(words[0]);
                        td.Probability = decimal.Parse(words[1]);
                        row.Cells[0].Value = words[0];
                        row.Cells[1].Value = words[1];
                        row.Cells[2].Value = (decimal)cum1 + decimal.Parse(words[1]);
                        td.CummProbability = (decimal)(cum1 + (decimal)float.Parse(words[1]));
                        float f = float.Parse(words[1]);
                        float M1 = (100 * f);
                        int M2 = (int)(100 * cum1);
                        td.MaxRange = (int)M1 + M2;
                        if (td.MaxRange > 0)
                        {
                            td.MinRange = (int)(100 * cum1) + 1;
                        }
                        else
                        {
                            td.MinRange = (int)(100 * cum1);
                        }
                     

                        row.Cells[3].Value = td.MinRange + "-" + td.MaxRange;

                        cum1 = cum1 + (decimal)f;
                        dataGridView1.Rows.Add(row);

                        i++;
                        DelayTime.Add(td);
                    }

                    ss.DelayTimeDistribution = DelayTime;
                }
                else if (lines[i].ToString() == "BearingLifeDistribution")
                {
                    i++;
                    decimal cum1 = 0;

                    while (i < lines.Length && lines[i].ToString() != "")
                    {
                        BearingMachineModels.TimeDistribution td = new BearingMachineModels.TimeDistribution();

                        string[] words = lines[i].Split(new string[] { ", " }, StringSplitOptions.None);

                        DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                        td.Time = int.Parse(words[0]);
                        td.Probability = decimal.Parse(words[1]);
                        row.Cells[0].Value = words[0];
                        row.Cells[1].Value = words[1];
                        row.Cells[2].Value = (decimal)cum1 + decimal.Parse(words[1]);
                        td.CummProbability = (decimal)(cum1 + (decimal)float.Parse(words[1]));

                        td.MinRange = (int)(100 * cum1) + 1;
                        float f = float.Parse(words[1]);
                        float M1 = (100 * f);
                        int M2 = (int)(100 * cum1);
                        td.MaxRange = (int)M1 + M2;

                        row.Cells[3].Value = td.MinRange + "-" + td.MaxRange;
                        cum1 = cum1 + (decimal)f;
                        dataGridView2.Rows.Add(row);
                        i++;
                        BearLife.Add(td);
                    }
                    ss.BearingLifeDistribution = BearLife;
                }

            }
        }

    }
}
