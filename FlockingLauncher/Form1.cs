using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlockingLauncher
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            agentRatio_ValueChanged(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string filename = "";

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "JSON File (*.json)|*.JSON|All files (*.*)|*.*";

            DialogResult dr=ofd.ShowDialog();
 
            if (dr == DialogResult.OK)
            {
               filename = ofd.FileName;
            }

            if (filename!="")
            {
                //We Load the JSON
            }
        }

        private void startLocal_Click(object sender, EventArgs e)
        {

        }

        private void agentRatio_ValueChanged(object sender, EventArgs e)
        {
            UpdateAgentCounts();
        }

        private void totalAgents_ValueChanged(object sender, EventArgs e)
        {
            UpdateAgentCounts();
        }

        private void UpdateAgentCounts()
        {
            float predatorRatio = (float)(agentRatio.Value) / 100f;
            float preyRatio = (float)(100 - agentRatio.Value) / 100f;

            double predatorCount = Math.Round(predatorRatio * (double)totalAgents.Value);
            double preyCount = (double)totalAgents.Value - predatorCount;

            agentRatioValue.Text = predatorCount.ToString() + " Predators, " + preyCount.ToString() + " Prey";
        }
    }
}
