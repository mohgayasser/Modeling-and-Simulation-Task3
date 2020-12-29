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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        List<BearingMachineModels.TimeDistribution> DelayTime = new List<BearingMachineModels.TimeDistribution>();
        int indexOfBear = 0;
        List<ProposedSimulationCase> ListProposed = new List<ProposedSimulationCase>();
        SimulationSystem sscpy = Form1.ss;
        Random randomBearLife = new Random();
        Random randomDelay = new Random();
        Bearing bearing = new Bearing();
        public List<int> Cout = Form1.Coutofeachbear;
        public static PerformanceMeasures performanceMeasures = new PerformanceMeasures();
        int c = 0;

        private void Form3_Load(object sender, EventArgs e)
        {


            int nbear = sscpy.NumberOfBearings;
            DataTable dt = new DataTable();
            DataRow dr = null;
            List<BearingMachineModels.Bearing> Listbear = new List<BearingMachineModels.Bearing>();
            DataTable table = new DataTable();
            int indexOfBear = 0;
            int tothrs = sscpy.NumberOfHours;
            int hrs = 0;
            int c = 0;
            int totdelay = 0;

            dt.Columns.Add(new DataColumn("Row index", typeof(string)));

            for (int i = 0; i < nbear; i++)
            {
                dt.Columns.Add(new DataColumn("bear" + (i + 1), typeof(string)));

            }
            dt.Columns.Add(new DataColumn("First Failure", typeof(string)));
            dt.Columns.Add(new DataColumn("Accumlative hours", typeof(string)));
            dt.Columns.Add(new DataColumn("Rd", typeof(string)));
            dt.Columns.Add(new DataColumn("Delay minuites", typeof(string)));
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.DataSource = dt;
            List<int> rangescounters = new List<int>(Cout);
            for(int y = -0; y < nbear; y++)
            {
                rangescounters[y]--;
            }
      
            int index = 0;
            while (hrs <= tothrs)
            {
                Listbear.Clear();
                ProposedSimulationCase Propsimulation = new ProposedSimulationCase();
                index = c;
                int ls = 0;
                for (int i = 0; i < nbear; i++)
                {
                  
                    if (rangescounters[i]>=0)
                    {
                       
                        bearing = new Bearing();
                        bearing = Form1.ListcurrentSimulation[index].Bearing;
                        index += Cout[i];
                        Propsimulation.Bearings.Add(bearing);
                        rangescounters[i]--;
                    }
                 else
                    {
                     
                        Bearing missingBearing = new Bearing();
                        missingBearing.RandomHours = randomDelay.Next(1, 100);
                        missingBearing.Index = i + 1;
                        for (int j = 0; j < sscpy.BearingLifeDistribution.Count; j++)
                        {
                            if (missingBearing.RandomHours <= sscpy.BearingLifeDistribution[j].MaxRange && missingBearing.RandomHours >= sscpy.BearingLifeDistribution[j].MinRange)
                            {
                                missingBearing.Hours = sscpy.BearingLifeDistribution[j].Time;
                                break;
                            }
                        }

                       
                        index += Cout[i];
                        Propsimulation.Bearings.Add(missingBearing);
                  }
            

                }


                int min ;
                min = Propsimulation.Bearings[0].Hours;
                for (int x = 0; x < nbear; x++)
                {
                   
                    if (x + 1 < nbear)
                    {
                        if (min > Propsimulation.Bearings[x + 1].Hours)
                        {
                            min = Propsimulation.Bearings[x + 1].Hours;
                        }
                    }
                    else break;
                }
                Propsimulation.FirstFailure = min;
                if (c == 0)
                {
                    Propsimulation.AccumulatedHours = Propsimulation.FirstFailure;
                }
                else
                {
                    Propsimulation.AccumulatedHours = ListProposed[c - 1].AccumulatedHours + Propsimulation.FirstFailure;
                }

                Propsimulation.RandomDelay = randomDelay.Next(1, 100);


                for (int j = 0; j < sscpy.DelayTimeDistribution.Count; j++)
                {
                    if (Propsimulation.RandomDelay <= sscpy.DelayTimeDistribution[j].MaxRange && Propsimulation.RandomDelay >= sscpy.DelayTimeDistribution[j].MinRange)
                    {
                        Propsimulation.Delay = sscpy.DelayTimeDistribution[j].Time;
                        break;
                    }
                }
               
                if (c == 0)
                {
                    Propsimulation.TotalDelay = Propsimulation.Delay;
                }
                else
                {
                    Propsimulation.TotalDelay = ListProposed[c-1].TotalDelay+Propsimulation.Delay;

                }
                c++;
                totdelay += Propsimulation.TotalDelay;
                hrs = Propsimulation.AccumulatedHours;
                ListProposed.Add(Propsimulation);
               
            }

            performanceMeasures.BearingCost = (decimal)( (c * nbear) * sscpy.BearingCost); 
            performanceMeasures.DelayCost = (decimal)(ListProposed[ListProposed.Count - 1].TotalDelay*sscpy.DowntimeCost);
            performanceMeasures.DowntimeCost = (decimal)( c * sscpy.RepairTimeForAllBearings*sscpy.DowntimeCost);
            performanceMeasures.RepairPersonCost = (decimal)((decimal)(c * sscpy.RepairTimeForAllBearings )* (decimal)sscpy.RepairPersonCost / 60);
            performanceMeasures.TotalCost = (decimal)( performanceMeasures.BearingCost + performanceMeasures.DelayCost + performanceMeasures.DowntimeCost + performanceMeasures.RepairPersonCost);
            textBox1.Text = totdelay.ToString();

            Form1.ss.ProposedSimulationTable =  ListProposed;
            Form1.ss.ProposedPerformanceMeasures = performanceMeasures;
            
           for(int i=0;i < Form1.ss.ProposedSimulationTable.Count-1;i++)
            {
                dr = dt.NewRow();
                dr["Row index"] = i;

                for (int l = 0; l < nbear; l++)
                {

                    dr["bear" + (l + 1).ToString()] = Form1.ss.ProposedSimulationTable[i].Bearings[l].Hours;

                }
                dr["First Failure"] = Form1.ss.ProposedSimulationTable[i].FirstFailure;
                dr["Accumlative hours"] = Form1.ss.ProposedSimulationTable[i].AccumulatedHours;
                dr["Rd"] = Form1.ss.ProposedSimulationTable[i].RandomDelay;
                dr["Delay minuites"] = Form1.ss.ProposedSimulationTable[i].Delay;

                dt.Rows.Add(dr);

                dataGridView1.DataSource = dt;
            }
         //string testingResult = TestingManager.Test(Form1.ss, Constants.FileNames.TestCase1);
             string testingResult = TestingManager.Test(Form1.ss, Constants.FileNames.TestCase2);
         //  string testingResult = TestingManager.Test(Form1.ss, Constants.FileNames.TestCase3);
            MessageBox.Show(testingResult);
        


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
