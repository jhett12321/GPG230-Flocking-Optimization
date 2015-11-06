using System;
using System.IO;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace FlockingLauncher
{
    public partial class mainForm : Form
    {
        private Config config;

        //Main Load Functions
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            agentRatio_ValueChanged(null, null);

            preyAvoidanceEnabled.Checked = true;
            preyGroupingEnabled.Checked = true;
            preyHeadingEnabled.Checked = true;
            preySpeedEnabled.Checked = true;
            preyFleeEnabled.Checked = true;

            //Create our Config Instance.
            config = new Config();
        }

        //Our Custom Functions.
        private void UpdateAgentCounts()
        {
            float predatorRatio = (float)(agentRatio.Value) / 100f;
            float preyRatio = (float)(100 - agentRatio.Value) / 100f;

            double predatorCount = Math.Round(predatorRatio * (double)totalAgents.Value);
            double preyCount = (double)totalAgents.Value - predatorCount;

            agentRatioValue.Text = predatorCount.ToString() + " Predators, " + preyCount.ToString() + " Prey";
        }

        private void Save()
        {
            Export(Application.StartupPath + "config.json");
        }

        private void Export(string fileName)
        {
            PrepareConfig();

            using (StreamWriter file = File.CreateText(@fileName))
            {
               JsonSerializer serializer = new JsonSerializer();
               serializer.Serialize(file, config);
            }
        }

        private void PrepareConfig()
        {
            // General Agent Options
            config.totalAgents = Convert.ToInt32(totalAgents.Value);
            config.agentRatio = (float)agentRatio.Value / 100;
            config.rndSpawn = rndSpawn.Checked;

            // Prey Options
            config.preyMaxSpawnRad = Convert.ToSingle(preyMaxSpawnRad.Value);
            config.preyMinSpawnRad = Convert.ToSingle(preyMinSpawnRad.Value);
            config.preySpawnPosY = Convert.ToInt32(preySpawnPosY.Value);
            config.preySpawnPosX = Convert.ToInt32(preySpawnPosX.Value);
            config.preyMaxMass = Convert.ToSingle(preyMaxMass.Value);
            config.preyMinMass = Convert.ToSingle(preyMinMass.Value);
            config.preyMaxSize = Convert.ToSingle(preyMaxSize.Value);
            config.preyMinSize = Convert.ToSingle(preyMinSize.Value);
            config.preyMaxStartVel = Convert.ToSingle(preyMaxStartVel.Value);
            config.preyMinStartVel = Convert.ToSingle(preyMinStartVel.Value);
            config.preyMaxAccel = Convert.ToSingle(preyMaxAccel.Value);
            config.preyMinAccel = Convert.ToSingle(preyMinAccel.Value);

            // Predator Options
            config.predMaxSpawnRad = Convert.ToSingle(predMaxSpawnRad.Value);
            config.predMinSpawnRad = Convert.ToSingle(predMinSpawnRad.Value);
            config.predSpawnPosY = Convert.ToInt32(predSpawnPosX.Value);
            config.predSpawnPosX = Convert.ToInt32(predSpawnPosX.Value);
            config.predMaxMass = Convert.ToSingle(predMaxMass.Value);
            config.predMinMass = Convert.ToSingle(predMinMass.Value);
            config.predMaxSize = Convert.ToSingle(predMaxSize.Value);
            config.predMinSize = Convert.ToSingle(predMinSize.Value);
            config.predMaxVel = Convert.ToSingle(predMaxVel.Value);
            config.predMinVel = Convert.ToSingle(predMinVel.Value);
            config.predMaxAccel = Convert.ToSingle(predMaxAccel.Value);
            config.predMinAccel = Convert.ToSingle(predMinAccel.Value);

            // Prey Behaviours
            config.preyFleeMaxInf = Convert.ToSingle(preyFleeMaxInf.Value);
            config.preyFleeMinInf = Convert.ToSingle(preyFleeMinInf.Value);
            config.preyFleeMaxAng = Convert.ToSingle(preyFleeMaxAng.Value);
            config.preyFleeMinAng = Convert.ToSingle(preyFleeMinAng.Value);
            config.preyFleeMaxRad = Convert.ToSingle(preyFleeMaxRad.Value);
            config.preyFleeMinRad = Convert.ToSingle(preyFleeMinRad.Value);
            config.preyFleeEnabled = preyFleeEnabled.Checked;

            config.preySpeedMaxInf = Convert.ToSingle(preySpeedMaxInf.Value);
            config.preySpeedMinInf = Convert.ToSingle(preySpeedMinInf.Value);
            config.preySpeedMaxAng = Convert.ToSingle(preySpeedMaxAng.Value);
            config.preySpeedMinAng = Convert.ToSingle(preySpeedMinAng.Value);
            config.preySpeedMaxRad = Convert.ToSingle(preySpeedMaxRad.Value);
            config.preySpeedMinRad = Convert.ToSingle(preySpeedMinRad.Value);
            config.preySpeedEnabled = preySpeedEnabled.Checked;

            config.preyHeadingMaxInf = Convert.ToSingle(preyHeadingMaxInf.Value);
            config.preyHeadingMinInf = Convert.ToSingle(preyHeadingMinInf.Value);
            config.preyHeadingMaxAng = Convert.ToSingle(preyHeadingMaxAng.Value);
            config.preyHeadingMinAng = Convert.ToSingle(preyHeadingMinAng.Value);
            config.preyHeadingMaxRad = Convert.ToSingle(preyHeadingMaxRad.Value);
            config.preyHeadingMinRad = Convert.ToSingle(preyHeadingMinRad.Value);
            config.preyHeadingEnabled = preyHeadingEnabled.Checked;

            config.preyGroupingMaxInf = Convert.ToSingle(preyGroupingMaxInf.Value);
            config.preyGroupingMinInf = Convert.ToSingle(preyGroupingMinInf.Value);
            config.preyGroupingMaxAng = Convert.ToSingle(preyGroupingMaxAng.Value);
            config.preyGroupingMinAng = Convert.ToSingle(preyGroupingMinAng.Value);
            config.preyGroupingMaxRad = Convert.ToSingle(preyGroupingMaxRad.Value);
            config.preyGroupingMinRad = Convert.ToSingle(preyGroupingMinRad.Value);
            config.preyGroupingEnabled = preyGroupingEnabled.Checked;

            config.preyAvoidanceMaxInf = Convert.ToSingle(preyAvoidanceMaxInf.Value);
            config.preyAvoidanceMinInf = Convert.ToSingle(preyAvoidanceMinInf.Value);
            config.preyAvoidanceMaxAng = Convert.ToSingle(preyAvoidanceMaxAng.Value);
            config.preyAvoidanceMinAng = Convert.ToSingle(preyAvoidanceMinAng.Value);
            config.preyAvoidanceMaxRad = Convert.ToSingle(preyAvoidanceMaxRad.Value);
            config.preyAvoidanceMinRad = Convert.ToSingle(preyAvoidanceMinRad.Value);
            config.preyAvoidanceEnabled = preyAvoidanceEnabled.Checked;

            // Predator Behaviours
            config.predChaseMaxInf = Convert.ToSingle(predChaseMaxInf.Value);
            config.predChaseMinInf = Convert.ToSingle(predChaseMinInf.Value);
            config.predChaseMaxAng = Convert.ToSingle(predChaseMaxAng.Value);
            config.predChaseMinAng = Convert.ToSingle(predChaseMinAng.Value);
            config.predChaseMaxRad = Convert.ToSingle(predChaseMaxRad.Value);
            config.predChaseMinRad = Convert.ToSingle(predChaseMinRad.Value);
            config.predChaseEnabled = predChaseEnabled.Checked;

            config.predFleeMaxInf = Convert.ToSingle(predFleeMaxInf.Value);
            config.predFleeMinInf = Convert.ToSingle(predFleeMinInf.Value);
            config.predFleeMaxAng = Convert.ToSingle(predFleeMaxAng.Value);
            config.predFleeMinAng = Convert.ToSingle(predFleeMinAng.Value);
            config.predFleeMaxRad = Convert.ToSingle(predFleeMaxRad.Value);
            config.predFleeMinRad = Convert.ToSingle(predFleeMinRad.Value);
            config.predFleeEnabled = predFleeEnabled.Checked;

            config.predSpeedMaxInf = Convert.ToSingle(predSpeedMaxInf.Value);
            config.predSpeedMinInf = Convert.ToSingle(predSpeedMinInf.Value);
            config.predSpeedMaxAng = Convert.ToSingle(predSpeedMaxAng.Value);
            config.predSpeedMinAng = Convert.ToSingle(predSpeedMinAng.Value);
            config.predSpeedMaxRad = Convert.ToSingle(predSpeedMaxRad.Value);
            config.predSpeedMinRad = Convert.ToSingle(predSpeedMinRad.Value);
            config.predSpeedEnabled = predSpeedEnabled.Checked;

            config.predHeadingMaxInf = Convert.ToSingle(predHeadingMaxInf.Value);
            config.predHeadingMinInf = Convert.ToSingle(predHeadingMinInf.Value);
            config.predHeadingMaxAng = Convert.ToSingle(predHeadingMaxAng.Value);
            config.predHeadingMinAng = Convert.ToSingle(predHeadingMinAng.Value);
            config.predHeadingMaxRad = Convert.ToSingle(predHeadingMaxRad.Value);
            config.predHeadingMinRad = Convert.ToSingle(predHeadingMinRad.Value);
            config.predHeadingEnabled = predHeadingEnabled.Checked;

            config.predGroupingMaxInf = Convert.ToSingle(predGroupingMaxInf.Value);
            config.predGroupingMinInf = Convert.ToSingle(predGroupingMinInf.Value);
            config.predGroupingMaxAng = Convert.ToSingle(predGroupingMaxAng.Value);
            config.predGroupingMinAng = Convert.ToSingle(predGroupingMinAng.Value);
            config.predGroupingMaxRad = Convert.ToSingle(predGroupingMaxRad.Value);
            config.predGroupingMinRad = Convert.ToSingle(predGroupingMinRad.Value);
            config.predGroupingEnabled = predGroupingEnabled.Checked;

            config.predAvoidanceMaxInf = Convert.ToSingle(predAvoidanceMaxInf.Value);
            config.predAvoidanceMinInf = Convert.ToSingle(predAvoidanceMinInf.Value);
            config.predAvoidanceMaxAng = Convert.ToSingle(predAvoidanceMaxAng.Value);
            config.predAvoidanceMinAng = Convert.ToSingle(predAvoidanceMinAng.Value);
            config.predAvoidanceMaxRad = Convert.ToSingle(predAvoidanceMaxRad.Value);
            config.predAvoidanceMinRad = Convert.ToSingle(predAvoidanceMinRad.Value);
            config.predAvoidanceEnabled = predAvoidanceEnabled.Checked;

            // Client Options
            config.clientPhysInt = Convert.ToSingle(clientPhysInt.Value);
            config.frameRateLockEnabled = frameRateLockEnabled.Checked;
            config.frameRateCapAmt = Convert.ToInt32(frameRateCapAmt.Value);

            // Client Network
            config.clientConnectIP = clientConnectIP.Text;
            config.broadcastEnabled = broadcastEnabled.Checked;
            config.clientConnectPort = UInt32.Parse(clientConnectPort.Text);

            // Server Options
            config.serverMaxClients = Convert.ToInt32(serverMaxClients.Value);
            config.maxAgentsPerC = Convert.ToInt32(maxAgentsPerC.Value);
            config.serverPhysInt = Convert.ToSingle(serverPhysInt.Value); ;

            // Server Network
            config.serverPort = UInt32.Parse(serverPort.Text);
        }

        private void ImportConfig(Config config)
        {
            // General Agent Options
            totalAgents.Value = Convert.ToDecimal(config.totalAgents);
            agentRatio.Value = Convert.ToInt32(config.agentRatio * 100);
            rndSpawn.Checked = config.rndSpawn;

            // Prey Options
            preyMaxSpawnRad.Value = Convert.ToDecimal(config.preyMaxSpawnRad);
            preyMinSpawnRad.Value = Convert.ToDecimal(config.preyMinSpawnRad);
            preySpawnPosY.Value = Convert.ToDecimal(config.preySpawnPosY);
            preySpawnPosX.Value = Convert.ToDecimal(config.preySpawnPosX);
            preyMaxMass.Value = Convert.ToDecimal(config.preyMaxMass);
            preyMinMass.Value = Convert.ToDecimal(config.preyMinMass);
            preyMaxSize.Value = Convert.ToDecimal(config.preyMaxSize);
            preyMinSize.Value = Convert.ToDecimal(config.preyMinSize);
            preyMaxStartVel.Value = Convert.ToDecimal(config.preyMaxStartVel);
            preyMinStartVel.Value = Convert.ToDecimal(config.preyMinStartVel);
            preyMaxAccel.Value = Convert.ToDecimal(config.preyMaxAccel);
            preyMinAccel.Value = Convert.ToDecimal(config.preyMinAccel);

            // Predator Options
            predMaxSpawnRad.Value = Convert.ToDecimal(config.predMaxSpawnRad);
            predMinSpawnRad.Value = Convert.ToDecimal(config.predMinSpawnRad);
            predSpawnPosX.Value = Convert.ToDecimal(config.predSpawnPosY);
            predSpawnPosX.Value = Convert.ToDecimal(config.predSpawnPosX);
            predMaxMass.Value = Convert.ToDecimal(config.predMaxMass);
            predMinMass.Value = Convert.ToDecimal(config.predMinMass);
            predMaxSize.Value = Convert.ToDecimal(config.predMaxSize);
            predMinSize.Value = Convert.ToDecimal(config.predMinSize);
            predMaxVel.Value = Convert.ToDecimal(config.predMaxVel);
            predMinVel.Value = Convert.ToDecimal(config.predMinVel);
            predMaxAccel.Value = Convert.ToDecimal(config.predMaxAccel);
            predMinAccel.Value = Convert.ToDecimal(config.predMinAccel);

            // Prey Behaviours
            preyFleeMaxInf.Value = Convert.ToDecimal(config.preyFleeMaxInf);
            preyFleeMinInf.Value = Convert.ToDecimal(config.preyFleeMinInf);
            preyFleeMaxAng.Value = Convert.ToDecimal(config.preyFleeMaxAng);
            preyFleeMinAng.Value = Convert.ToDecimal(config.preyFleeMinAng);
            preyFleeMaxRad.Value = Convert.ToDecimal(config.preyFleeMaxRad);
            preyFleeMinRad.Value = Convert.ToDecimal(config.preyFleeMinRad);
            preyFleeEnabled.Checked = config.preyFleeEnabled;

            preySpeedMaxInf.Value = Convert.ToDecimal(config.preySpeedMaxInf);
            preySpeedMinInf.Value = Convert.ToDecimal(config.preySpeedMinInf);
            preySpeedMaxAng.Value = Convert.ToDecimal(config.preySpeedMaxAng);
            preySpeedMinAng.Value = Convert.ToDecimal(config.preySpeedMinAng);
            preySpeedMaxRad.Value = Convert.ToDecimal(config.preySpeedMaxRad);
            preySpeedMinRad.Value = Convert.ToDecimal(config.preySpeedMinRad);
            preySpeedEnabled.Checked = config.preySpeedEnabled;

            preyHeadingMaxInf.Value = Convert.ToDecimal(config.preyHeadingMaxInf);
            preyHeadingMinInf.Value = Convert.ToDecimal(config.preyHeadingMinInf);
            preyHeadingMaxAng.Value = Convert.ToDecimal(config.preyHeadingMaxAng);
            preyHeadingMinAng.Value = Convert.ToDecimal(config.preyHeadingMinAng);
            preyHeadingMaxRad.Value = Convert.ToDecimal(config.preyHeadingMaxRad);
            preyHeadingMinRad.Value = Convert.ToDecimal(config.preyHeadingMinRad);
            preyHeadingEnabled.Checked = config.preyHeadingEnabled;

            preyGroupingMaxInf.Value = Convert.ToDecimal(config.preyGroupingMaxInf);
            preyGroupingMinInf.Value = Convert.ToDecimal(config.preyGroupingMinInf);
            preyGroupingMaxAng.Value = Convert.ToDecimal(config.preyGroupingMaxAng);
            preyGroupingMinAng.Value = Convert.ToDecimal(config.preyGroupingMinAng);
            preyGroupingMaxRad.Value = Convert.ToDecimal(config.preyGroupingMaxRad);
            preyGroupingMinRad.Value = Convert.ToDecimal(config.preyGroupingMinRad);
            preyGroupingEnabled.Checked = config.preyGroupingEnabled;

            preyAvoidanceMaxInf.Value = Convert.ToDecimal(config.preyAvoidanceMaxInf);
            preyAvoidanceMinInf.Value = Convert.ToDecimal(config.preyAvoidanceMinInf);
            preyAvoidanceMaxAng.Value = Convert.ToDecimal(config.preyAvoidanceMaxAng);
            preyAvoidanceMinAng.Value = Convert.ToDecimal(config.preyAvoidanceMinAng);
            preyAvoidanceMaxRad.Value = Convert.ToDecimal(config.preyAvoidanceMaxRad);
            preyAvoidanceMinRad.Value = Convert.ToDecimal(config.preyAvoidanceMinRad);
            preyAvoidanceEnabled.Checked = config.preyAvoidanceEnabled;

            // Predator Behaviours
            predChaseMaxInf.Value = Convert.ToDecimal(config.predChaseMaxInf);
            predChaseMinInf.Value = Convert.ToDecimal(config.predChaseMinInf);
            predChaseMaxAng.Value = Convert.ToDecimal(config.predChaseMaxAng);
            predChaseMinAng.Value = Convert.ToDecimal(config.predChaseMinAng);
            predChaseMaxRad.Value = Convert.ToDecimal(config.predChaseMaxRad);
            predChaseMinRad.Value = Convert.ToDecimal(config.predChaseMinRad);
            predChaseEnabled.Checked = config.predChaseEnabled;

            predFleeMaxInf.Value = Convert.ToDecimal(config.predFleeMaxInf);
            predFleeMinInf.Value = Convert.ToDecimal(config.predFleeMinInf);
            predFleeMaxAng.Value = Convert.ToDecimal(config.predFleeMaxAng);
            predFleeMinAng.Value = Convert.ToDecimal(config.predFleeMinAng);
            predFleeMaxRad.Value = Convert.ToDecimal(config.predFleeMaxRad);
            predFleeMinRad.Value = Convert.ToDecimal(config.predFleeMinRad);
            predFleeEnabled.Checked = config.predFleeEnabled;

            predSpeedMaxInf.Value = Convert.ToDecimal(config.predSpeedMaxInf);
            predSpeedMinInf.Value = Convert.ToDecimal(config.predSpeedMinInf);
            predSpeedMaxAng.Value = Convert.ToDecimal(config.predSpeedMaxAng);
            predSpeedMinAng.Value = Convert.ToDecimal(config.predSpeedMinAng);
            predSpeedMaxRad.Value = Convert.ToDecimal(config.predSpeedMaxRad);
            predSpeedMinRad.Value = Convert.ToDecimal(config.predSpeedMinRad);
            predSpeedEnabled.Checked = config.predSpeedEnabled;

            predHeadingMaxInf.Value = Convert.ToDecimal(config.predHeadingMaxInf);
            predHeadingMinInf.Value = Convert.ToDecimal(config.predHeadingMinInf);
            predHeadingMaxAng.Value = Convert.ToDecimal(config.predHeadingMaxAng);
            predHeadingMinAng.Value = Convert.ToDecimal(config.predHeadingMinAng);
            predHeadingMaxRad.Value = Convert.ToDecimal(config.predHeadingMaxRad);
            predHeadingMinRad.Value = Convert.ToDecimal(config.predHeadingMinRad);
            predHeadingEnabled.Checked = config.predHeadingEnabled;

            predGroupingMaxInf.Value = Convert.ToDecimal(config.predGroupingMaxInf);
            predGroupingMinInf.Value = Convert.ToDecimal(config.predGroupingMinInf);
            predGroupingMaxAng.Value = Convert.ToDecimal(config.predGroupingMaxAng);
            predGroupingMinAng.Value = Convert.ToDecimal(config.predGroupingMinAng);
            predGroupingMaxRad.Value = Convert.ToDecimal(config.predGroupingMaxRad);
            predGroupingMinRad.Value = Convert.ToDecimal(config.predGroupingMinRad);
            predGroupingEnabled.Checked = config.predGroupingEnabled;

            predAvoidanceMaxInf.Value = Convert.ToDecimal(config.predAvoidanceMaxInf);
            predAvoidanceMinInf.Value = Convert.ToDecimal(config.predAvoidanceMinInf);
            predAvoidanceMaxAng.Value = Convert.ToDecimal(config.predAvoidanceMaxAng);
            predAvoidanceMinAng.Value = Convert.ToDecimal(config.predAvoidanceMinAng);
            predAvoidanceMaxRad.Value = Convert.ToDecimal(config.predAvoidanceMaxRad);
            predAvoidanceMinRad.Value = Convert.ToDecimal(config.predAvoidanceMinRad);
            predAvoidanceEnabled.Checked = config.predAvoidanceEnabled;

            // Client Options
            clientPhysInt.Value = Convert.ToDecimal(config.clientPhysInt);
            frameRateLockEnabled.Checked = config.frameRateLockEnabled;
            frameRateCapAmt.Value = Convert.ToDecimal(config.frameRateCapAmt);

            // Client Network
            clientConnectIP.Text = config.clientConnectIP;
            broadcastEnabled.Checked = config.broadcastEnabled;
            clientConnectPort.Text = config.clientConnectPort.ToString();

            // Server Options
            serverMaxClients.Value = Convert.ToDecimal(config.serverMaxClients);
            maxAgentsPerC.Value = Convert.ToDecimal(config.maxAgentsPerC);
            serverPhysInt.Value = Convert.ToDecimal(config.serverPhysInt); ;

            // Server Network
            serverPort.Text = config.serverPort.ToString();
        }

        //Generated Event Handlers.
        private void importButton_Click(object sender, EventArgs e)
        {
            string filename = "";

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "JSON files (*.json)|*.JSON|All files (*.*)|*.*";

            DialogResult dr=ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
               filename = ofd.FileName;
            }

            if (filename != "")
            {
                try
                {
                    // Load JSON from file.
                    using (StreamReader file = File.OpenText(@filename))
                    {
                        JsonSerializer serializer = new JsonSerializer();

                        Config configImport = (Config)serializer.Deserialize(file, typeof(Config));

                        ImportConfig(configImport);
                        PrepareConfig();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Could not import specified JSON File! \n" + ex.Message, "Config Import Failed", MessageBoxButtons.OK);
                }
            }
        }

        //TODO
        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            dlg.Title = "Export in JSON format";

            //decide whether we need to check file exists
            //dlg.CheckFileExists = true;

            //this is the default behaviour
            dlg.CheckPathExists = true;

            //If InitialDirectory is not specified, the default path is My Documents
            //dlg.InitialDirectory = Application.StartupPath;

            dlg.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (dlg.FileName != "")
            {
                Export(dlg.FileName);
            }

            //dlg.Dispose();
        }

        private void agentRatio_ValueChanged(object sender, EventArgs e)
        {
            UpdateAgentCounts();
        }

        private void totalAgents_ValueChanged(object sender, EventArgs e)
        {
            UpdateAgentCounts();
        }

        private void preyAvoidanceEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (preyAvoidanceEnabled.Checked)
            {
                preyAvoidanceMinRad.Enabled = true;
                preyAvoidanceMaxRad.Enabled = true;

                preyAvoidanceMinAng.Enabled = true;
                preyAvoidanceMaxAng.Enabled = true;

                preyAvoidanceMinInf.Enabled = true;
                preyAvoidanceMaxInf.Enabled = true;
            }

            else
            {
                preyAvoidanceMinRad.Enabled = false;
                preyAvoidanceMaxRad.Enabled = false;

                preyAvoidanceMinAng.Enabled = false;
                preyAvoidanceMaxAng.Enabled = false;

                preyAvoidanceMinInf.Enabled = false;
                preyAvoidanceMaxInf.Enabled = false;
            }
        }

        private void preyGroupingEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (preyGroupingEnabled.Checked)
            {
                preyGroupingMinRad.Enabled = true;
                preyGroupingMaxRad.Enabled = true;

                preyGroupingMinAng.Enabled = true;
                preyGroupingMaxAng.Enabled = true;

                preyGroupingMinInf.Enabled = true;
                preyGroupingMaxInf.Enabled = true;
            }

            else
            {
                preyGroupingMinRad.Enabled = false;
                preyGroupingMaxRad.Enabled = false;

                preyGroupingMinAng.Enabled = false;
                preyGroupingMaxAng.Enabled = false;

                preyGroupingMinInf.Enabled = false;
                preyGroupingMaxInf.Enabled = false;
            }
        }

        private void preyHeadingEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (preyHeadingEnabled.Checked)
            {
                preyHeadingMinRad.Enabled = true;
                preyHeadingMaxRad.Enabled = true;

                preyHeadingMinAng.Enabled = true;
                preyHeadingMaxAng.Enabled = true;

                preyHeadingMinInf.Enabled = true;
                preyHeadingMaxInf.Enabled = true;
            }

            else
            {
                preyHeadingMinRad.Enabled = false;
                preyHeadingMaxRad.Enabled = false;

                preyHeadingMinAng.Enabled = false;
                preyHeadingMaxAng.Enabled = false;

                preyHeadingMinInf.Enabled = false;
                preyHeadingMaxInf.Enabled = false;
            }
        }

        private void preySpeedEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (preySpeedEnabled.Checked)
            {
                preySpeedMinRad.Enabled = true;
                preySpeedMaxRad.Enabled = true;

                preySpeedMinAng.Enabled = true;
                preySpeedMaxAng.Enabled = true;

                preySpeedMinInf.Enabled = true;
                preySpeedMaxInf.Enabled = true;
            }

            else
            {
                preySpeedMinRad.Enabled = false;
                preySpeedMaxRad.Enabled = false;

                preySpeedMinAng.Enabled = false;
                preySpeedMaxAng.Enabled = false;

                preySpeedMinInf.Enabled = false;
                preySpeedMaxInf.Enabled = false;
            }
        }

        private void preyFleeEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (preyFleeEnabled.Checked)
            {
                preyFleeMinRad.Enabled = true;
                preyFleeMaxRad.Enabled = true;

                preyFleeMinAng.Enabled = true;
                preyFleeMaxAng.Enabled = true;

                preyFleeMinInf.Enabled = true;
                preyFleeMaxInf.Enabled = true;
            }

            else
            {
                preyFleeMinRad.Enabled = false;
                preyFleeMaxRad.Enabled = false;

                preyFleeMinAng.Enabled = false;
                preyFleeMaxAng.Enabled = false;

                preyFleeMinInf.Enabled = false;
                preyFleeMaxInf.Enabled = false;
            }
        }

        private void predAvoidanceEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (predAvoidanceEnabled.Checked)
            {
                predAvoidanceMinRad.Enabled = true;
                predAvoidanceMaxRad.Enabled = true;

                predAvoidanceMinAng.Enabled = true;
                predAvoidanceMaxAng.Enabled = true;

                predAvoidanceMinInf.Enabled = true;
                predAvoidanceMaxInf.Enabled = true;
            }

            else
            {
                predAvoidanceMinRad.Enabled = false;
                predAvoidanceMaxRad.Enabled = false;

                predAvoidanceMinAng.Enabled = false;
                predAvoidanceMaxAng.Enabled = false;

                predAvoidanceMinInf.Enabled = false;
                predAvoidanceMaxInf.Enabled = false;
            }
        }

        private void predGroupingEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (predGroupingEnabled.Checked)
            {
                predGroupingMinRad.Enabled = true;
                predGroupingMaxRad.Enabled = true;

                predGroupingMinAng.Enabled = true;
                predGroupingMaxAng.Enabled = true;

                predGroupingMinInf.Enabled = true;
                predGroupingMaxInf.Enabled = true;
            }

            else
            {
                predGroupingMinRad.Enabled = false;
                predGroupingMaxRad.Enabled = false;

                predGroupingMinAng.Enabled = false;
                predGroupingMaxAng.Enabled = false;

                predGroupingMinInf.Enabled = false;
                predGroupingMaxInf.Enabled = false;
            }
        }

        private void predHeadingEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (predHeadingEnabled.Checked)
            {
                predHeadingMinRad.Enabled = true;
                predHeadingMaxRad.Enabled = true;

                predHeadingMinAng.Enabled = true;
                predHeadingMaxAng.Enabled = true;

                predHeadingMinInf.Enabled = true;
                predHeadingMaxInf.Enabled = true;
            }

            else
            {
                predHeadingMinRad.Enabled = false;
                predHeadingMaxRad.Enabled = false;

                predHeadingMinAng.Enabled = false;
                predHeadingMaxAng.Enabled = false;

                predHeadingMinInf.Enabled = false;
                predHeadingMaxInf.Enabled = false;
            }
        }

        private void predSpeedEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (predSpeedEnabled.Checked)
            {
                predSpeedMinRad.Enabled = true;
                predSpeedMaxRad.Enabled = true;

                predSpeedMinAng.Enabled = true;
                predSpeedMaxAng.Enabled = true;

                predSpeedMinInf.Enabled = true;
                predSpeedMaxInf.Enabled = true;
            }

            else
            {
                predSpeedMinRad.Enabled = false;
                predSpeedMaxRad.Enabled = false;

                predSpeedMinAng.Enabled = false;
                predSpeedMaxAng.Enabled = false;

                predSpeedMinInf.Enabled = false;
                predSpeedMaxInf.Enabled = false;
            }
        }

        private void predFleeEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (predFleeEnabled.Checked)
            {
                predFleeMinRad.Enabled = true;
                predFleeMaxRad.Enabled = true;

                predFleeMinAng.Enabled = true;
                predFleeMaxAng.Enabled = true;

                predFleeMinInf.Enabled = true;
                predFleeMaxInf.Enabled = true;
            }

            else
            {
                predFleeMinRad.Enabled = false;
                predFleeMaxRad.Enabled = false;

                predFleeMinAng.Enabled = false;
                predFleeMaxAng.Enabled = false;

                predFleeMinInf.Enabled = false;
                predFleeMaxInf.Enabled = false;
            }
        }

        private void predChaseEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (predChaseEnabled.Checked)
            {
                predChaseMinRad.Enabled = true;
                predChaseMaxRad.Enabled = true;

                predChaseMinAng.Enabled = true;
                predChaseMaxAng.Enabled = true;

                predChaseMinInf.Enabled = true;
                predChaseMaxInf.Enabled = true;
            }

            else
            {
                predChaseMinRad.Enabled = false;
                predChaseMaxRad.Enabled = false;

                predChaseMinAng.Enabled = false;
                predChaseMaxAng.Enabled = false;

                predChaseMinInf.Enabled = false;
                predChaseMaxInf.Enabled = false;
            }
        }

        private void checkBoxRndSpawn_CheckedChanged(object sender, EventArgs e)
        {
            if (rndSpawn.Checked)
            {
                preySpawnPosX.Enabled = false;
                preySpawnPosY.Enabled = false;

                predSpawnPosX.Enabled = false;
                predSpawnPosY.Enabled = false;
            }

            else
            {
                preySpawnPosX.Enabled = true;
                preySpawnPosY.Enabled = true;

                predSpawnPosX.Enabled = true;
                predSpawnPosY.Enabled = true;
            }
        }

        private void clientConnectPort_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Utils.ValidatePort(clientConnectPort.Text))
            {
                return;
            }

            e.Cancel = true;
        }

        private void broadcastEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (broadcastEnabled.Checked)
            {
                clientConnectIP.Enabled = false;
            }

            else
            {
                clientConnectIP.Enabled = true;
            }
        }

        private void frameRateLockEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (frameRateLockEnabled.Checked)
            {
                frameRateCapAmt.Enabled = true;
            }

            else
            {
                frameRateCapAmt.Enabled = false;
            }
        }

    }
}
