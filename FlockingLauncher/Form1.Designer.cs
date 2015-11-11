namespace FlockingLauncher
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.optionTabs = new System.Windows.Forms.TabControl();
            this.agentOptions = new System.Windows.Forms.TabPage();
            this.predOptions = new System.Windows.Forms.Panel();
            this.labelPredSpawnRad = new System.Windows.Forms.Label();
            this.predMaxSpawnRad = new System.Windows.Forms.NumericUpDown();
            this.predMinSpawnRad = new System.Windows.Forms.NumericUpDown();
            this.labelPredMass = new System.Windows.Forms.Label();
            this.labelPredSize = new System.Windows.Forms.Label();
            this.labelPredStartVel = new System.Windows.Forms.Label();
            this.labelPredAccel = new System.Windows.Forms.Label();
            this.predMaxMass = new System.Windows.Forms.NumericUpDown();
            this.predMinMass = new System.Windows.Forms.NumericUpDown();
            this.predMaxSize = new System.Windows.Forms.NumericUpDown();
            this.predMinSize = new System.Windows.Forms.NumericUpDown();
            this.predMaxVel = new System.Windows.Forms.NumericUpDown();
            this.predMinVel = new System.Windows.Forms.NumericUpDown();
            this.labelPredOptMax = new System.Windows.Forms.Label();
            this.predMaxAccel = new System.Windows.Forms.NumericUpDown();
            this.labelPredOptMin = new System.Windows.Forms.Label();
            this.predMinAccel = new System.Windows.Forms.NumericUpDown();
            this.predOptionsLabel = new System.Windows.Forms.Label();
            this.preyOptions = new System.Windows.Forms.Panel();
            this.labelPreySpawnRad = new System.Windows.Forms.Label();
            this.preyMaxSpawnRad = new System.Windows.Forms.NumericUpDown();
            this.preyMinSpawnRad = new System.Windows.Forms.NumericUpDown();
            this.labelPreyMass = new System.Windows.Forms.Label();
            this.labelPreySize = new System.Windows.Forms.Label();
            this.labelPreyStartVel = new System.Windows.Forms.Label();
            this.labelPreyAccel = new System.Windows.Forms.Label();
            this.preyMaxMass = new System.Windows.Forms.NumericUpDown();
            this.preyMinMass = new System.Windows.Forms.NumericUpDown();
            this.preyMaxSize = new System.Windows.Forms.NumericUpDown();
            this.preyMinSize = new System.Windows.Forms.NumericUpDown();
            this.preyMaxStartVel = new System.Windows.Forms.NumericUpDown();
            this.preyMinStartVel = new System.Windows.Forms.NumericUpDown();
            this.labelPreyOptMax = new System.Windows.Forms.Label();
            this.preyMaxAccel = new System.Windows.Forms.NumericUpDown();
            this.labelPreyOptMin = new System.Windows.Forms.Label();
            this.preyMinAccel = new System.Windows.Forms.NumericUpDown();
            this.preyOptionsLabel = new System.Windows.Forms.Label();
            this.generalAgentOptions = new System.Windows.Forms.Panel();
            this.rndSpawn = new System.Windows.Forms.CheckBox();
            this.agentRatioValue = new System.Windows.Forms.Label();
            this.labelAgentRatio = new System.Windows.Forms.Label();
            this.totalAgents = new System.Windows.Forms.NumericUpDown();
            this.labelTotalAgents = new System.Windows.Forms.Label();
            this.agentRatio = new System.Windows.Forms.TrackBar();
            this.generalAgentOptionsLabel = new System.Windows.Forms.Label();
            this.agentBehaviours = new System.Windows.Forms.TabPage();
            this.predBehaviour = new System.Windows.Forms.Panel();
            this.predChaseMaxInf = new System.Windows.Forms.NumericUpDown();
            this.predChaseMinInf = new System.Windows.Forms.NumericUpDown();
            this.predChaseMaxAng = new System.Windows.Forms.NumericUpDown();
            this.predChaseMinAng = new System.Windows.Forms.NumericUpDown();
            this.predChaseMaxRad = new System.Windows.Forms.NumericUpDown();
            this.predChaseMinRad = new System.Windows.Forms.NumericUpDown();
            this.predChaseEnabled = new System.Windows.Forms.CheckBox();
            this.predFleeMaxInf = new System.Windows.Forms.NumericUpDown();
            this.predFleeMinInf = new System.Windows.Forms.NumericUpDown();
            this.predFleeMaxAng = new System.Windows.Forms.NumericUpDown();
            this.predFleeMinAng = new System.Windows.Forms.NumericUpDown();
            this.predFleeMaxRad = new System.Windows.Forms.NumericUpDown();
            this.predFleeMinRad = new System.Windows.Forms.NumericUpDown();
            this.predFleeEnabled = new System.Windows.Forms.CheckBox();
            this.predSpeedMaxInf = new System.Windows.Forms.NumericUpDown();
            this.predSpeedMinInf = new System.Windows.Forms.NumericUpDown();
            this.predSpeedMaxAng = new System.Windows.Forms.NumericUpDown();
            this.predSpeedMinAng = new System.Windows.Forms.NumericUpDown();
            this.predSpeedMaxRad = new System.Windows.Forms.NumericUpDown();
            this.predSpeedMinRad = new System.Windows.Forms.NumericUpDown();
            this.predSpeedEnabled = new System.Windows.Forms.CheckBox();
            this.predHeadingMaxInf = new System.Windows.Forms.NumericUpDown();
            this.predHeadingMinInf = new System.Windows.Forms.NumericUpDown();
            this.predHeadingMaxAng = new System.Windows.Forms.NumericUpDown();
            this.predHeadingMinAng = new System.Windows.Forms.NumericUpDown();
            this.predHeadingMaxRad = new System.Windows.Forms.NumericUpDown();
            this.predHeadingMinRad = new System.Windows.Forms.NumericUpDown();
            this.predHeadingEnabled = new System.Windows.Forms.CheckBox();
            this.predGroupingMaxInf = new System.Windows.Forms.NumericUpDown();
            this.predGroupingMinInf = new System.Windows.Forms.NumericUpDown();
            this.predGroupingMaxAng = new System.Windows.Forms.NumericUpDown();
            this.predGroupingMinAng = new System.Windows.Forms.NumericUpDown();
            this.predGroupingMaxRad = new System.Windows.Forms.NumericUpDown();
            this.predGroupingMinRad = new System.Windows.Forms.NumericUpDown();
            this.predGroupingEnabled = new System.Windows.Forms.CheckBox();
            this.labelPredMaxInf = new System.Windows.Forms.Label();
            this.predAvoidanceMaxInf = new System.Windows.Forms.NumericUpDown();
            this.labelPredMinInf = new System.Windows.Forms.Label();
            this.predAvoidanceMinInf = new System.Windows.Forms.NumericUpDown();
            this.labelPredMaxAng = new System.Windows.Forms.Label();
            this.predAvoidanceMaxAng = new System.Windows.Forms.NumericUpDown();
            this.labelPredMinAng = new System.Windows.Forms.Label();
            this.predAvoidanceMinAng = new System.Windows.Forms.NumericUpDown();
            this.labelPredMaxRad = new System.Windows.Forms.Label();
            this.predAvoidanceMaxRad = new System.Windows.Forms.NumericUpDown();
            this.labelPredMinRad = new System.Windows.Forms.Label();
            this.predAvoidanceMinRad = new System.Windows.Forms.NumericUpDown();
            this.predAvoidanceEnabled = new System.Windows.Forms.CheckBox();
            this.predBehaviourLabel = new System.Windows.Forms.Label();
            this.preyBehaviour = new System.Windows.Forms.Panel();
            this.preyFleeMaxInf = new System.Windows.Forms.NumericUpDown();
            this.preyFleeMinInf = new System.Windows.Forms.NumericUpDown();
            this.preyFleeMaxAng = new System.Windows.Forms.NumericUpDown();
            this.preyFleeMinAng = new System.Windows.Forms.NumericUpDown();
            this.preyFleeMaxRad = new System.Windows.Forms.NumericUpDown();
            this.preyFleeMinRad = new System.Windows.Forms.NumericUpDown();
            this.preyFleeEnabled = new System.Windows.Forms.CheckBox();
            this.preySpeedMaxInf = new System.Windows.Forms.NumericUpDown();
            this.preySpeedMinInf = new System.Windows.Forms.NumericUpDown();
            this.preySpeedMaxAng = new System.Windows.Forms.NumericUpDown();
            this.preySpeedMinAng = new System.Windows.Forms.NumericUpDown();
            this.preySpeedMaxRad = new System.Windows.Forms.NumericUpDown();
            this.preySpeedMinRad = new System.Windows.Forms.NumericUpDown();
            this.preySpeedEnabled = new System.Windows.Forms.CheckBox();
            this.preyHeadingMaxInf = new System.Windows.Forms.NumericUpDown();
            this.preyHeadingMinInf = new System.Windows.Forms.NumericUpDown();
            this.preyHeadingMaxAng = new System.Windows.Forms.NumericUpDown();
            this.preyHeadingMinAng = new System.Windows.Forms.NumericUpDown();
            this.preyHeadingMaxRad = new System.Windows.Forms.NumericUpDown();
            this.preyHeadingMinRad = new System.Windows.Forms.NumericUpDown();
            this.preyHeadingEnabled = new System.Windows.Forms.CheckBox();
            this.preyGroupingMaxInf = new System.Windows.Forms.NumericUpDown();
            this.preyGroupingMinInf = new System.Windows.Forms.NumericUpDown();
            this.preyGroupingMaxAng = new System.Windows.Forms.NumericUpDown();
            this.preyGroupingMinAng = new System.Windows.Forms.NumericUpDown();
            this.preyGroupingMaxRad = new System.Windows.Forms.NumericUpDown();
            this.preyGroupingMinRad = new System.Windows.Forms.NumericUpDown();
            this.preyGroupingEnabled = new System.Windows.Forms.CheckBox();
            this.labelPreyMaxInf = new System.Windows.Forms.Label();
            this.preyAvoidanceMaxInf = new System.Windows.Forms.NumericUpDown();
            this.labelPreyMinInf = new System.Windows.Forms.Label();
            this.preyAvoidanceMinInf = new System.Windows.Forms.NumericUpDown();
            this.labelPreyMaxAng = new System.Windows.Forms.Label();
            this.preyAvoidanceMaxAng = new System.Windows.Forms.NumericUpDown();
            this.labelPreyMinAng = new System.Windows.Forms.Label();
            this.preyAvoidanceMinAng = new System.Windows.Forms.NumericUpDown();
            this.labelPreyMaxRad = new System.Windows.Forms.Label();
            this.preyAvoidanceMaxRad = new System.Windows.Forms.NumericUpDown();
            this.labelPreyMinRad = new System.Windows.Forms.Label();
            this.preyAvoidanceMinRad = new System.Windows.Forms.NumericUpDown();
            this.preyAvoidanceEnabled = new System.Windows.Forms.CheckBox();
            this.preyBehaviourLabel = new System.Windows.Forms.Label();
            this.clientOptions = new System.Windows.Forms.TabPage();
            this.clientNetwork = new System.Windows.Forms.Panel();
            this.broadcastEnabled = new System.Windows.Forms.CheckBox();
            this.clientConnectPort = new System.Windows.Forms.TextBox();
            this.clientConnectIP = new System.Windows.Forms.TextBox();
            this.clientConnectPortLabel = new System.Windows.Forms.Label();
            this.clientConnectIPLabel = new System.Windows.Forms.Label();
            this.labelClientNetwork = new System.Windows.Forms.Label();
            this.clientPerf = new System.Windows.Forms.Panel();
            this.labelClientPhysIntSec = new System.Windows.Forms.Label();
            this.frameRateLockEnabled = new System.Windows.Forms.CheckBox();
            this.frameRateCapAmt = new System.Windows.Forms.NumericUpDown();
            this.clientPhysInt = new System.Windows.Forms.NumericUpDown();
            this.labelClientPhysInt = new System.Windows.Forms.Label();
            this.labelClientPerf = new System.Windows.Forms.Label();
            this.serverOptions = new System.Windows.Forms.TabPage();
            this.serverNetwork = new System.Windows.Forms.Panel();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.labelServerPort = new System.Windows.Forms.Label();
            this.labelServerNetwork = new System.Windows.Forms.Label();
            this.serverLimits = new System.Windows.Forms.Panel();
            this.labelServerPhysIntSec = new System.Windows.Forms.Label();
            this.serverPhysInt = new System.Windows.Forms.NumericUpDown();
            this.labelServerPhysInt = new System.Windows.Forms.Label();
            this.serverMaxClients = new System.Windows.Forms.NumericUpDown();
            this.labelServerMaxClients = new System.Windows.Forms.Label();
            this.maxAgentsPerC = new System.Windows.Forms.NumericUpDown();
            this.labelMaxAgentsPerC = new System.Windows.Forms.Label();
            this.labelServerLimits = new System.Windows.Forms.Label();
            this.startLocal = new System.Windows.Forms.Button();
            this.startNetworkClient = new System.Windows.Forms.Button();
            this.startNetworkServer = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exportButton = new System.Windows.Forms.Button();
            this.optionTabs.SuspendLayout();
            this.agentOptions.SuspendLayout();
            this.predOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predMaxSpawnRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMinSpawnRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMaxMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMinMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMinSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMaxVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMinVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMaxAccel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMinAccel)).BeginInit();
            this.preyOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxSpawnRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMinSpawnRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMinMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMinSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxStartVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMinStartVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxAccel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMinAccel)).BeginInit();
            this.generalAgentOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalAgents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentRatio)).BeginInit();
            this.agentBehaviours.SuspendLayout();
            this.predBehaviour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMaxInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMinInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMaxAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMinAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMaxRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMinRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMaxInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMinInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMaxAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMinAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMaxRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMinRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMaxInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMinInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMaxAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMinAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMaxRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMinRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMaxInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMinInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMaxAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMinAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMaxRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMinRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMaxInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMinInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMaxAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMinAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMaxRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMinRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMaxInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMinInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMaxAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMinAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMaxRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMinRad)).BeginInit();
            this.preyBehaviour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMaxInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMinInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMaxAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMinAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMaxRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMinRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMaxInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMinInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMaxAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMinAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMaxRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMinRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMaxInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMinInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMaxAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMinAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMaxRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMinRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMaxInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMinInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMaxAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMinAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMaxRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMinRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMaxInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMinInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMaxAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMinAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMaxRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMinRad)).BeginInit();
            this.clientOptions.SuspendLayout();
            this.clientNetwork.SuspendLayout();
            this.clientPerf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameRateCapAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPhysInt)).BeginInit();
            this.serverOptions.SuspendLayout();
            this.serverNetwork.SuspendLayout();
            this.serverLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverPhysInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverMaxClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAgentsPerC)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(76, 24);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.toolTip.SetToolTip(this.saveButton, "Save current settings to simulation");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(94, 12);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(76, 24);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import...";
            this.toolTip.SetToolTip(this.importButton, "Import an existing config file");
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // optionTabs
            // 
            this.optionTabs.Controls.Add(this.agentOptions);
            this.optionTabs.Controls.Add(this.agentBehaviours);
            this.optionTabs.Controls.Add(this.clientOptions);
            this.optionTabs.Controls.Add(this.serverOptions);
            this.optionTabs.Location = new System.Drawing.Point(12, 70);
            this.optionTabs.Name = "optionTabs";
            this.optionTabs.SelectedIndex = 0;
            this.optionTabs.Size = new System.Drawing.Size(759, 569);
            this.optionTabs.TabIndex = 2;
            // 
            // agentOptions
            // 
            this.agentOptions.AutoScroll = true;
            this.agentOptions.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.agentOptions.Controls.Add(this.predOptions);
            this.agentOptions.Controls.Add(this.predOptionsLabel);
            this.agentOptions.Controls.Add(this.preyOptions);
            this.agentOptions.Controls.Add(this.preyOptionsLabel);
            this.agentOptions.Controls.Add(this.generalAgentOptions);
            this.agentOptions.Controls.Add(this.generalAgentOptionsLabel);
            this.agentOptions.Location = new System.Drawing.Point(4, 22);
            this.agentOptions.Name = "agentOptions";
            this.agentOptions.Padding = new System.Windows.Forms.Padding(5);
            this.agentOptions.Size = new System.Drawing.Size(751, 543);
            this.agentOptions.TabIndex = 1;
            this.agentOptions.Text = "Agent Options";
            this.agentOptions.UseVisualStyleBackColor = true;
            // 
            // predOptions
            // 
            this.predOptions.BackColor = System.Drawing.Color.Transparent;
            this.predOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.predOptions.Controls.Add(this.labelPredSpawnRad);
            this.predOptions.Controls.Add(this.predMaxSpawnRad);
            this.predOptions.Controls.Add(this.predMinSpawnRad);
            this.predOptions.Controls.Add(this.labelPredMass);
            this.predOptions.Controls.Add(this.labelPredSize);
            this.predOptions.Controls.Add(this.labelPredStartVel);
            this.predOptions.Controls.Add(this.labelPredAccel);
            this.predOptions.Controls.Add(this.predMaxMass);
            this.predOptions.Controls.Add(this.predMinMass);
            this.predOptions.Controls.Add(this.predMaxSize);
            this.predOptions.Controls.Add(this.predMinSize);
            this.predOptions.Controls.Add(this.predMaxVel);
            this.predOptions.Controls.Add(this.predMinVel);
            this.predOptions.Controls.Add(this.labelPredOptMax);
            this.predOptions.Controls.Add(this.predMaxAccel);
            this.predOptions.Controls.Add(this.labelPredOptMin);
            this.predOptions.Controls.Add(this.predMinAccel);
            this.predOptions.Location = new System.Drawing.Point(18, 408);
            this.predOptions.Name = "predOptions";
            this.predOptions.Size = new System.Drawing.Size(685, 214);
            this.predOptions.TabIndex = 55;
            // 
            // labelPredSpawnRad
            // 
            this.labelPredSpawnRad.AutoSize = true;
            this.labelPredSpawnRad.Location = new System.Drawing.Point(10, 32);
            this.labelPredSpawnRad.Name = "labelPredSpawnRad";
            this.labelPredSpawnRad.Size = new System.Drawing.Size(76, 13);
            this.labelPredSpawnRad.TabIndex = 53;
            this.labelPredSpawnRad.Text = "Spawn Radius";
            // 
            // predMaxSpawnRad
            // 
            this.predMaxSpawnRad.BackColor = System.Drawing.SystemColors.Window;
            this.predMaxSpawnRad.DecimalPlaces = 2;
            this.predMaxSpawnRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predMaxSpawnRad.Location = new System.Drawing.Point(190, 30);
            this.predMaxSpawnRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predMaxSpawnRad.Name = "predMaxSpawnRad";
            this.predMaxSpawnRad.Size = new System.Drawing.Size(78, 20);
            this.predMaxSpawnRad.TabIndex = 52;
            this.predMaxSpawnRad.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // predMinSpawnRad
            // 
            this.predMinSpawnRad.BackColor = System.Drawing.SystemColors.Window;
            this.predMinSpawnRad.DecimalPlaces = 2;
            this.predMinSpawnRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predMinSpawnRad.Location = new System.Drawing.Point(90, 30);
            this.predMinSpawnRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predMinSpawnRad.Name = "predMinSpawnRad";
            this.predMinSpawnRad.Size = new System.Drawing.Size(78, 20);
            this.predMinSpawnRad.TabIndex = 51;
            // 
            // labelPredMass
            // 
            this.labelPredMass.AutoSize = true;
            this.labelPredMass.Location = new System.Drawing.Point(10, 172);
            this.labelPredMass.Name = "labelPredMass";
            this.labelPredMass.Size = new System.Drawing.Size(32, 13);
            this.labelPredMass.TabIndex = 45;
            this.labelPredMass.Text = "Mass";
            // 
            // labelPredSize
            // 
            this.labelPredSize.AutoSize = true;
            this.labelPredSize.Location = new System.Drawing.Point(10, 137);
            this.labelPredSize.Name = "labelPredSize";
            this.labelPredSize.Size = new System.Drawing.Size(27, 13);
            this.labelPredSize.TabIndex = 44;
            this.labelPredSize.Text = "Size";
            // 
            // labelPredStartVel
            // 
            this.labelPredStartVel.AutoSize = true;
            this.labelPredStartVel.Location = new System.Drawing.Point(10, 102);
            this.labelPredStartVel.Name = "labelPredStartVel";
            this.labelPredStartVel.Size = new System.Drawing.Size(69, 13);
            this.labelPredStartVel.TabIndex = 43;
            this.labelPredStartVel.Text = "Start Velocity";
            // 
            // labelPredAccel
            // 
            this.labelPredAccel.AutoSize = true;
            this.labelPredAccel.Location = new System.Drawing.Point(10, 67);
            this.labelPredAccel.Name = "labelPredAccel";
            this.labelPredAccel.Size = new System.Drawing.Size(66, 13);
            this.labelPredAccel.TabIndex = 42;
            this.labelPredAccel.Text = "Acceleration";
            // 
            // predMaxMass
            // 
            this.predMaxMass.BackColor = System.Drawing.SystemColors.Window;
            this.predMaxMass.DecimalPlaces = 2;
            this.predMaxMass.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predMaxMass.Location = new System.Drawing.Point(190, 170);
            this.predMaxMass.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predMaxMass.Name = "predMaxMass";
            this.predMaxMass.Size = new System.Drawing.Size(78, 20);
            this.predMaxMass.TabIndex = 34;
            this.predMaxMass.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // predMinMass
            // 
            this.predMinMass.BackColor = System.Drawing.SystemColors.Window;
            this.predMinMass.DecimalPlaces = 2;
            this.predMinMass.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predMinMass.Location = new System.Drawing.Point(90, 170);
            this.predMinMass.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predMinMass.Name = "predMinMass";
            this.predMinMass.Size = new System.Drawing.Size(78, 20);
            this.predMinMass.TabIndex = 33;
            this.predMinMass.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // predMaxSize
            // 
            this.predMaxSize.BackColor = System.Drawing.SystemColors.Window;
            this.predMaxSize.DecimalPlaces = 2;
            this.predMaxSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predMaxSize.Location = new System.Drawing.Point(190, 135);
            this.predMaxSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predMaxSize.Name = "predMaxSize";
            this.predMaxSize.Size = new System.Drawing.Size(78, 20);
            this.predMaxSize.TabIndex = 27;
            this.predMaxSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // predMinSize
            // 
            this.predMinSize.BackColor = System.Drawing.SystemColors.Window;
            this.predMinSize.DecimalPlaces = 2;
            this.predMinSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predMinSize.Location = new System.Drawing.Point(90, 135);
            this.predMinSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predMinSize.Name = "predMinSize";
            this.predMinSize.Size = new System.Drawing.Size(78, 20);
            this.predMinSize.TabIndex = 26;
            this.predMinSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // predMaxVel
            // 
            this.predMaxVel.BackColor = System.Drawing.SystemColors.Window;
            this.predMaxVel.DecimalPlaces = 2;
            this.predMaxVel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predMaxVel.Location = new System.Drawing.Point(190, 100);
            this.predMaxVel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predMaxVel.Name = "predMaxVel";
            this.predMaxVel.Size = new System.Drawing.Size(78, 20);
            this.predMaxVel.TabIndex = 20;
            this.predMaxVel.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // predMinVel
            // 
            this.predMinVel.BackColor = System.Drawing.SystemColors.Window;
            this.predMinVel.DecimalPlaces = 2;
            this.predMinVel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predMinVel.Location = new System.Drawing.Point(90, 100);
            this.predMinVel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predMinVel.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.predMinVel.Name = "predMinVel";
            this.predMinVel.Size = new System.Drawing.Size(78, 20);
            this.predMinVel.TabIndex = 19;
            this.predMinVel.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            // 
            // labelPredOptMax
            // 
            this.labelPredOptMax.AutoSize = true;
            this.labelPredOptMax.Location = new System.Drawing.Point(212, 8);
            this.labelPredOptMax.Name = "labelPredOptMax";
            this.labelPredOptMax.Size = new System.Drawing.Size(27, 13);
            this.labelPredOptMax.TabIndex = 8;
            this.labelPredOptMax.Text = "Max";
            this.labelPredOptMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // predMaxAccel
            // 
            this.predMaxAccel.BackColor = System.Drawing.SystemColors.Window;
            this.predMaxAccel.DecimalPlaces = 2;
            this.predMaxAccel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predMaxAccel.Location = new System.Drawing.Point(190, 65);
            this.predMaxAccel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predMaxAccel.Name = "predMaxAccel";
            this.predMaxAccel.Size = new System.Drawing.Size(78, 20);
            this.predMaxAccel.TabIndex = 9;
            this.predMaxAccel.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelPredOptMin
            // 
            this.labelPredOptMin.AutoSize = true;
            this.labelPredOptMin.Location = new System.Drawing.Point(115, 8);
            this.labelPredOptMin.Name = "labelPredOptMin";
            this.labelPredOptMin.Size = new System.Drawing.Size(24, 13);
            this.labelPredOptMin.TabIndex = 7;
            this.labelPredOptMin.Text = "Min";
            this.labelPredOptMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // predMinAccel
            // 
            this.predMinAccel.BackColor = System.Drawing.SystemColors.Window;
            this.predMinAccel.DecimalPlaces = 2;
            this.predMinAccel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predMinAccel.Location = new System.Drawing.Point(90, 65);
            this.predMinAccel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predMinAccel.Name = "predMinAccel";
            this.predMinAccel.Size = new System.Drawing.Size(78, 20);
            this.predMinAccel.TabIndex = 7;
            this.predMinAccel.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // predOptionsLabel
            // 
            this.predOptionsLabel.AutoSize = true;
            this.predOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predOptionsLabel.Location = new System.Drawing.Point(17, 391);
            this.predOptionsLabel.Name = "predOptionsLabel";
            this.predOptionsLabel.Size = new System.Drawing.Size(52, 13);
            this.predOptionsLabel.TabIndex = 12;
            this.predOptionsLabel.Text = "Predators";
            // 
            // preyOptions
            // 
            this.preyOptions.BackColor = System.Drawing.Color.Transparent;
            this.preyOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.preyOptions.Controls.Add(this.labelPreySpawnRad);
            this.preyOptions.Controls.Add(this.preyMaxSpawnRad);
            this.preyOptions.Controls.Add(this.preyMinSpawnRad);
            this.preyOptions.Controls.Add(this.labelPreyMass);
            this.preyOptions.Controls.Add(this.labelPreySize);
            this.preyOptions.Controls.Add(this.labelPreyStartVel);
            this.preyOptions.Controls.Add(this.labelPreyAccel);
            this.preyOptions.Controls.Add(this.preyMaxMass);
            this.preyOptions.Controls.Add(this.preyMinMass);
            this.preyOptions.Controls.Add(this.preyMaxSize);
            this.preyOptions.Controls.Add(this.preyMinSize);
            this.preyOptions.Controls.Add(this.preyMaxStartVel);
            this.preyOptions.Controls.Add(this.preyMinStartVel);
            this.preyOptions.Controls.Add(this.labelPreyOptMax);
            this.preyOptions.Controls.Add(this.preyMaxAccel);
            this.preyOptions.Controls.Add(this.labelPreyOptMin);
            this.preyOptions.Controls.Add(this.preyMinAccel);
            this.preyOptions.Location = new System.Drawing.Point(18, 172);
            this.preyOptions.Name = "preyOptions";
            this.preyOptions.Size = new System.Drawing.Size(685, 214);
            this.preyOptions.TabIndex = 11;
            // 
            // labelPreySpawnRad
            // 
            this.labelPreySpawnRad.AutoSize = true;
            this.labelPreySpawnRad.Location = new System.Drawing.Point(10, 32);
            this.labelPreySpawnRad.Name = "labelPreySpawnRad";
            this.labelPreySpawnRad.Size = new System.Drawing.Size(76, 13);
            this.labelPreySpawnRad.TabIndex = 53;
            this.labelPreySpawnRad.Text = "Spawn Radius";
            // 
            // preyMaxSpawnRad
            // 
            this.preyMaxSpawnRad.BackColor = System.Drawing.SystemColors.Window;
            this.preyMaxSpawnRad.DecimalPlaces = 2;
            this.preyMaxSpawnRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyMaxSpawnRad.Location = new System.Drawing.Point(190, 30);
            this.preyMaxSpawnRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyMaxSpawnRad.Name = "preyMaxSpawnRad";
            this.preyMaxSpawnRad.Size = new System.Drawing.Size(78, 20);
            this.preyMaxSpawnRad.TabIndex = 52;
            this.preyMaxSpawnRad.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // preyMinSpawnRad
            // 
            this.preyMinSpawnRad.BackColor = System.Drawing.SystemColors.Window;
            this.preyMinSpawnRad.DecimalPlaces = 2;
            this.preyMinSpawnRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyMinSpawnRad.Location = new System.Drawing.Point(90, 30);
            this.preyMinSpawnRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyMinSpawnRad.Name = "preyMinSpawnRad";
            this.preyMinSpawnRad.Size = new System.Drawing.Size(78, 20);
            this.preyMinSpawnRad.TabIndex = 51;
            // 
            // labelPreyMass
            // 
            this.labelPreyMass.AutoSize = true;
            this.labelPreyMass.Location = new System.Drawing.Point(10, 172);
            this.labelPreyMass.Name = "labelPreyMass";
            this.labelPreyMass.Size = new System.Drawing.Size(32, 13);
            this.labelPreyMass.TabIndex = 45;
            this.labelPreyMass.Text = "Mass";
            // 
            // labelPreySize
            // 
            this.labelPreySize.AutoSize = true;
            this.labelPreySize.Location = new System.Drawing.Point(10, 137);
            this.labelPreySize.Name = "labelPreySize";
            this.labelPreySize.Size = new System.Drawing.Size(27, 13);
            this.labelPreySize.TabIndex = 44;
            this.labelPreySize.Text = "Size";
            // 
            // labelPreyStartVel
            // 
            this.labelPreyStartVel.AutoSize = true;
            this.labelPreyStartVel.Location = new System.Drawing.Point(10, 102);
            this.labelPreyStartVel.Name = "labelPreyStartVel";
            this.labelPreyStartVel.Size = new System.Drawing.Size(69, 13);
            this.labelPreyStartVel.TabIndex = 43;
            this.labelPreyStartVel.Text = "Start Velocity";
            // 
            // labelPreyAccel
            // 
            this.labelPreyAccel.AutoSize = true;
            this.labelPreyAccel.Location = new System.Drawing.Point(10, 67);
            this.labelPreyAccel.Name = "labelPreyAccel";
            this.labelPreyAccel.Size = new System.Drawing.Size(66, 13);
            this.labelPreyAccel.TabIndex = 42;
            this.labelPreyAccel.Text = "Acceleration";
            // 
            // preyMaxMass
            // 
            this.preyMaxMass.BackColor = System.Drawing.SystemColors.Window;
            this.preyMaxMass.DecimalPlaces = 2;
            this.preyMaxMass.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyMaxMass.Location = new System.Drawing.Point(190, 170);
            this.preyMaxMass.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyMaxMass.Name = "preyMaxMass";
            this.preyMaxMass.Size = new System.Drawing.Size(78, 20);
            this.preyMaxMass.TabIndex = 34;
            this.preyMaxMass.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // preyMinMass
            // 
            this.preyMinMass.BackColor = System.Drawing.SystemColors.Window;
            this.preyMinMass.DecimalPlaces = 2;
            this.preyMinMass.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyMinMass.Location = new System.Drawing.Point(90, 170);
            this.preyMinMass.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyMinMass.Name = "preyMinMass";
            this.preyMinMass.Size = new System.Drawing.Size(78, 20);
            this.preyMinMass.TabIndex = 33;
            this.preyMinMass.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // preyMaxSize
            // 
            this.preyMaxSize.BackColor = System.Drawing.SystemColors.Window;
            this.preyMaxSize.DecimalPlaces = 2;
            this.preyMaxSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyMaxSize.Location = new System.Drawing.Point(190, 135);
            this.preyMaxSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyMaxSize.Name = "preyMaxSize";
            this.preyMaxSize.Size = new System.Drawing.Size(78, 20);
            this.preyMaxSize.TabIndex = 27;
            this.preyMaxSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // preyMinSize
            // 
            this.preyMinSize.BackColor = System.Drawing.SystemColors.Window;
            this.preyMinSize.DecimalPlaces = 2;
            this.preyMinSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyMinSize.Location = new System.Drawing.Point(90, 135);
            this.preyMinSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyMinSize.Name = "preyMinSize";
            this.preyMinSize.Size = new System.Drawing.Size(78, 20);
            this.preyMinSize.TabIndex = 26;
            this.preyMinSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // preyMaxStartVel
            // 
            this.preyMaxStartVel.BackColor = System.Drawing.SystemColors.Window;
            this.preyMaxStartVel.DecimalPlaces = 2;
            this.preyMaxStartVel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyMaxStartVel.Location = new System.Drawing.Point(190, 100);
            this.preyMaxStartVel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyMaxStartVel.Name = "preyMaxStartVel";
            this.preyMaxStartVel.Size = new System.Drawing.Size(78, 20);
            this.preyMaxStartVel.TabIndex = 20;
            this.preyMaxStartVel.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // preyMinStartVel
            // 
            this.preyMinStartVel.BackColor = System.Drawing.SystemColors.Window;
            this.preyMinStartVel.DecimalPlaces = 2;
            this.preyMinStartVel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyMinStartVel.Location = new System.Drawing.Point(90, 100);
            this.preyMinStartVel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyMinStartVel.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.preyMinStartVel.Name = "preyMinStartVel";
            this.preyMinStartVel.Size = new System.Drawing.Size(78, 20);
            this.preyMinStartVel.TabIndex = 19;
            this.preyMinStartVel.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            // 
            // labelPreyOptMax
            // 
            this.labelPreyOptMax.AutoSize = true;
            this.labelPreyOptMax.Location = new System.Drawing.Point(212, 8);
            this.labelPreyOptMax.Name = "labelPreyOptMax";
            this.labelPreyOptMax.Size = new System.Drawing.Size(27, 13);
            this.labelPreyOptMax.TabIndex = 8;
            this.labelPreyOptMax.Text = "Max";
            this.labelPreyOptMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // preyMaxAccel
            // 
            this.preyMaxAccel.BackColor = System.Drawing.SystemColors.Window;
            this.preyMaxAccel.DecimalPlaces = 2;
            this.preyMaxAccel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyMaxAccel.Location = new System.Drawing.Point(190, 65);
            this.preyMaxAccel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyMaxAccel.Name = "preyMaxAccel";
            this.preyMaxAccel.Size = new System.Drawing.Size(78, 20);
            this.preyMaxAccel.TabIndex = 9;
            this.preyMaxAccel.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelPreyOptMin
            // 
            this.labelPreyOptMin.AutoSize = true;
            this.labelPreyOptMin.Location = new System.Drawing.Point(115, 8);
            this.labelPreyOptMin.Name = "labelPreyOptMin";
            this.labelPreyOptMin.Size = new System.Drawing.Size(24, 13);
            this.labelPreyOptMin.TabIndex = 7;
            this.labelPreyOptMin.Text = "Min";
            this.labelPreyOptMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // preyMinAccel
            // 
            this.preyMinAccel.BackColor = System.Drawing.SystemColors.Window;
            this.preyMinAccel.DecimalPlaces = 2;
            this.preyMinAccel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyMinAccel.Location = new System.Drawing.Point(90, 65);
            this.preyMinAccel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyMinAccel.Name = "preyMinAccel";
            this.preyMinAccel.Size = new System.Drawing.Size(78, 20);
            this.preyMinAccel.TabIndex = 7;
            this.preyMinAccel.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // preyOptionsLabel
            // 
            this.preyOptionsLabel.AutoSize = true;
            this.preyOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preyOptionsLabel.Location = new System.Drawing.Point(17, 155);
            this.preyOptionsLabel.Name = "preyOptionsLabel";
            this.preyOptionsLabel.Size = new System.Drawing.Size(28, 13);
            this.preyOptionsLabel.TabIndex = 7;
            this.preyOptionsLabel.Text = "Prey";
            // 
            // generalAgentOptions
            // 
            this.generalAgentOptions.BackColor = System.Drawing.Color.Transparent;
            this.generalAgentOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.generalAgentOptions.Controls.Add(this.rndSpawn);
            this.generalAgentOptions.Controls.Add(this.agentRatioValue);
            this.generalAgentOptions.Controls.Add(this.labelAgentRatio);
            this.generalAgentOptions.Controls.Add(this.totalAgents);
            this.generalAgentOptions.Controls.Add(this.labelTotalAgents);
            this.generalAgentOptions.Controls.Add(this.agentRatio);
            this.generalAgentOptions.Location = new System.Drawing.Point(18, 32);
            this.generalAgentOptions.Name = "generalAgentOptions";
            this.generalAgentOptions.Size = new System.Drawing.Size(685, 118);
            this.generalAgentOptions.TabIndex = 5;
            // 
            // rndSpawn
            // 
            this.rndSpawn.AutoSize = true;
            this.rndSpawn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rndSpawn.Location = new System.Drawing.Point(9, 80);
            this.rndSpawn.Name = "rndSpawn";
            this.rndSpawn.Size = new System.Drawing.Size(102, 17);
            this.rndSpawn.TabIndex = 6;
            this.rndSpawn.Text = "Random Spawn";
            this.toolTip.SetToolTip(this.rndSpawn, "Spawns Agents at a random position in the world.");
            this.rndSpawn.UseVisualStyleBackColor = true;
            this.rndSpawn.CheckedChanged += new System.EventHandler(this.checkBoxRndSpawn_CheckedChanged);
            // 
            // agentRatioValue
            // 
            this.agentRatioValue.AutoSize = true;
            this.agentRatioValue.Location = new System.Drawing.Point(213, 10);
            this.agentRatioValue.Name = "agentRatioValue";
            this.agentRatioValue.Size = new System.Drawing.Size(85, 13);
            this.agentRatioValue.TabIndex = 5;
            this.agentRatioValue.Text = "UNINITIALIZED";
            // 
            // labelAgentRatio
            // 
            this.labelAgentRatio.AutoSize = true;
            this.labelAgentRatio.Location = new System.Drawing.Point(10, 45);
            this.labelAgentRatio.Name = "labelAgentRatio";
            this.labelAgentRatio.Size = new System.Drawing.Size(63, 13);
            this.labelAgentRatio.TabIndex = 4;
            this.labelAgentRatio.Text = "Agent Ratio";
            this.toolTip.SetToolTip(this.labelAgentRatio, "Represents the ratio of predators and prey that the client will spawn.");
            // 
            // totalAgents
            // 
            this.totalAgents.BackColor = System.Drawing.SystemColors.Window;
            this.totalAgents.Location = new System.Drawing.Point(87, 8);
            this.totalAgents.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.totalAgents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.totalAgents.Name = "totalAgents";
            this.totalAgents.Size = new System.Drawing.Size(120, 20);
            this.totalAgents.TabIndex = 3;
            this.totalAgents.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.totalAgents, "Represents the amount of agents that the client will try to spawn. If running on " +
        "network mode, the limits specified by the server will override this setting. (Se" +
        "e Server Options)");
            this.totalAgents.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.totalAgents.ValueChanged += new System.EventHandler(this.totalAgents_ValueChanged);
            // 
            // labelTotalAgents
            // 
            this.labelTotalAgents.AutoSize = true;
            this.labelTotalAgents.Location = new System.Drawing.Point(10, 10);
            this.labelTotalAgents.Name = "labelTotalAgents";
            this.labelTotalAgents.Size = new System.Drawing.Size(67, 13);
            this.labelTotalAgents.TabIndex = 2;
            this.labelTotalAgents.Text = "Total Agents";
            this.toolTip.SetToolTip(this.labelTotalAgents, "Represents the amount of agents that the client will try to spawn. If running on " +
        "network mode, the limits specified by the server will override this setting. (Se" +
        "e Server Options)");
            // 
            // agentRatio
            // 
            this.agentRatio.AutoSize = false;
            this.agentRatio.BackColor = System.Drawing.SystemColors.Window;
            this.agentRatio.Location = new System.Drawing.Point(79, 43);
            this.agentRatio.Maximum = 100;
            this.agentRatio.Name = "agentRatio";
            this.agentRatio.Size = new System.Drawing.Size(600, 29);
            this.agentRatio.TabIndex = 1;
            this.toolTip.SetToolTip(this.agentRatio, "Represents the ratio of predators and prey that the client will spawn.");
            this.agentRatio.Value = 3;
            this.agentRatio.ValueChanged += new System.EventHandler(this.agentRatio_ValueChanged);
            // 
            // generalAgentOptionsLabel
            // 
            this.generalAgentOptionsLabel.AutoSize = true;
            this.generalAgentOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalAgentOptionsLabel.Location = new System.Drawing.Point(17, 15);
            this.generalAgentOptionsLabel.Name = "generalAgentOptionsLabel";
            this.generalAgentOptionsLabel.Size = new System.Drawing.Size(114, 13);
            this.generalAgentOptionsLabel.TabIndex = 4;
            this.generalAgentOptionsLabel.Text = "General Agent Options";
            // 
            // agentBehaviours
            // 
            this.agentBehaviours.Controls.Add(this.predBehaviour);
            this.agentBehaviours.Controls.Add(this.predBehaviourLabel);
            this.agentBehaviours.Controls.Add(this.preyBehaviour);
            this.agentBehaviours.Controls.Add(this.preyBehaviourLabel);
            this.agentBehaviours.Location = new System.Drawing.Point(4, 22);
            this.agentBehaviours.Name = "agentBehaviours";
            this.agentBehaviours.Size = new System.Drawing.Size(751, 543);
            this.agentBehaviours.TabIndex = 3;
            this.agentBehaviours.Text = "Agent Behaviours";
            this.agentBehaviours.UseVisualStyleBackColor = true;
            // 
            // predBehaviour
            // 
            this.predBehaviour.BackColor = System.Drawing.Color.Transparent;
            this.predBehaviour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.predBehaviour.Controls.Add(this.predChaseMaxInf);
            this.predBehaviour.Controls.Add(this.predChaseMinInf);
            this.predBehaviour.Controls.Add(this.predChaseMaxAng);
            this.predBehaviour.Controls.Add(this.predChaseMinAng);
            this.predBehaviour.Controls.Add(this.predChaseMaxRad);
            this.predBehaviour.Controls.Add(this.predChaseMinRad);
            this.predBehaviour.Controls.Add(this.predChaseEnabled);
            this.predBehaviour.Controls.Add(this.predFleeMaxInf);
            this.predBehaviour.Controls.Add(this.predFleeMinInf);
            this.predBehaviour.Controls.Add(this.predFleeMaxAng);
            this.predBehaviour.Controls.Add(this.predFleeMinAng);
            this.predBehaviour.Controls.Add(this.predFleeMaxRad);
            this.predBehaviour.Controls.Add(this.predFleeMinRad);
            this.predBehaviour.Controls.Add(this.predFleeEnabled);
            this.predBehaviour.Controls.Add(this.predSpeedMaxInf);
            this.predBehaviour.Controls.Add(this.predSpeedMinInf);
            this.predBehaviour.Controls.Add(this.predSpeedMaxAng);
            this.predBehaviour.Controls.Add(this.predSpeedMinAng);
            this.predBehaviour.Controls.Add(this.predSpeedMaxRad);
            this.predBehaviour.Controls.Add(this.predSpeedMinRad);
            this.predBehaviour.Controls.Add(this.predSpeedEnabled);
            this.predBehaviour.Controls.Add(this.predHeadingMaxInf);
            this.predBehaviour.Controls.Add(this.predHeadingMinInf);
            this.predBehaviour.Controls.Add(this.predHeadingMaxAng);
            this.predBehaviour.Controls.Add(this.predHeadingMinAng);
            this.predBehaviour.Controls.Add(this.predHeadingMaxRad);
            this.predBehaviour.Controls.Add(this.predHeadingMinRad);
            this.predBehaviour.Controls.Add(this.predHeadingEnabled);
            this.predBehaviour.Controls.Add(this.predGroupingMaxInf);
            this.predBehaviour.Controls.Add(this.predGroupingMinInf);
            this.predBehaviour.Controls.Add(this.predGroupingMaxAng);
            this.predBehaviour.Controls.Add(this.predGroupingMinAng);
            this.predBehaviour.Controls.Add(this.predGroupingMaxRad);
            this.predBehaviour.Controls.Add(this.predGroupingMinRad);
            this.predBehaviour.Controls.Add(this.predGroupingEnabled);
            this.predBehaviour.Controls.Add(this.labelPredMaxInf);
            this.predBehaviour.Controls.Add(this.predAvoidanceMaxInf);
            this.predBehaviour.Controls.Add(this.labelPredMinInf);
            this.predBehaviour.Controls.Add(this.predAvoidanceMinInf);
            this.predBehaviour.Controls.Add(this.labelPredMaxAng);
            this.predBehaviour.Controls.Add(this.predAvoidanceMaxAng);
            this.predBehaviour.Controls.Add(this.labelPredMinAng);
            this.predBehaviour.Controls.Add(this.predAvoidanceMinAng);
            this.predBehaviour.Controls.Add(this.labelPredMaxRad);
            this.predBehaviour.Controls.Add(this.predAvoidanceMaxRad);
            this.predBehaviour.Controls.Add(this.labelPredMinRad);
            this.predBehaviour.Controls.Add(this.predAvoidanceMinRad);
            this.predBehaviour.Controls.Add(this.predAvoidanceEnabled);
            this.predBehaviour.Location = new System.Drawing.Point(18, 261);
            this.predBehaviour.Name = "predBehaviour";
            this.predBehaviour.Size = new System.Drawing.Size(718, 243);
            this.predBehaviour.TabIndex = 11;
            // 
            // predChaseMaxInf
            // 
            this.predChaseMaxInf.BackColor = System.Drawing.SystemColors.Window;
            this.predChaseMaxInf.DecimalPlaces = 2;
            this.predChaseMaxInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predChaseMaxInf.Location = new System.Drawing.Point(618, 203);
            this.predChaseMaxInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predChaseMaxInf.Name = "predChaseMaxInf";
            this.predChaseMaxInf.Size = new System.Drawing.Size(78, 20);
            this.predChaseMaxInf.TabIndex = 52;
            this.predChaseMaxInf.ThousandsSeparator = true;
            this.predChaseMaxInf.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // predChaseMinInf
            // 
            this.predChaseMinInf.BackColor = System.Drawing.SystemColors.Window;
            this.predChaseMinInf.DecimalPlaces = 2;
            this.predChaseMinInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predChaseMinInf.Location = new System.Drawing.Point(518, 203);
            this.predChaseMinInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predChaseMinInf.Name = "predChaseMinInf";
            this.predChaseMinInf.Size = new System.Drawing.Size(78, 20);
            this.predChaseMinInf.TabIndex = 51;
            this.predChaseMinInf.ThousandsSeparator = true;
            this.predChaseMinInf.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // predChaseMaxAng
            // 
            this.predChaseMaxAng.BackColor = System.Drawing.SystemColors.Window;
            this.predChaseMaxAng.DecimalPlaces = 2;
            this.predChaseMaxAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predChaseMaxAng.Location = new System.Drawing.Point(418, 203);
            this.predChaseMaxAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predChaseMaxAng.Name = "predChaseMaxAng";
            this.predChaseMaxAng.Size = new System.Drawing.Size(78, 20);
            this.predChaseMaxAng.TabIndex = 50;
            this.predChaseMaxAng.ThousandsSeparator = true;
            this.predChaseMaxAng.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // predChaseMinAng
            // 
            this.predChaseMinAng.BackColor = System.Drawing.SystemColors.Window;
            this.predChaseMinAng.DecimalPlaces = 2;
            this.predChaseMinAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predChaseMinAng.Location = new System.Drawing.Point(318, 203);
            this.predChaseMinAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predChaseMinAng.Name = "predChaseMinAng";
            this.predChaseMinAng.Size = new System.Drawing.Size(78, 20);
            this.predChaseMinAng.TabIndex = 49;
            this.predChaseMinAng.ThousandsSeparator = true;
            this.predChaseMinAng.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // predChaseMaxRad
            // 
            this.predChaseMaxRad.BackColor = System.Drawing.SystemColors.Window;
            this.predChaseMaxRad.DecimalPlaces = 2;
            this.predChaseMaxRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predChaseMaxRad.Location = new System.Drawing.Point(218, 203);
            this.predChaseMaxRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predChaseMaxRad.Name = "predChaseMaxRad";
            this.predChaseMaxRad.Size = new System.Drawing.Size(78, 20);
            this.predChaseMaxRad.TabIndex = 48;
            this.predChaseMaxRad.ThousandsSeparator = true;
            this.predChaseMaxRad.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // predChaseMinRad
            // 
            this.predChaseMinRad.BackColor = System.Drawing.SystemColors.Window;
            this.predChaseMinRad.DecimalPlaces = 2;
            this.predChaseMinRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predChaseMinRad.Location = new System.Drawing.Point(118, 203);
            this.predChaseMinRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predChaseMinRad.Name = "predChaseMinRad";
            this.predChaseMinRad.Size = new System.Drawing.Size(78, 20);
            this.predChaseMinRad.TabIndex = 47;
            this.predChaseMinRad.ThousandsSeparator = true;
            this.predChaseMinRad.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // predChaseEnabled
            // 
            this.predChaseEnabled.AutoSize = true;
            this.predChaseEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.predChaseEnabled.Checked = true;
            this.predChaseEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.predChaseEnabled.Location = new System.Drawing.Point(30, 205);
            this.predChaseEnabled.Name = "predChaseEnabled";
            this.predChaseEnabled.Size = new System.Drawing.Size(56, 17);
            this.predChaseEnabled.TabIndex = 46;
            this.predChaseEnabled.Text = "Chase";
            this.predChaseEnabled.UseVisualStyleBackColor = true;
            this.predChaseEnabled.CheckedChanged += new System.EventHandler(this.predChaseEnabled_CheckedChanged);
            // 
            // predFleeMaxInf
            // 
            this.predFleeMaxInf.BackColor = System.Drawing.SystemColors.Window;
            this.predFleeMaxInf.DecimalPlaces = 2;
            this.predFleeMaxInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predFleeMaxInf.Location = new System.Drawing.Point(618, 168);
            this.predFleeMaxInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predFleeMaxInf.Name = "predFleeMaxInf";
            this.predFleeMaxInf.Size = new System.Drawing.Size(78, 20);
            this.predFleeMaxInf.TabIndex = 45;
            this.predFleeMaxInf.ThousandsSeparator = true;
            this.predFleeMaxInf.Value = new decimal(new int[] {
            220,
            0,
            0,
            0});
            // 
            // predFleeMinInf
            // 
            this.predFleeMinInf.BackColor = System.Drawing.SystemColors.Window;
            this.predFleeMinInf.DecimalPlaces = 2;
            this.predFleeMinInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predFleeMinInf.Location = new System.Drawing.Point(518, 168);
            this.predFleeMinInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predFleeMinInf.Name = "predFleeMinInf";
            this.predFleeMinInf.Size = new System.Drawing.Size(78, 20);
            this.predFleeMinInf.TabIndex = 44;
            this.predFleeMinInf.ThousandsSeparator = true;
            this.predFleeMinInf.Value = new decimal(new int[] {
            220,
            0,
            0,
            0});
            // 
            // predFleeMaxAng
            // 
            this.predFleeMaxAng.BackColor = System.Drawing.SystemColors.Window;
            this.predFleeMaxAng.DecimalPlaces = 2;
            this.predFleeMaxAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predFleeMaxAng.Location = new System.Drawing.Point(418, 168);
            this.predFleeMaxAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predFleeMaxAng.Name = "predFleeMaxAng";
            this.predFleeMaxAng.Size = new System.Drawing.Size(78, 20);
            this.predFleeMaxAng.TabIndex = 43;
            this.predFleeMaxAng.ThousandsSeparator = true;
            this.predFleeMaxAng.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // predFleeMinAng
            // 
            this.predFleeMinAng.BackColor = System.Drawing.SystemColors.Window;
            this.predFleeMinAng.DecimalPlaces = 2;
            this.predFleeMinAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predFleeMinAng.Location = new System.Drawing.Point(318, 168);
            this.predFleeMinAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predFleeMinAng.Name = "predFleeMinAng";
            this.predFleeMinAng.Size = new System.Drawing.Size(78, 20);
            this.predFleeMinAng.TabIndex = 42;
            this.predFleeMinAng.ThousandsSeparator = true;
            this.predFleeMinAng.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // predFleeMaxRad
            // 
            this.predFleeMaxRad.BackColor = System.Drawing.SystemColors.Window;
            this.predFleeMaxRad.DecimalPlaces = 2;
            this.predFleeMaxRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predFleeMaxRad.Location = new System.Drawing.Point(218, 168);
            this.predFleeMaxRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predFleeMaxRad.Name = "predFleeMaxRad";
            this.predFleeMaxRad.Size = new System.Drawing.Size(78, 20);
            this.predFleeMaxRad.TabIndex = 41;
            this.predFleeMaxRad.ThousandsSeparator = true;
            this.predFleeMaxRad.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // predFleeMinRad
            // 
            this.predFleeMinRad.BackColor = System.Drawing.SystemColors.Window;
            this.predFleeMinRad.DecimalPlaces = 2;
            this.predFleeMinRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predFleeMinRad.Location = new System.Drawing.Point(118, 168);
            this.predFleeMinRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predFleeMinRad.Name = "predFleeMinRad";
            this.predFleeMinRad.Size = new System.Drawing.Size(78, 20);
            this.predFleeMinRad.TabIndex = 40;
            this.predFleeMinRad.ThousandsSeparator = true;
            this.predFleeMinRad.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // predFleeEnabled
            // 
            this.predFleeEnabled.AutoSize = true;
            this.predFleeEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.predFleeEnabled.Checked = true;
            this.predFleeEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.predFleeEnabled.Location = new System.Drawing.Point(40, 170);
            this.predFleeEnabled.Name = "predFleeEnabled";
            this.predFleeEnabled.Size = new System.Drawing.Size(46, 17);
            this.predFleeEnabled.TabIndex = 39;
            this.predFleeEnabled.Text = "Flee";
            this.predFleeEnabled.UseVisualStyleBackColor = true;
            this.predFleeEnabled.CheckedChanged += new System.EventHandler(this.predFleeEnabled_CheckedChanged);
            // 
            // predSpeedMaxInf
            // 
            this.predSpeedMaxInf.BackColor = System.Drawing.SystemColors.Window;
            this.predSpeedMaxInf.DecimalPlaces = 2;
            this.predSpeedMaxInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predSpeedMaxInf.Location = new System.Drawing.Point(618, 133);
            this.predSpeedMaxInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predSpeedMaxInf.Name = "predSpeedMaxInf";
            this.predSpeedMaxInf.Size = new System.Drawing.Size(78, 20);
            this.predSpeedMaxInf.TabIndex = 38;
            this.predSpeedMaxInf.ThousandsSeparator = true;
            this.predSpeedMaxInf.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // predSpeedMinInf
            // 
            this.predSpeedMinInf.BackColor = System.Drawing.SystemColors.Window;
            this.predSpeedMinInf.DecimalPlaces = 2;
            this.predSpeedMinInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predSpeedMinInf.Location = new System.Drawing.Point(518, 133);
            this.predSpeedMinInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predSpeedMinInf.Name = "predSpeedMinInf";
            this.predSpeedMinInf.Size = new System.Drawing.Size(78, 20);
            this.predSpeedMinInf.TabIndex = 37;
            this.predSpeedMinInf.ThousandsSeparator = true;
            this.predSpeedMinInf.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // predSpeedMaxAng
            // 
            this.predSpeedMaxAng.BackColor = System.Drawing.SystemColors.Window;
            this.predSpeedMaxAng.DecimalPlaces = 2;
            this.predSpeedMaxAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predSpeedMaxAng.Location = new System.Drawing.Point(418, 133);
            this.predSpeedMaxAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predSpeedMaxAng.Name = "predSpeedMaxAng";
            this.predSpeedMaxAng.Size = new System.Drawing.Size(78, 20);
            this.predSpeedMaxAng.TabIndex = 36;
            this.predSpeedMaxAng.ThousandsSeparator = true;
            this.predSpeedMaxAng.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // predSpeedMinAng
            // 
            this.predSpeedMinAng.BackColor = System.Drawing.SystemColors.Window;
            this.predSpeedMinAng.DecimalPlaces = 2;
            this.predSpeedMinAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predSpeedMinAng.Location = new System.Drawing.Point(318, 133);
            this.predSpeedMinAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predSpeedMinAng.Name = "predSpeedMinAng";
            this.predSpeedMinAng.Size = new System.Drawing.Size(78, 20);
            this.predSpeedMinAng.TabIndex = 35;
            this.predSpeedMinAng.ThousandsSeparator = true;
            this.predSpeedMinAng.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // predSpeedMaxRad
            // 
            this.predSpeedMaxRad.BackColor = System.Drawing.SystemColors.Window;
            this.predSpeedMaxRad.DecimalPlaces = 2;
            this.predSpeedMaxRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predSpeedMaxRad.Location = new System.Drawing.Point(218, 133);
            this.predSpeedMaxRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predSpeedMaxRad.Name = "predSpeedMaxRad";
            this.predSpeedMaxRad.Size = new System.Drawing.Size(78, 20);
            this.predSpeedMaxRad.TabIndex = 34;
            this.predSpeedMaxRad.ThousandsSeparator = true;
            this.predSpeedMaxRad.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // predSpeedMinRad
            // 
            this.predSpeedMinRad.BackColor = System.Drawing.SystemColors.Window;
            this.predSpeedMinRad.DecimalPlaces = 2;
            this.predSpeedMinRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predSpeedMinRad.Location = new System.Drawing.Point(118, 133);
            this.predSpeedMinRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predSpeedMinRad.Name = "predSpeedMinRad";
            this.predSpeedMinRad.Size = new System.Drawing.Size(78, 20);
            this.predSpeedMinRad.TabIndex = 33;
            this.predSpeedMinRad.ThousandsSeparator = true;
            this.predSpeedMinRad.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // predSpeedEnabled
            // 
            this.predSpeedEnabled.AutoSize = true;
            this.predSpeedEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.predSpeedEnabled.Checked = true;
            this.predSpeedEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.predSpeedEnabled.Location = new System.Drawing.Point(29, 135);
            this.predSpeedEnabled.Name = "predSpeedEnabled";
            this.predSpeedEnabled.Size = new System.Drawing.Size(57, 17);
            this.predSpeedEnabled.TabIndex = 32;
            this.predSpeedEnabled.Text = "Speed";
            this.predSpeedEnabled.UseVisualStyleBackColor = true;
            this.predSpeedEnabled.CheckedChanged += new System.EventHandler(this.predSpeedEnabled_CheckedChanged);
            // 
            // predHeadingMaxInf
            // 
            this.predHeadingMaxInf.BackColor = System.Drawing.SystemColors.Window;
            this.predHeadingMaxInf.DecimalPlaces = 2;
            this.predHeadingMaxInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predHeadingMaxInf.Location = new System.Drawing.Point(618, 98);
            this.predHeadingMaxInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predHeadingMaxInf.Name = "predHeadingMaxInf";
            this.predHeadingMaxInf.Size = new System.Drawing.Size(78, 20);
            this.predHeadingMaxInf.TabIndex = 31;
            this.predHeadingMaxInf.ThousandsSeparator = true;
            this.predHeadingMaxInf.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // predHeadingMinInf
            // 
            this.predHeadingMinInf.BackColor = System.Drawing.SystemColors.Window;
            this.predHeadingMinInf.DecimalPlaces = 2;
            this.predHeadingMinInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predHeadingMinInf.Location = new System.Drawing.Point(518, 98);
            this.predHeadingMinInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predHeadingMinInf.Name = "predHeadingMinInf";
            this.predHeadingMinInf.Size = new System.Drawing.Size(78, 20);
            this.predHeadingMinInf.TabIndex = 30;
            this.predHeadingMinInf.ThousandsSeparator = true;
            this.predHeadingMinInf.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // predHeadingMaxAng
            // 
            this.predHeadingMaxAng.BackColor = System.Drawing.SystemColors.Window;
            this.predHeadingMaxAng.DecimalPlaces = 2;
            this.predHeadingMaxAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predHeadingMaxAng.Location = new System.Drawing.Point(418, 98);
            this.predHeadingMaxAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predHeadingMaxAng.Name = "predHeadingMaxAng";
            this.predHeadingMaxAng.Size = new System.Drawing.Size(78, 20);
            this.predHeadingMaxAng.TabIndex = 29;
            this.predHeadingMaxAng.ThousandsSeparator = true;
            this.predHeadingMaxAng.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // predHeadingMinAng
            // 
            this.predHeadingMinAng.BackColor = System.Drawing.SystemColors.Window;
            this.predHeadingMinAng.DecimalPlaces = 2;
            this.predHeadingMinAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predHeadingMinAng.Location = new System.Drawing.Point(318, 98);
            this.predHeadingMinAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predHeadingMinAng.Name = "predHeadingMinAng";
            this.predHeadingMinAng.Size = new System.Drawing.Size(78, 20);
            this.predHeadingMinAng.TabIndex = 28;
            this.predHeadingMinAng.ThousandsSeparator = true;
            this.predHeadingMinAng.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // predHeadingMaxRad
            // 
            this.predHeadingMaxRad.BackColor = System.Drawing.SystemColors.Window;
            this.predHeadingMaxRad.DecimalPlaces = 2;
            this.predHeadingMaxRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predHeadingMaxRad.Location = new System.Drawing.Point(218, 98);
            this.predHeadingMaxRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predHeadingMaxRad.Name = "predHeadingMaxRad";
            this.predHeadingMaxRad.Size = new System.Drawing.Size(78, 20);
            this.predHeadingMaxRad.TabIndex = 27;
            this.predHeadingMaxRad.ThousandsSeparator = true;
            this.predHeadingMaxRad.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // predHeadingMinRad
            // 
            this.predHeadingMinRad.BackColor = System.Drawing.SystemColors.Window;
            this.predHeadingMinRad.DecimalPlaces = 2;
            this.predHeadingMinRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predHeadingMinRad.Location = new System.Drawing.Point(118, 98);
            this.predHeadingMinRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predHeadingMinRad.Name = "predHeadingMinRad";
            this.predHeadingMinRad.Size = new System.Drawing.Size(78, 20);
            this.predHeadingMinRad.TabIndex = 26;
            this.predHeadingMinRad.ThousandsSeparator = true;
            this.predHeadingMinRad.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // predHeadingEnabled
            // 
            this.predHeadingEnabled.AutoSize = true;
            this.predHeadingEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.predHeadingEnabled.Checked = true;
            this.predHeadingEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.predHeadingEnabled.Location = new System.Drawing.Point(20, 100);
            this.predHeadingEnabled.Name = "predHeadingEnabled";
            this.predHeadingEnabled.Size = new System.Drawing.Size(66, 17);
            this.predHeadingEnabled.TabIndex = 25;
            this.predHeadingEnabled.Text = "Heading";
            this.predHeadingEnabled.UseVisualStyleBackColor = true;
            this.predHeadingEnabled.CheckedChanged += new System.EventHandler(this.predHeadingEnabled_CheckedChanged);
            // 
            // predGroupingMaxInf
            // 
            this.predGroupingMaxInf.BackColor = System.Drawing.SystemColors.Window;
            this.predGroupingMaxInf.DecimalPlaces = 2;
            this.predGroupingMaxInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predGroupingMaxInf.Location = new System.Drawing.Point(618, 63);
            this.predGroupingMaxInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predGroupingMaxInf.Name = "predGroupingMaxInf";
            this.predGroupingMaxInf.Size = new System.Drawing.Size(78, 20);
            this.predGroupingMaxInf.TabIndex = 24;
            this.predGroupingMaxInf.ThousandsSeparator = true;
            this.predGroupingMaxInf.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // predGroupingMinInf
            // 
            this.predGroupingMinInf.BackColor = System.Drawing.SystemColors.Window;
            this.predGroupingMinInf.DecimalPlaces = 2;
            this.predGroupingMinInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predGroupingMinInf.Location = new System.Drawing.Point(518, 63);
            this.predGroupingMinInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predGroupingMinInf.Name = "predGroupingMinInf";
            this.predGroupingMinInf.Size = new System.Drawing.Size(78, 20);
            this.predGroupingMinInf.TabIndex = 23;
            this.predGroupingMinInf.ThousandsSeparator = true;
            this.predGroupingMinInf.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // predGroupingMaxAng
            // 
            this.predGroupingMaxAng.BackColor = System.Drawing.SystemColors.Window;
            this.predGroupingMaxAng.DecimalPlaces = 2;
            this.predGroupingMaxAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predGroupingMaxAng.Location = new System.Drawing.Point(418, 63);
            this.predGroupingMaxAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predGroupingMaxAng.Name = "predGroupingMaxAng";
            this.predGroupingMaxAng.Size = new System.Drawing.Size(78, 20);
            this.predGroupingMaxAng.TabIndex = 22;
            this.predGroupingMaxAng.ThousandsSeparator = true;
            this.predGroupingMaxAng.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // predGroupingMinAng
            // 
            this.predGroupingMinAng.BackColor = System.Drawing.SystemColors.Window;
            this.predGroupingMinAng.DecimalPlaces = 2;
            this.predGroupingMinAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predGroupingMinAng.Location = new System.Drawing.Point(318, 63);
            this.predGroupingMinAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predGroupingMinAng.Name = "predGroupingMinAng";
            this.predGroupingMinAng.Size = new System.Drawing.Size(78, 20);
            this.predGroupingMinAng.TabIndex = 21;
            this.predGroupingMinAng.ThousandsSeparator = true;
            this.predGroupingMinAng.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // predGroupingMaxRad
            // 
            this.predGroupingMaxRad.BackColor = System.Drawing.SystemColors.Window;
            this.predGroupingMaxRad.DecimalPlaces = 2;
            this.predGroupingMaxRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predGroupingMaxRad.Location = new System.Drawing.Point(218, 63);
            this.predGroupingMaxRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predGroupingMaxRad.Name = "predGroupingMaxRad";
            this.predGroupingMaxRad.Size = new System.Drawing.Size(78, 20);
            this.predGroupingMaxRad.TabIndex = 20;
            this.predGroupingMaxRad.ThousandsSeparator = true;
            this.predGroupingMaxRad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // predGroupingMinRad
            // 
            this.predGroupingMinRad.BackColor = System.Drawing.SystemColors.Window;
            this.predGroupingMinRad.DecimalPlaces = 2;
            this.predGroupingMinRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predGroupingMinRad.Location = new System.Drawing.Point(118, 63);
            this.predGroupingMinRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predGroupingMinRad.Name = "predGroupingMinRad";
            this.predGroupingMinRad.Size = new System.Drawing.Size(78, 20);
            this.predGroupingMinRad.TabIndex = 19;
            this.predGroupingMinRad.ThousandsSeparator = true;
            this.predGroupingMinRad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // predGroupingEnabled
            // 
            this.predGroupingEnabled.AutoSize = true;
            this.predGroupingEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.predGroupingEnabled.Checked = true;
            this.predGroupingEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.predGroupingEnabled.Location = new System.Drawing.Point(17, 65);
            this.predGroupingEnabled.Name = "predGroupingEnabled";
            this.predGroupingEnabled.Size = new System.Drawing.Size(69, 17);
            this.predGroupingEnabled.TabIndex = 18;
            this.predGroupingEnabled.Text = "Grouping";
            this.predGroupingEnabled.UseVisualStyleBackColor = true;
            this.predGroupingEnabled.CheckedChanged += new System.EventHandler(this.predGroupingEnabled_CheckedChanged);
            // 
            // labelPredMaxInf
            // 
            this.labelPredMaxInf.AutoSize = true;
            this.labelPredMaxInf.Location = new System.Drawing.Point(620, 8);
            this.labelPredMaxInf.Name = "labelPredMaxInf";
            this.labelPredMaxInf.Size = new System.Drawing.Size(74, 13);
            this.labelPredMaxInf.TabIndex = 16;
            this.labelPredMaxInf.Text = "Max Influence";
            this.labelPredMaxInf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // predAvoidanceMaxInf
            // 
            this.predAvoidanceMaxInf.BackColor = System.Drawing.SystemColors.Window;
            this.predAvoidanceMaxInf.DecimalPlaces = 2;
            this.predAvoidanceMaxInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predAvoidanceMaxInf.Location = new System.Drawing.Point(618, 28);
            this.predAvoidanceMaxInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predAvoidanceMaxInf.Name = "predAvoidanceMaxInf";
            this.predAvoidanceMaxInf.Size = new System.Drawing.Size(78, 20);
            this.predAvoidanceMaxInf.TabIndex = 17;
            this.predAvoidanceMaxInf.ThousandsSeparator = true;
            this.predAvoidanceMaxInf.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // labelPredMinInf
            // 
            this.labelPredMinInf.AutoSize = true;
            this.labelPredMinInf.Location = new System.Drawing.Point(522, 8);
            this.labelPredMinInf.Name = "labelPredMinInf";
            this.labelPredMinInf.Size = new System.Drawing.Size(71, 13);
            this.labelPredMinInf.TabIndex = 14;
            this.labelPredMinInf.Text = "Min Influence";
            this.labelPredMinInf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // predAvoidanceMinInf
            // 
            this.predAvoidanceMinInf.BackColor = System.Drawing.SystemColors.Window;
            this.predAvoidanceMinInf.DecimalPlaces = 2;
            this.predAvoidanceMinInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predAvoidanceMinInf.Location = new System.Drawing.Point(518, 28);
            this.predAvoidanceMinInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predAvoidanceMinInf.Name = "predAvoidanceMinInf";
            this.predAvoidanceMinInf.Size = new System.Drawing.Size(78, 20);
            this.predAvoidanceMinInf.TabIndex = 15;
            this.predAvoidanceMinInf.ThousandsSeparator = true;
            this.predAvoidanceMinInf.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // labelPredMaxAng
            // 
            this.labelPredMaxAng.AutoSize = true;
            this.labelPredMaxAng.Location = new System.Drawing.Point(427, 8);
            this.labelPredMaxAng.Name = "labelPredMaxAng";
            this.labelPredMaxAng.Size = new System.Drawing.Size(57, 13);
            this.labelPredMaxAng.TabIndex = 12;
            this.labelPredMaxAng.Text = "Max Angle";
            this.labelPredMaxAng.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // predAvoidanceMaxAng
            // 
            this.predAvoidanceMaxAng.BackColor = System.Drawing.SystemColors.Window;
            this.predAvoidanceMaxAng.DecimalPlaces = 2;
            this.predAvoidanceMaxAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predAvoidanceMaxAng.Location = new System.Drawing.Point(418, 28);
            this.predAvoidanceMaxAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predAvoidanceMaxAng.Name = "predAvoidanceMaxAng";
            this.predAvoidanceMaxAng.Size = new System.Drawing.Size(78, 20);
            this.predAvoidanceMaxAng.TabIndex = 13;
            this.predAvoidanceMaxAng.ThousandsSeparator = true;
            this.predAvoidanceMaxAng.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // labelPredMinAng
            // 
            this.labelPredMinAng.AutoSize = true;
            this.labelPredMinAng.Location = new System.Drawing.Point(329, 8);
            this.labelPredMinAng.Name = "labelPredMinAng";
            this.labelPredMinAng.Size = new System.Drawing.Size(54, 13);
            this.labelPredMinAng.TabIndex = 10;
            this.labelPredMinAng.Text = "Min Angle";
            this.labelPredMinAng.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // predAvoidanceMinAng
            // 
            this.predAvoidanceMinAng.BackColor = System.Drawing.SystemColors.Window;
            this.predAvoidanceMinAng.DecimalPlaces = 2;
            this.predAvoidanceMinAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predAvoidanceMinAng.Location = new System.Drawing.Point(318, 28);
            this.predAvoidanceMinAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.predAvoidanceMinAng.Name = "predAvoidanceMinAng";
            this.predAvoidanceMinAng.Size = new System.Drawing.Size(78, 20);
            this.predAvoidanceMinAng.TabIndex = 11;
            this.predAvoidanceMinAng.ThousandsSeparator = true;
            this.predAvoidanceMinAng.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // labelPredMaxRad
            // 
            this.labelPredMaxRad.AutoSize = true;
            this.labelPredMaxRad.Location = new System.Drawing.Point(226, 8);
            this.labelPredMaxRad.Name = "labelPredMaxRad";
            this.labelPredMaxRad.Size = new System.Drawing.Size(63, 13);
            this.labelPredMaxRad.TabIndex = 8;
            this.labelPredMaxRad.Text = "Max Radius";
            this.labelPredMaxRad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // predAvoidanceMaxRad
            // 
            this.predAvoidanceMaxRad.BackColor = System.Drawing.SystemColors.Window;
            this.predAvoidanceMaxRad.DecimalPlaces = 2;
            this.predAvoidanceMaxRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predAvoidanceMaxRad.Location = new System.Drawing.Point(218, 28);
            this.predAvoidanceMaxRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predAvoidanceMaxRad.Name = "predAvoidanceMaxRad";
            this.predAvoidanceMaxRad.Size = new System.Drawing.Size(78, 20);
            this.predAvoidanceMaxRad.TabIndex = 9;
            this.predAvoidanceMaxRad.ThousandsSeparator = true;
            this.predAvoidanceMaxRad.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // labelPredMinRad
            // 
            this.labelPredMinRad.AutoSize = true;
            this.labelPredMinRad.Location = new System.Drawing.Point(127, 8);
            this.labelPredMinRad.Name = "labelPredMinRad";
            this.labelPredMinRad.Size = new System.Drawing.Size(60, 13);
            this.labelPredMinRad.TabIndex = 7;
            this.labelPredMinRad.Text = "Min Radius";
            this.labelPredMinRad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // predAvoidanceMinRad
            // 
            this.predAvoidanceMinRad.BackColor = System.Drawing.SystemColors.Window;
            this.predAvoidanceMinRad.DecimalPlaces = 2;
            this.predAvoidanceMinRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.predAvoidanceMinRad.Location = new System.Drawing.Point(118, 28);
            this.predAvoidanceMinRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.predAvoidanceMinRad.Name = "predAvoidanceMinRad";
            this.predAvoidanceMinRad.Size = new System.Drawing.Size(78, 20);
            this.predAvoidanceMinRad.TabIndex = 7;
            this.predAvoidanceMinRad.ThousandsSeparator = true;
            this.predAvoidanceMinRad.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // predAvoidanceEnabled
            // 
            this.predAvoidanceEnabled.AutoSize = true;
            this.predAvoidanceEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.predAvoidanceEnabled.Checked = true;
            this.predAvoidanceEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.predAvoidanceEnabled.Location = new System.Drawing.Point(9, 30);
            this.predAvoidanceEnabled.Name = "predAvoidanceEnabled";
            this.predAvoidanceEnabled.Size = new System.Drawing.Size(77, 17);
            this.predAvoidanceEnabled.TabIndex = 6;
            this.predAvoidanceEnabled.Text = "Avoidance";
            this.predAvoidanceEnabled.UseVisualStyleBackColor = true;
            this.predAvoidanceEnabled.CheckedChanged += new System.EventHandler(this.predAvoidanceEnabled_CheckedChanged);
            // 
            // predBehaviourLabel
            // 
            this.predBehaviourLabel.AutoSize = true;
            this.predBehaviourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predBehaviourLabel.Location = new System.Drawing.Point(15, 242);
            this.predBehaviourLabel.Name = "predBehaviourLabel";
            this.predBehaviourLabel.Size = new System.Drawing.Size(98, 13);
            this.predBehaviourLabel.TabIndex = 10;
            this.predBehaviourLabel.Text = "Predator Behaviour";
            // 
            // preyBehaviour
            // 
            this.preyBehaviour.BackColor = System.Drawing.Color.Transparent;
            this.preyBehaviour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.preyBehaviour.Controls.Add(this.preyFleeMaxInf);
            this.preyBehaviour.Controls.Add(this.preyFleeMinInf);
            this.preyBehaviour.Controls.Add(this.preyFleeMaxAng);
            this.preyBehaviour.Controls.Add(this.preyFleeMinAng);
            this.preyBehaviour.Controls.Add(this.preyFleeMaxRad);
            this.preyBehaviour.Controls.Add(this.preyFleeMinRad);
            this.preyBehaviour.Controls.Add(this.preyFleeEnabled);
            this.preyBehaviour.Controls.Add(this.preySpeedMaxInf);
            this.preyBehaviour.Controls.Add(this.preySpeedMinInf);
            this.preyBehaviour.Controls.Add(this.preySpeedMaxAng);
            this.preyBehaviour.Controls.Add(this.preySpeedMinAng);
            this.preyBehaviour.Controls.Add(this.preySpeedMaxRad);
            this.preyBehaviour.Controls.Add(this.preySpeedMinRad);
            this.preyBehaviour.Controls.Add(this.preySpeedEnabled);
            this.preyBehaviour.Controls.Add(this.preyHeadingMaxInf);
            this.preyBehaviour.Controls.Add(this.preyHeadingMinInf);
            this.preyBehaviour.Controls.Add(this.preyHeadingMaxAng);
            this.preyBehaviour.Controls.Add(this.preyHeadingMinAng);
            this.preyBehaviour.Controls.Add(this.preyHeadingMaxRad);
            this.preyBehaviour.Controls.Add(this.preyHeadingMinRad);
            this.preyBehaviour.Controls.Add(this.preyHeadingEnabled);
            this.preyBehaviour.Controls.Add(this.preyGroupingMaxInf);
            this.preyBehaviour.Controls.Add(this.preyGroupingMinInf);
            this.preyBehaviour.Controls.Add(this.preyGroupingMaxAng);
            this.preyBehaviour.Controls.Add(this.preyGroupingMinAng);
            this.preyBehaviour.Controls.Add(this.preyGroupingMaxRad);
            this.preyBehaviour.Controls.Add(this.preyGroupingMinRad);
            this.preyBehaviour.Controls.Add(this.preyGroupingEnabled);
            this.preyBehaviour.Controls.Add(this.labelPreyMaxInf);
            this.preyBehaviour.Controls.Add(this.preyAvoidanceMaxInf);
            this.preyBehaviour.Controls.Add(this.labelPreyMinInf);
            this.preyBehaviour.Controls.Add(this.preyAvoidanceMinInf);
            this.preyBehaviour.Controls.Add(this.labelPreyMaxAng);
            this.preyBehaviour.Controls.Add(this.preyAvoidanceMaxAng);
            this.preyBehaviour.Controls.Add(this.labelPreyMinAng);
            this.preyBehaviour.Controls.Add(this.preyAvoidanceMinAng);
            this.preyBehaviour.Controls.Add(this.labelPreyMaxRad);
            this.preyBehaviour.Controls.Add(this.preyAvoidanceMaxRad);
            this.preyBehaviour.Controls.Add(this.labelPreyMinRad);
            this.preyBehaviour.Controls.Add(this.preyAvoidanceMinRad);
            this.preyBehaviour.Controls.Add(this.preyAvoidanceEnabled);
            this.preyBehaviour.Location = new System.Drawing.Point(18, 32);
            this.preyBehaviour.Name = "preyBehaviour";
            this.preyBehaviour.Size = new System.Drawing.Size(718, 207);
            this.preyBehaviour.TabIndex = 9;
            // 
            // preyFleeMaxInf
            // 
            this.preyFleeMaxInf.BackColor = System.Drawing.SystemColors.Window;
            this.preyFleeMaxInf.DecimalPlaces = 2;
            this.preyFleeMaxInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyFleeMaxInf.Location = new System.Drawing.Point(618, 168);
            this.preyFleeMaxInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyFleeMaxInf.Name = "preyFleeMaxInf";
            this.preyFleeMaxInf.Size = new System.Drawing.Size(78, 20);
            this.preyFleeMaxInf.TabIndex = 45;
            this.preyFleeMaxInf.ThousandsSeparator = true;
            this.preyFleeMaxInf.Value = new decimal(new int[] {
            220,
            0,
            0,
            0});
            // 
            // preyFleeMinInf
            // 
            this.preyFleeMinInf.BackColor = System.Drawing.SystemColors.Window;
            this.preyFleeMinInf.DecimalPlaces = 2;
            this.preyFleeMinInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyFleeMinInf.Location = new System.Drawing.Point(518, 168);
            this.preyFleeMinInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyFleeMinInf.Name = "preyFleeMinInf";
            this.preyFleeMinInf.Size = new System.Drawing.Size(78, 20);
            this.preyFleeMinInf.TabIndex = 44;
            this.preyFleeMinInf.ThousandsSeparator = true;
            this.preyFleeMinInf.Value = new decimal(new int[] {
            220,
            0,
            0,
            0});
            // 
            // preyFleeMaxAng
            // 
            this.preyFleeMaxAng.BackColor = System.Drawing.SystemColors.Window;
            this.preyFleeMaxAng.DecimalPlaces = 2;
            this.preyFleeMaxAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyFleeMaxAng.Location = new System.Drawing.Point(418, 168);
            this.preyFleeMaxAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.preyFleeMaxAng.Name = "preyFleeMaxAng";
            this.preyFleeMaxAng.Size = new System.Drawing.Size(78, 20);
            this.preyFleeMaxAng.TabIndex = 43;
            this.preyFleeMaxAng.ThousandsSeparator = true;
            this.preyFleeMaxAng.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // preyFleeMinAng
            // 
            this.preyFleeMinAng.BackColor = System.Drawing.SystemColors.Window;
            this.preyFleeMinAng.DecimalPlaces = 2;
            this.preyFleeMinAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyFleeMinAng.Location = new System.Drawing.Point(318, 168);
            this.preyFleeMinAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.preyFleeMinAng.Name = "preyFleeMinAng";
            this.preyFleeMinAng.Size = new System.Drawing.Size(78, 20);
            this.preyFleeMinAng.TabIndex = 42;
            this.preyFleeMinAng.ThousandsSeparator = true;
            this.preyFleeMinAng.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // preyFleeMaxRad
            // 
            this.preyFleeMaxRad.BackColor = System.Drawing.SystemColors.Window;
            this.preyFleeMaxRad.DecimalPlaces = 2;
            this.preyFleeMaxRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyFleeMaxRad.Location = new System.Drawing.Point(218, 168);
            this.preyFleeMaxRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyFleeMaxRad.Name = "preyFleeMaxRad";
            this.preyFleeMaxRad.Size = new System.Drawing.Size(78, 20);
            this.preyFleeMaxRad.TabIndex = 41;
            this.preyFleeMaxRad.ThousandsSeparator = true;
            this.preyFleeMaxRad.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // preyFleeMinRad
            // 
            this.preyFleeMinRad.BackColor = System.Drawing.SystemColors.Window;
            this.preyFleeMinRad.DecimalPlaces = 2;
            this.preyFleeMinRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyFleeMinRad.Location = new System.Drawing.Point(118, 168);
            this.preyFleeMinRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyFleeMinRad.Name = "preyFleeMinRad";
            this.preyFleeMinRad.Size = new System.Drawing.Size(78, 20);
            this.preyFleeMinRad.TabIndex = 40;
            this.preyFleeMinRad.ThousandsSeparator = true;
            this.preyFleeMinRad.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // preyFleeEnabled
            // 
            this.preyFleeEnabled.AutoSize = true;
            this.preyFleeEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.preyFleeEnabled.Checked = true;
            this.preyFleeEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preyFleeEnabled.Location = new System.Drawing.Point(40, 170);
            this.preyFleeEnabled.Name = "preyFleeEnabled";
            this.preyFleeEnabled.Size = new System.Drawing.Size(46, 17);
            this.preyFleeEnabled.TabIndex = 39;
            this.preyFleeEnabled.Text = "Flee";
            this.preyFleeEnabled.UseVisualStyleBackColor = true;
            this.preyFleeEnabled.CheckedChanged += new System.EventHandler(this.preyFleeEnabled_CheckedChanged);
            // 
            // preySpeedMaxInf
            // 
            this.preySpeedMaxInf.BackColor = System.Drawing.SystemColors.Window;
            this.preySpeedMaxInf.DecimalPlaces = 2;
            this.preySpeedMaxInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preySpeedMaxInf.Location = new System.Drawing.Point(618, 133);
            this.preySpeedMaxInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preySpeedMaxInf.Name = "preySpeedMaxInf";
            this.preySpeedMaxInf.Size = new System.Drawing.Size(78, 20);
            this.preySpeedMaxInf.TabIndex = 38;
            this.preySpeedMaxInf.ThousandsSeparator = true;
            this.preySpeedMaxInf.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // preySpeedMinInf
            // 
            this.preySpeedMinInf.BackColor = System.Drawing.SystemColors.Window;
            this.preySpeedMinInf.DecimalPlaces = 2;
            this.preySpeedMinInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preySpeedMinInf.Location = new System.Drawing.Point(518, 133);
            this.preySpeedMinInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preySpeedMinInf.Name = "preySpeedMinInf";
            this.preySpeedMinInf.Size = new System.Drawing.Size(78, 20);
            this.preySpeedMinInf.TabIndex = 37;
            this.preySpeedMinInf.ThousandsSeparator = true;
            this.preySpeedMinInf.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // preySpeedMaxAng
            // 
            this.preySpeedMaxAng.BackColor = System.Drawing.SystemColors.Window;
            this.preySpeedMaxAng.DecimalPlaces = 2;
            this.preySpeedMaxAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preySpeedMaxAng.Location = new System.Drawing.Point(418, 133);
            this.preySpeedMaxAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.preySpeedMaxAng.Name = "preySpeedMaxAng";
            this.preySpeedMaxAng.Size = new System.Drawing.Size(78, 20);
            this.preySpeedMaxAng.TabIndex = 36;
            this.preySpeedMaxAng.ThousandsSeparator = true;
            this.preySpeedMaxAng.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // preySpeedMinAng
            // 
            this.preySpeedMinAng.BackColor = System.Drawing.SystemColors.Window;
            this.preySpeedMinAng.DecimalPlaces = 2;
            this.preySpeedMinAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preySpeedMinAng.Location = new System.Drawing.Point(318, 133);
            this.preySpeedMinAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.preySpeedMinAng.Name = "preySpeedMinAng";
            this.preySpeedMinAng.Size = new System.Drawing.Size(78, 20);
            this.preySpeedMinAng.TabIndex = 35;
            this.preySpeedMinAng.ThousandsSeparator = true;
            this.preySpeedMinAng.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // preySpeedMaxRad
            // 
            this.preySpeedMaxRad.BackColor = System.Drawing.SystemColors.Window;
            this.preySpeedMaxRad.DecimalPlaces = 2;
            this.preySpeedMaxRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preySpeedMaxRad.Location = new System.Drawing.Point(218, 133);
            this.preySpeedMaxRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preySpeedMaxRad.Name = "preySpeedMaxRad";
            this.preySpeedMaxRad.Size = new System.Drawing.Size(78, 20);
            this.preySpeedMaxRad.TabIndex = 34;
            this.preySpeedMaxRad.ThousandsSeparator = true;
            this.preySpeedMaxRad.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // preySpeedMinRad
            // 
            this.preySpeedMinRad.BackColor = System.Drawing.SystemColors.Window;
            this.preySpeedMinRad.DecimalPlaces = 2;
            this.preySpeedMinRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preySpeedMinRad.Location = new System.Drawing.Point(118, 133);
            this.preySpeedMinRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preySpeedMinRad.Name = "preySpeedMinRad";
            this.preySpeedMinRad.Size = new System.Drawing.Size(78, 20);
            this.preySpeedMinRad.TabIndex = 33;
            this.preySpeedMinRad.ThousandsSeparator = true;
            this.preySpeedMinRad.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // preySpeedEnabled
            // 
            this.preySpeedEnabled.AutoSize = true;
            this.preySpeedEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.preySpeedEnabled.Checked = true;
            this.preySpeedEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preySpeedEnabled.Location = new System.Drawing.Point(29, 135);
            this.preySpeedEnabled.Name = "preySpeedEnabled";
            this.preySpeedEnabled.Size = new System.Drawing.Size(57, 17);
            this.preySpeedEnabled.TabIndex = 32;
            this.preySpeedEnabled.Text = "Speed";
            this.preySpeedEnabled.UseVisualStyleBackColor = true;
            this.preySpeedEnabled.CheckedChanged += new System.EventHandler(this.preySpeedEnabled_CheckedChanged);
            // 
            // preyHeadingMaxInf
            // 
            this.preyHeadingMaxInf.BackColor = System.Drawing.SystemColors.Window;
            this.preyHeadingMaxInf.DecimalPlaces = 2;
            this.preyHeadingMaxInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyHeadingMaxInf.Location = new System.Drawing.Point(618, 98);
            this.preyHeadingMaxInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyHeadingMaxInf.Name = "preyHeadingMaxInf";
            this.preyHeadingMaxInf.Size = new System.Drawing.Size(78, 20);
            this.preyHeadingMaxInf.TabIndex = 31;
            this.preyHeadingMaxInf.ThousandsSeparator = true;
            this.preyHeadingMaxInf.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // preyHeadingMinInf
            // 
            this.preyHeadingMinInf.BackColor = System.Drawing.SystemColors.Window;
            this.preyHeadingMinInf.DecimalPlaces = 2;
            this.preyHeadingMinInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyHeadingMinInf.Location = new System.Drawing.Point(518, 98);
            this.preyHeadingMinInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyHeadingMinInf.Name = "preyHeadingMinInf";
            this.preyHeadingMinInf.Size = new System.Drawing.Size(78, 20);
            this.preyHeadingMinInf.TabIndex = 30;
            this.preyHeadingMinInf.ThousandsSeparator = true;
            this.preyHeadingMinInf.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // preyHeadingMaxAng
            // 
            this.preyHeadingMaxAng.BackColor = System.Drawing.SystemColors.Window;
            this.preyHeadingMaxAng.DecimalPlaces = 2;
            this.preyHeadingMaxAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyHeadingMaxAng.Location = new System.Drawing.Point(418, 98);
            this.preyHeadingMaxAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.preyHeadingMaxAng.Name = "preyHeadingMaxAng";
            this.preyHeadingMaxAng.Size = new System.Drawing.Size(78, 20);
            this.preyHeadingMaxAng.TabIndex = 29;
            this.preyHeadingMaxAng.ThousandsSeparator = true;
            this.preyHeadingMaxAng.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // preyHeadingMinAng
            // 
            this.preyHeadingMinAng.BackColor = System.Drawing.SystemColors.Window;
            this.preyHeadingMinAng.DecimalPlaces = 2;
            this.preyHeadingMinAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyHeadingMinAng.Location = new System.Drawing.Point(318, 98);
            this.preyHeadingMinAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.preyHeadingMinAng.Name = "preyHeadingMinAng";
            this.preyHeadingMinAng.Size = new System.Drawing.Size(78, 20);
            this.preyHeadingMinAng.TabIndex = 28;
            this.preyHeadingMinAng.ThousandsSeparator = true;
            this.preyHeadingMinAng.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // preyHeadingMaxRad
            // 
            this.preyHeadingMaxRad.BackColor = System.Drawing.SystemColors.Window;
            this.preyHeadingMaxRad.DecimalPlaces = 2;
            this.preyHeadingMaxRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyHeadingMaxRad.Location = new System.Drawing.Point(218, 98);
            this.preyHeadingMaxRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyHeadingMaxRad.Name = "preyHeadingMaxRad";
            this.preyHeadingMaxRad.Size = new System.Drawing.Size(78, 20);
            this.preyHeadingMaxRad.TabIndex = 27;
            this.preyHeadingMaxRad.ThousandsSeparator = true;
            this.preyHeadingMaxRad.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // preyHeadingMinRad
            // 
            this.preyHeadingMinRad.BackColor = System.Drawing.SystemColors.Window;
            this.preyHeadingMinRad.DecimalPlaces = 2;
            this.preyHeadingMinRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyHeadingMinRad.Location = new System.Drawing.Point(118, 98);
            this.preyHeadingMinRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyHeadingMinRad.Name = "preyHeadingMinRad";
            this.preyHeadingMinRad.Size = new System.Drawing.Size(78, 20);
            this.preyHeadingMinRad.TabIndex = 26;
            this.preyHeadingMinRad.ThousandsSeparator = true;
            this.preyHeadingMinRad.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // preyHeadingEnabled
            // 
            this.preyHeadingEnabled.AutoSize = true;
            this.preyHeadingEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.preyHeadingEnabled.Checked = true;
            this.preyHeadingEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preyHeadingEnabled.Location = new System.Drawing.Point(20, 100);
            this.preyHeadingEnabled.Name = "preyHeadingEnabled";
            this.preyHeadingEnabled.Size = new System.Drawing.Size(66, 17);
            this.preyHeadingEnabled.TabIndex = 25;
            this.preyHeadingEnabled.Text = "Heading";
            this.preyHeadingEnabled.UseVisualStyleBackColor = true;
            this.preyHeadingEnabled.CheckedChanged += new System.EventHandler(this.preyHeadingEnabled_CheckedChanged);
            // 
            // preyGroupingMaxInf
            // 
            this.preyGroupingMaxInf.BackColor = System.Drawing.SystemColors.Window;
            this.preyGroupingMaxInf.DecimalPlaces = 2;
            this.preyGroupingMaxInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyGroupingMaxInf.Location = new System.Drawing.Point(618, 63);
            this.preyGroupingMaxInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyGroupingMaxInf.Name = "preyGroupingMaxInf";
            this.preyGroupingMaxInf.Size = new System.Drawing.Size(78, 20);
            this.preyGroupingMaxInf.TabIndex = 24;
            this.preyGroupingMaxInf.ThousandsSeparator = true;
            this.preyGroupingMaxInf.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // preyGroupingMinInf
            // 
            this.preyGroupingMinInf.BackColor = System.Drawing.SystemColors.Window;
            this.preyGroupingMinInf.DecimalPlaces = 2;
            this.preyGroupingMinInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyGroupingMinInf.Location = new System.Drawing.Point(518, 63);
            this.preyGroupingMinInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyGroupingMinInf.Name = "preyGroupingMinInf";
            this.preyGroupingMinInf.Size = new System.Drawing.Size(78, 20);
            this.preyGroupingMinInf.TabIndex = 23;
            this.preyGroupingMinInf.ThousandsSeparator = true;
            this.preyGroupingMinInf.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // preyGroupingMaxAng
            // 
            this.preyGroupingMaxAng.BackColor = System.Drawing.SystemColors.Window;
            this.preyGroupingMaxAng.DecimalPlaces = 2;
            this.preyGroupingMaxAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyGroupingMaxAng.Location = new System.Drawing.Point(418, 63);
            this.preyGroupingMaxAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.preyGroupingMaxAng.Name = "preyGroupingMaxAng";
            this.preyGroupingMaxAng.Size = new System.Drawing.Size(78, 20);
            this.preyGroupingMaxAng.TabIndex = 22;
            this.preyGroupingMaxAng.ThousandsSeparator = true;
            this.preyGroupingMaxAng.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // preyGroupingMinAng
            // 
            this.preyGroupingMinAng.BackColor = System.Drawing.SystemColors.Window;
            this.preyGroupingMinAng.DecimalPlaces = 2;
            this.preyGroupingMinAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyGroupingMinAng.Location = new System.Drawing.Point(318, 63);
            this.preyGroupingMinAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.preyGroupingMinAng.Name = "preyGroupingMinAng";
            this.preyGroupingMinAng.Size = new System.Drawing.Size(78, 20);
            this.preyGroupingMinAng.TabIndex = 21;
            this.preyGroupingMinAng.ThousandsSeparator = true;
            this.preyGroupingMinAng.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // preyGroupingMaxRad
            // 
            this.preyGroupingMaxRad.BackColor = System.Drawing.SystemColors.Window;
            this.preyGroupingMaxRad.DecimalPlaces = 2;
            this.preyGroupingMaxRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyGroupingMaxRad.Location = new System.Drawing.Point(218, 63);
            this.preyGroupingMaxRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyGroupingMaxRad.Name = "preyGroupingMaxRad";
            this.preyGroupingMaxRad.Size = new System.Drawing.Size(78, 20);
            this.preyGroupingMaxRad.TabIndex = 20;
            this.preyGroupingMaxRad.ThousandsSeparator = true;
            this.preyGroupingMaxRad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // preyGroupingMinRad
            // 
            this.preyGroupingMinRad.BackColor = System.Drawing.SystemColors.Window;
            this.preyGroupingMinRad.DecimalPlaces = 2;
            this.preyGroupingMinRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyGroupingMinRad.Location = new System.Drawing.Point(118, 63);
            this.preyGroupingMinRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyGroupingMinRad.Name = "preyGroupingMinRad";
            this.preyGroupingMinRad.Size = new System.Drawing.Size(78, 20);
            this.preyGroupingMinRad.TabIndex = 19;
            this.preyGroupingMinRad.ThousandsSeparator = true;
            this.preyGroupingMinRad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // preyGroupingEnabled
            // 
            this.preyGroupingEnabled.AutoSize = true;
            this.preyGroupingEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.preyGroupingEnabled.Checked = true;
            this.preyGroupingEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preyGroupingEnabled.Location = new System.Drawing.Point(17, 65);
            this.preyGroupingEnabled.Name = "preyGroupingEnabled";
            this.preyGroupingEnabled.Size = new System.Drawing.Size(69, 17);
            this.preyGroupingEnabled.TabIndex = 18;
            this.preyGroupingEnabled.Text = "Grouping";
            this.preyGroupingEnabled.UseVisualStyleBackColor = true;
            this.preyGroupingEnabled.CheckedChanged += new System.EventHandler(this.preyGroupingEnabled_CheckedChanged);
            // 
            // labelPreyMaxInf
            // 
            this.labelPreyMaxInf.AutoSize = true;
            this.labelPreyMaxInf.Location = new System.Drawing.Point(620, 8);
            this.labelPreyMaxInf.Name = "labelPreyMaxInf";
            this.labelPreyMaxInf.Size = new System.Drawing.Size(74, 13);
            this.labelPreyMaxInf.TabIndex = 16;
            this.labelPreyMaxInf.Text = "Max Influence";
            this.labelPreyMaxInf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // preyAvoidanceMaxInf
            // 
            this.preyAvoidanceMaxInf.BackColor = System.Drawing.SystemColors.Window;
            this.preyAvoidanceMaxInf.DecimalPlaces = 2;
            this.preyAvoidanceMaxInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyAvoidanceMaxInf.Location = new System.Drawing.Point(618, 28);
            this.preyAvoidanceMaxInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyAvoidanceMaxInf.Name = "preyAvoidanceMaxInf";
            this.preyAvoidanceMaxInf.Size = new System.Drawing.Size(78, 20);
            this.preyAvoidanceMaxInf.TabIndex = 17;
            this.preyAvoidanceMaxInf.ThousandsSeparator = true;
            this.preyAvoidanceMaxInf.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // labelPreyMinInf
            // 
            this.labelPreyMinInf.AutoSize = true;
            this.labelPreyMinInf.Location = new System.Drawing.Point(522, 8);
            this.labelPreyMinInf.Name = "labelPreyMinInf";
            this.labelPreyMinInf.Size = new System.Drawing.Size(71, 13);
            this.labelPreyMinInf.TabIndex = 14;
            this.labelPreyMinInf.Text = "Min Influence";
            this.labelPreyMinInf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // preyAvoidanceMinInf
            // 
            this.preyAvoidanceMinInf.BackColor = System.Drawing.SystemColors.Window;
            this.preyAvoidanceMinInf.DecimalPlaces = 2;
            this.preyAvoidanceMinInf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyAvoidanceMinInf.Location = new System.Drawing.Point(518, 28);
            this.preyAvoidanceMinInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyAvoidanceMinInf.Name = "preyAvoidanceMinInf";
            this.preyAvoidanceMinInf.Size = new System.Drawing.Size(78, 20);
            this.preyAvoidanceMinInf.TabIndex = 15;
            this.preyAvoidanceMinInf.ThousandsSeparator = true;
            this.preyAvoidanceMinInf.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // labelPreyMaxAng
            // 
            this.labelPreyMaxAng.AutoSize = true;
            this.labelPreyMaxAng.Location = new System.Drawing.Point(427, 8);
            this.labelPreyMaxAng.Name = "labelPreyMaxAng";
            this.labelPreyMaxAng.Size = new System.Drawing.Size(57, 13);
            this.labelPreyMaxAng.TabIndex = 12;
            this.labelPreyMaxAng.Text = "Max Angle";
            this.labelPreyMaxAng.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // preyAvoidanceMaxAng
            // 
            this.preyAvoidanceMaxAng.BackColor = System.Drawing.SystemColors.Window;
            this.preyAvoidanceMaxAng.DecimalPlaces = 2;
            this.preyAvoidanceMaxAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyAvoidanceMaxAng.Location = new System.Drawing.Point(418, 28);
            this.preyAvoidanceMaxAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.preyAvoidanceMaxAng.Name = "preyAvoidanceMaxAng";
            this.preyAvoidanceMaxAng.Size = new System.Drawing.Size(78, 20);
            this.preyAvoidanceMaxAng.TabIndex = 13;
            this.preyAvoidanceMaxAng.ThousandsSeparator = true;
            this.preyAvoidanceMaxAng.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // labelPreyMinAng
            // 
            this.labelPreyMinAng.AutoSize = true;
            this.labelPreyMinAng.Location = new System.Drawing.Point(329, 8);
            this.labelPreyMinAng.Name = "labelPreyMinAng";
            this.labelPreyMinAng.Size = new System.Drawing.Size(54, 13);
            this.labelPreyMinAng.TabIndex = 10;
            this.labelPreyMinAng.Text = "Min Angle";
            this.labelPreyMinAng.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // preyAvoidanceMinAng
            // 
            this.preyAvoidanceMinAng.BackColor = System.Drawing.SystemColors.Window;
            this.preyAvoidanceMinAng.DecimalPlaces = 2;
            this.preyAvoidanceMinAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyAvoidanceMinAng.Location = new System.Drawing.Point(318, 28);
            this.preyAvoidanceMinAng.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.preyAvoidanceMinAng.Name = "preyAvoidanceMinAng";
            this.preyAvoidanceMinAng.Size = new System.Drawing.Size(78, 20);
            this.preyAvoidanceMinAng.TabIndex = 11;
            this.preyAvoidanceMinAng.ThousandsSeparator = true;
            this.preyAvoidanceMinAng.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // labelPreyMaxRad
            // 
            this.labelPreyMaxRad.AutoSize = true;
            this.labelPreyMaxRad.Location = new System.Drawing.Point(226, 8);
            this.labelPreyMaxRad.Name = "labelPreyMaxRad";
            this.labelPreyMaxRad.Size = new System.Drawing.Size(63, 13);
            this.labelPreyMaxRad.TabIndex = 8;
            this.labelPreyMaxRad.Text = "Max Radius";
            this.labelPreyMaxRad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // preyAvoidanceMaxRad
            // 
            this.preyAvoidanceMaxRad.BackColor = System.Drawing.SystemColors.Window;
            this.preyAvoidanceMaxRad.DecimalPlaces = 2;
            this.preyAvoidanceMaxRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyAvoidanceMaxRad.Location = new System.Drawing.Point(218, 28);
            this.preyAvoidanceMaxRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyAvoidanceMaxRad.Name = "preyAvoidanceMaxRad";
            this.preyAvoidanceMaxRad.Size = new System.Drawing.Size(78, 20);
            this.preyAvoidanceMaxRad.TabIndex = 9;
            this.preyAvoidanceMaxRad.ThousandsSeparator = true;
            this.preyAvoidanceMaxRad.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // labelPreyMinRad
            // 
            this.labelPreyMinRad.AutoSize = true;
            this.labelPreyMinRad.Location = new System.Drawing.Point(127, 8);
            this.labelPreyMinRad.Name = "labelPreyMinRad";
            this.labelPreyMinRad.Size = new System.Drawing.Size(60, 13);
            this.labelPreyMinRad.TabIndex = 7;
            this.labelPreyMinRad.Text = "Min Radius";
            this.labelPreyMinRad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // preyAvoidanceMinRad
            // 
            this.preyAvoidanceMinRad.BackColor = System.Drawing.SystemColors.Window;
            this.preyAvoidanceMinRad.DecimalPlaces = 2;
            this.preyAvoidanceMinRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.preyAvoidanceMinRad.Location = new System.Drawing.Point(118, 28);
            this.preyAvoidanceMinRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.preyAvoidanceMinRad.Name = "preyAvoidanceMinRad";
            this.preyAvoidanceMinRad.Size = new System.Drawing.Size(78, 20);
            this.preyAvoidanceMinRad.TabIndex = 7;
            this.preyAvoidanceMinRad.ThousandsSeparator = true;
            this.preyAvoidanceMinRad.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // preyAvoidanceEnabled
            // 
            this.preyAvoidanceEnabled.AutoSize = true;
            this.preyAvoidanceEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.preyAvoidanceEnabled.Checked = true;
            this.preyAvoidanceEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preyAvoidanceEnabled.Location = new System.Drawing.Point(9, 30);
            this.preyAvoidanceEnabled.Name = "preyAvoidanceEnabled";
            this.preyAvoidanceEnabled.Size = new System.Drawing.Size(77, 17);
            this.preyAvoidanceEnabled.TabIndex = 6;
            this.preyAvoidanceEnabled.Text = "Avoidance";
            this.preyAvoidanceEnabled.UseVisualStyleBackColor = true;
            this.preyAvoidanceEnabled.CheckedChanged += new System.EventHandler(this.preyAvoidanceEnabled_CheckedChanged);
            // 
            // preyBehaviourLabel
            // 
            this.preyBehaviourLabel.AutoSize = true;
            this.preyBehaviourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preyBehaviourLabel.Location = new System.Drawing.Point(15, 13);
            this.preyBehaviourLabel.Name = "preyBehaviourLabel";
            this.preyBehaviourLabel.Size = new System.Drawing.Size(79, 13);
            this.preyBehaviourLabel.TabIndex = 8;
            this.preyBehaviourLabel.Text = "Prey Behaviour";
            // 
            // clientOptions
            // 
            this.clientOptions.Controls.Add(this.clientNetwork);
            this.clientOptions.Controls.Add(this.labelClientNetwork);
            this.clientOptions.Controls.Add(this.clientPerf);
            this.clientOptions.Controls.Add(this.labelClientPerf);
            this.clientOptions.Location = new System.Drawing.Point(4, 22);
            this.clientOptions.Name = "clientOptions";
            this.clientOptions.Size = new System.Drawing.Size(751, 543);
            this.clientOptions.TabIndex = 4;
            this.clientOptions.Text = "Client Options";
            this.clientOptions.UseVisualStyleBackColor = true;
            // 
            // clientNetwork
            // 
            this.clientNetwork.BackColor = System.Drawing.Color.Transparent;
            this.clientNetwork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clientNetwork.Controls.Add(this.broadcastEnabled);
            this.clientNetwork.Controls.Add(this.clientConnectPort);
            this.clientNetwork.Controls.Add(this.clientConnectIP);
            this.clientNetwork.Controls.Add(this.clientConnectPortLabel);
            this.clientNetwork.Controls.Add(this.clientConnectIPLabel);
            this.clientNetwork.Location = new System.Drawing.Point(18, 133);
            this.clientNetwork.Name = "clientNetwork";
            this.clientNetwork.Size = new System.Drawing.Size(453, 113);
            this.clientNetwork.TabIndex = 14;
            // 
            // broadcastEnabled
            // 
            this.broadcastEnabled.AutoSize = true;
            this.broadcastEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.broadcastEnabled.Checked = true;
            this.broadcastEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.broadcastEnabled.Location = new System.Drawing.Point(9, 10);
            this.broadcastEnabled.Name = "broadcastEnabled";
            this.broadcastEnabled.Size = new System.Drawing.Size(74, 17);
            this.broadcastEnabled.TabIndex = 11;
            this.broadcastEnabled.Text = "Broadcast";
            this.toolTip.SetToolTip(this.broadcastEnabled, "Attempts to broadcast to all local addresses to handshake with a server. If the s" +
        "erver is remote, or a handshake is not successful, try connecting with a direct " +
        "IP");
            this.broadcastEnabled.UseVisualStyleBackColor = true;
            this.broadcastEnabled.CheckedChanged += new System.EventHandler(this.broadcastEnabled_CheckedChanged);
            // 
            // clientConnectPort
            // 
            this.clientConnectPort.Location = new System.Drawing.Point(138, 78);
            this.clientConnectPort.MaxLength = 5;
            this.clientConnectPort.Name = "clientConnectPort";
            this.clientConnectPort.Size = new System.Drawing.Size(84, 20);
            this.clientConnectPort.TabIndex = 10;
            this.clientConnectPort.Text = "1300";
            this.toolTip.SetToolTip(this.clientConnectPort, "The port the server is listening on.");
            this.clientConnectPort.Validating += new System.ComponentModel.CancelEventHandler(this.clientConnectPort_Validating);
            // 
            // clientConnectIP
            // 
            this.clientConnectIP.Enabled = false;
            this.clientConnectIP.Location = new System.Drawing.Point(138, 42);
            this.clientConnectIP.MaxLength = 45;
            this.clientConnectIP.Name = "clientConnectIP";
            this.clientConnectIP.Size = new System.Drawing.Size(302, 20);
            this.clientConnectIP.TabIndex = 9;
            this.toolTip.SetToolTip(this.clientConnectIP, "The direct server IP you wish to connect to.");
            // 
            // clientConnectPortLabel
            // 
            this.clientConnectPortLabel.AutoSize = true;
            this.clientConnectPortLabel.Location = new System.Drawing.Point(10, 80);
            this.clientConnectPortLabel.Name = "clientConnectPortLabel";
            this.clientConnectPortLabel.Size = new System.Drawing.Size(69, 13);
            this.clientConnectPortLabel.TabIndex = 4;
            this.clientConnectPortLabel.Text = "Connect Port";
            this.toolTip.SetToolTip(this.clientConnectPortLabel, "The port the server is listening on.");
            // 
            // clientConnectIPLabel
            // 
            this.clientConnectIPLabel.AutoSize = true;
            this.clientConnectIPLabel.Location = new System.Drawing.Point(10, 45);
            this.clientConnectIPLabel.Name = "clientConnectIPLabel";
            this.clientConnectIPLabel.Size = new System.Drawing.Size(60, 13);
            this.clientConnectIPLabel.TabIndex = 2;
            this.clientConnectIPLabel.Text = "Connect IP";
            this.toolTip.SetToolTip(this.clientConnectIPLabel, "The direct server IP you wish to connect to.");
            // 
            // labelClientNetwork
            // 
            this.labelClientNetwork.AutoSize = true;
            this.labelClientNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientNetwork.Location = new System.Drawing.Point(15, 114);
            this.labelClientNetwork.Name = "labelClientNetwork";
            this.labelClientNetwork.Size = new System.Drawing.Size(47, 13);
            this.labelClientNetwork.TabIndex = 13;
            this.labelClientNetwork.Text = "Network";
            // 
            // clientPerf
            // 
            this.clientPerf.BackColor = System.Drawing.Color.Transparent;
            this.clientPerf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clientPerf.Controls.Add(this.labelClientPhysIntSec);
            this.clientPerf.Controls.Add(this.frameRateLockEnabled);
            this.clientPerf.Controls.Add(this.frameRateCapAmt);
            this.clientPerf.Controls.Add(this.clientPhysInt);
            this.clientPerf.Controls.Add(this.labelClientPhysInt);
            this.clientPerf.Location = new System.Drawing.Point(18, 32);
            this.clientPerf.Name = "clientPerf";
            this.clientPerf.Size = new System.Drawing.Size(453, 79);
            this.clientPerf.TabIndex = 12;
            // 
            // labelClientPhysIntSec
            // 
            this.labelClientPhysIntSec.AutoSize = true;
            this.labelClientPhysIntSec.Location = new System.Drawing.Point(228, 46);
            this.labelClientPhysIntSec.Name = "labelClientPhysIntSec";
            this.labelClientPhysIntSec.Size = new System.Drawing.Size(49, 13);
            this.labelClientPhysIntSec.TabIndex = 11;
            this.labelClientPhysIntSec.Text = "Seconds";
            // 
            // frameRateLockEnabled
            // 
            this.frameRateLockEnabled.AutoSize = true;
            this.frameRateLockEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frameRateLockEnabled.Location = new System.Drawing.Point(10, 9);
            this.frameRateLockEnabled.Name = "frameRateLockEnabled";
            this.frameRateLockEnabled.Size = new System.Drawing.Size(108, 17);
            this.frameRateLockEnabled.TabIndex = 10;
            this.frameRateLockEnabled.Text = "Lock Frame Rate";
            this.toolTip.SetToolTip(this.frameRateLockEnabled, "How often to render the scene. This does not affect the speed of the simulation, " +
        "only the smoothness of rendering.");
            this.frameRateLockEnabled.UseVisualStyleBackColor = true;
            this.frameRateLockEnabled.CheckedChanged += new System.EventHandler(this.frameRateLockEnabled_CheckedChanged);
            // 
            // frameRateCapAmt
            // 
            this.frameRateCapAmt.BackColor = System.Drawing.SystemColors.Window;
            this.frameRateCapAmt.Enabled = false;
            this.frameRateCapAmt.Location = new System.Drawing.Point(138, 8);
            this.frameRateCapAmt.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.frameRateCapAmt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameRateCapAmt.Name = "frameRateCapAmt";
            this.frameRateCapAmt.Size = new System.Drawing.Size(84, 20);
            this.frameRateCapAmt.TabIndex = 9;
            this.frameRateCapAmt.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.frameRateCapAmt, "How often to render the scene. This does not affect the speed of the simulation, " +
        "only the smoothness of rendering.");
            this.frameRateCapAmt.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // clientPhysInt
            // 
            this.clientPhysInt.BackColor = System.Drawing.SystemColors.Window;
            this.clientPhysInt.DecimalPlaces = 3;
            this.clientPhysInt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.clientPhysInt.Location = new System.Drawing.Point(138, 43);
            this.clientPhysInt.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clientPhysInt.Name = "clientPhysInt";
            this.clientPhysInt.Size = new System.Drawing.Size(84, 20);
            this.clientPhysInt.TabIndex = 8;
            this.clientPhysInt.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.clientPhysInt, "The interval between agent and physics updates, which are independent from frame " +
        "rate.");
            this.clientPhysInt.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // labelClientPhysInt
            // 
            this.labelClientPhysInt.AutoSize = true;
            this.labelClientPhysInt.Location = new System.Drawing.Point(10, 45);
            this.labelClientPhysInt.Name = "labelClientPhysInt";
            this.labelClientPhysInt.Size = new System.Drawing.Size(81, 13);
            this.labelClientPhysInt.TabIndex = 4;
            this.labelClientPhysInt.Text = "Physics Interval";
            this.toolTip.SetToolTip(this.labelClientPhysInt, "The interval between agent and physics updates, which are independent from frame " +
        "rate.");
            // 
            // labelClientPerf
            // 
            this.labelClientPerf.AutoSize = true;
            this.labelClientPerf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientPerf.Location = new System.Drawing.Point(15, 13);
            this.labelClientPerf.Name = "labelClientPerf";
            this.labelClientPerf.Size = new System.Drawing.Size(67, 13);
            this.labelClientPerf.TabIndex = 11;
            this.labelClientPerf.Text = "Performance";
            // 
            // serverOptions
            // 
            this.serverOptions.Controls.Add(this.serverNetwork);
            this.serverOptions.Controls.Add(this.labelServerNetwork);
            this.serverOptions.Controls.Add(this.serverLimits);
            this.serverOptions.Controls.Add(this.labelServerLimits);
            this.serverOptions.Location = new System.Drawing.Point(4, 22);
            this.serverOptions.Name = "serverOptions";
            this.serverOptions.Size = new System.Drawing.Size(751, 543);
            this.serverOptions.TabIndex = 2;
            this.serverOptions.Text = "Server Options";
            this.serverOptions.UseVisualStyleBackColor = true;
            // 
            // serverNetwork
            // 
            this.serverNetwork.BackColor = System.Drawing.Color.Transparent;
            this.serverNetwork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serverNetwork.Controls.Add(this.serverPort);
            this.serverNetwork.Controls.Add(this.labelServerPort);
            this.serverNetwork.Location = new System.Drawing.Point(18, 169);
            this.serverNetwork.Name = "serverNetwork";
            this.serverNetwork.Size = new System.Drawing.Size(453, 45);
            this.serverNetwork.TabIndex = 16;
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(148, 8);
            this.serverPort.MaxLength = 5;
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(84, 20);
            this.serverPort.TabIndex = 10;
            this.serverPort.Text = "1300";
            this.toolTip.SetToolTip(this.serverPort, "The listen port for the server. Make sure this port is open before attempting to " +
        "host.");
            // 
            // labelServerPort
            // 
            this.labelServerPort.AutoSize = true;
            this.labelServerPort.Location = new System.Drawing.Point(10, 10);
            this.labelServerPort.Name = "labelServerPort";
            this.labelServerPort.Size = new System.Drawing.Size(60, 13);
            this.labelServerPort.TabIndex = 4;
            this.labelServerPort.Text = "Server Port";
            this.toolTip.SetToolTip(this.labelServerPort, "The listen port for the server. Make sure this port is open before attempting to " +
        "host.");
            // 
            // labelServerNetwork
            // 
            this.labelServerNetwork.AutoSize = true;
            this.labelServerNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerNetwork.Location = new System.Drawing.Point(15, 150);
            this.labelServerNetwork.Name = "labelServerNetwork";
            this.labelServerNetwork.Size = new System.Drawing.Size(47, 13);
            this.labelServerNetwork.TabIndex = 15;
            this.labelServerNetwork.Text = "Network";
            // 
            // serverLimits
            // 
            this.serverLimits.BackColor = System.Drawing.Color.Transparent;
            this.serverLimits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serverLimits.Controls.Add(this.labelServerPhysIntSec);
            this.serverLimits.Controls.Add(this.serverPhysInt);
            this.serverLimits.Controls.Add(this.labelServerPhysInt);
            this.serverLimits.Controls.Add(this.serverMaxClients);
            this.serverLimits.Controls.Add(this.labelServerMaxClients);
            this.serverLimits.Controls.Add(this.maxAgentsPerC);
            this.serverLimits.Controls.Add(this.labelMaxAgentsPerC);
            this.serverLimits.Location = new System.Drawing.Point(18, 32);
            this.serverLimits.Name = "serverLimits";
            this.serverLimits.Size = new System.Drawing.Size(337, 115);
            this.serverLimits.TabIndex = 8;
            // 
            // labelServerPhysIntSec
            // 
            this.labelServerPhysIntSec.AutoSize = true;
            this.labelServerPhysIntSec.Location = new System.Drawing.Point(238, 81);
            this.labelServerPhysIntSec.Name = "labelServerPhysIntSec";
            this.labelServerPhysIntSec.Size = new System.Drawing.Size(49, 13);
            this.labelServerPhysIntSec.TabIndex = 17;
            this.labelServerPhysIntSec.Text = "Seconds";
            // 
            // serverPhysInt
            // 
            this.serverPhysInt.BackColor = System.Drawing.SystemColors.Window;
            this.serverPhysInt.DecimalPlaces = 3;
            this.serverPhysInt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.serverPhysInt.Location = new System.Drawing.Point(148, 78);
            this.serverPhysInt.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.serverPhysInt.Name = "serverPhysInt";
            this.serverPhysInt.Size = new System.Drawing.Size(84, 20);
            this.serverPhysInt.TabIndex = 17;
            this.serverPhysInt.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.serverPhysInt, "Caps the number of updates that the client can send to the server.");
            this.serverPhysInt.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // labelServerPhysInt
            // 
            this.labelServerPhysInt.AutoSize = true;
            this.labelServerPhysInt.Location = new System.Drawing.Point(10, 80);
            this.labelServerPhysInt.Name = "labelServerPhysInt";
            this.labelServerPhysInt.Size = new System.Drawing.Size(133, 13);
            this.labelServerPhysInt.TabIndex = 9;
            this.labelServerPhysInt.Text = "Max Client Physics Interval";
            this.toolTip.SetToolTip(this.labelServerPhysInt, "Caps the number of updates that the client can send to the server.");
            // 
            // serverMaxClients
            // 
            this.serverMaxClients.BackColor = System.Drawing.SystemColors.Window;
            this.serverMaxClients.Location = new System.Drawing.Point(148, 43);
            this.serverMaxClients.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.serverMaxClients.Name = "serverMaxClients";
            this.serverMaxClients.Size = new System.Drawing.Size(84, 20);
            this.serverMaxClients.TabIndex = 8;
            this.serverMaxClients.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.serverMaxClients, "Maximum number of simultaneous clients. Additional clients are ignored.");
            this.serverMaxClients.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // labelServerMaxClients
            // 
            this.labelServerMaxClients.AutoSize = true;
            this.labelServerMaxClients.Location = new System.Drawing.Point(10, 45);
            this.labelServerMaxClients.Name = "labelServerMaxClients";
            this.labelServerMaxClients.Size = new System.Drawing.Size(61, 13);
            this.labelServerMaxClients.TabIndex = 4;
            this.labelServerMaxClients.Text = "Max Clients";
            this.toolTip.SetToolTip(this.labelServerMaxClients, "Maximum number of simultaneous clients. Additional clients are ignored.");
            // 
            // maxAgentsPerC
            // 
            this.maxAgentsPerC.BackColor = System.Drawing.SystemColors.Window;
            this.maxAgentsPerC.Location = new System.Drawing.Point(148, 8);
            this.maxAgentsPerC.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxAgentsPerC.Name = "maxAgentsPerC";
            this.maxAgentsPerC.Size = new System.Drawing.Size(84, 20);
            this.maxAgentsPerC.TabIndex = 3;
            this.maxAgentsPerC.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.maxAgentsPerC, "Limits the number of agents each client can send to the server. Additional agents" +
        " are ignored.");
            this.maxAgentsPerC.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // labelMaxAgentsPerC
            // 
            this.labelMaxAgentsPerC.AutoSize = true;
            this.labelMaxAgentsPerC.Location = new System.Drawing.Point(10, 10);
            this.labelMaxAgentsPerC.Name = "labelMaxAgentsPerC";
            this.labelMaxAgentsPerC.Size = new System.Drawing.Size(111, 13);
            this.labelMaxAgentsPerC.TabIndex = 2;
            this.labelMaxAgentsPerC.Text = "Max Agents Per Client";
            this.toolTip.SetToolTip(this.labelMaxAgentsPerC, "Limits the number of agents each client can send to the server. Additional agents" +
        " are ignored.");
            // 
            // labelServerLimits
            // 
            this.labelServerLimits.AutoSize = true;
            this.labelServerLimits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerLimits.Location = new System.Drawing.Point(15, 13);
            this.labelServerLimits.Name = "labelServerLimits";
            this.labelServerLimits.Size = new System.Drawing.Size(33, 13);
            this.labelServerLimits.TabIndex = 7;
            this.labelServerLimits.Text = "Limits";
            // 
            // startLocal
            // 
            this.startLocal.Location = new System.Drawing.Point(521, 12);
            this.startLocal.Name = "startLocal";
            this.startLocal.Size = new System.Drawing.Size(122, 23);
            this.startLocal.TabIndex = 3;
            this.startLocal.Text = "Start Local";
            this.toolTip.SetToolTip(this.startLocal, "Start a local simulation");
            this.startLocal.UseVisualStyleBackColor = true;
            this.startLocal.Click += new System.EventHandler(this.startLocal_Click);
            // 
            // startNetworkClient
            // 
            this.startNetworkClient.Enabled = false;
            this.startNetworkClient.Location = new System.Drawing.Point(649, 12);
            this.startNetworkClient.Name = "startNetworkClient";
            this.startNetworkClient.Size = new System.Drawing.Size(122, 23);
            this.startNetworkClient.TabIndex = 4;
            this.startNetworkClient.Text = "Start Network Client";
            this.toolTip.SetToolTip(this.startNetworkClient, "Connect to an existing online server");
            this.startNetworkClient.UseVisualStyleBackColor = true;
            // 
            // startNetworkServer
            // 
            this.startNetworkServer.Enabled = false;
            this.startNetworkServer.Location = new System.Drawing.Point(649, 41);
            this.startNetworkServer.Name = "startNetworkServer";
            this.startNetworkServer.Size = new System.Drawing.Size(122, 23);
            this.startNetworkServer.TabIndex = 5;
            this.startNetworkServer.Text = "Start Network Server";
            this.toolTip.SetToolTip(this.startNetworkServer, "Host server");
            this.startNetworkServer.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(94, 41);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(76, 24);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Export...";
            this.toolTip.SetToolTip(this.exportButton, "Export current config to json");
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 643);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.startNetworkServer);
            this.Controls.Add(this.startNetworkClient);
            this.Controls.Add(this.startLocal);
            this.Controls.Add(this.optionTabs);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.saveButton);
            this.Name = "mainForm";
            this.Text = "Flocking Sim Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.optionTabs.ResumeLayout(false);
            this.agentOptions.ResumeLayout(false);
            this.agentOptions.PerformLayout();
            this.predOptions.ResumeLayout(false);
            this.predOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predMaxSpawnRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMinSpawnRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMaxMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMinMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMaxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMinSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMaxVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMinVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMaxAccel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predMinAccel)).EndInit();
            this.preyOptions.ResumeLayout(false);
            this.preyOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxSpawnRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMinSpawnRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMinMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMinSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxStartVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMinStartVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxAccel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMinAccel)).EndInit();
            this.generalAgentOptions.ResumeLayout(false);
            this.generalAgentOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalAgents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentRatio)).EndInit();
            this.agentBehaviours.ResumeLayout(false);
            this.agentBehaviours.PerformLayout();
            this.predBehaviour.ResumeLayout(false);
            this.predBehaviour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMaxInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMinInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMaxAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMinAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMaxRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predChaseMinRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMaxInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMinInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMaxAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMinAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMaxRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predFleeMinRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMaxInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMinInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMaxAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMinAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMaxRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predSpeedMinRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMaxInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMinInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMaxAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMinAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMaxRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predHeadingMinRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMaxInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMinInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMaxAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMinAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMaxRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predGroupingMinRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMaxInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMinInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMaxAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMinAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMaxRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predAvoidanceMinRad)).EndInit();
            this.preyBehaviour.ResumeLayout(false);
            this.preyBehaviour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMaxInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMinInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMaxAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMinAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMaxRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyFleeMinRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMaxInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMinInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMaxAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMinAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMaxRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preySpeedMinRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMaxInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMinInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMaxAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMinAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMaxRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyHeadingMinRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMaxInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMinInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMaxAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMinAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMaxRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyGroupingMinRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMaxInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMinInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMaxAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMinAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMaxRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyAvoidanceMinRad)).EndInit();
            this.clientOptions.ResumeLayout(false);
            this.clientOptions.PerformLayout();
            this.clientNetwork.ResumeLayout(false);
            this.clientNetwork.PerformLayout();
            this.clientPerf.ResumeLayout(false);
            this.clientPerf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameRateCapAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPhysInt)).EndInit();
            this.serverOptions.ResumeLayout(false);
            this.serverOptions.PerformLayout();
            this.serverNetwork.ResumeLayout(false);
            this.serverNetwork.PerformLayout();
            this.serverLimits.ResumeLayout(false);
            this.serverLimits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverPhysInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverMaxClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAgentsPerC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.TabControl optionTabs;
        private System.Windows.Forms.TabPage agentOptions;
        private System.Windows.Forms.TabPage serverOptions;
        private System.Windows.Forms.Button startLocal;
        private System.Windows.Forms.Button startNetworkClient;
        private System.Windows.Forms.Button startNetworkServer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel serverLimits;
        private System.Windows.Forms.NumericUpDown serverMaxClients;
        private System.Windows.Forms.Label labelServerMaxClients;
        private System.Windows.Forms.NumericUpDown maxAgentsPerC;
        private System.Windows.Forms.Label labelMaxAgentsPerC;
        private System.Windows.Forms.Label labelServerLimits;
        private System.Windows.Forms.Panel generalAgentOptions;
        private System.Windows.Forms.CheckBox rndSpawn;
        private System.Windows.Forms.Label agentRatioValue;
        private System.Windows.Forms.Label labelAgentRatio;
        private System.Windows.Forms.NumericUpDown totalAgents;
        private System.Windows.Forms.Label labelTotalAgents;
        private System.Windows.Forms.TrackBar agentRatio;
        private System.Windows.Forms.Label generalAgentOptionsLabel;
        private System.Windows.Forms.TabPage agentBehaviours;
        private System.Windows.Forms.Panel preyBehaviour;
        private System.Windows.Forms.NumericUpDown preyFleeMaxInf;
        private System.Windows.Forms.NumericUpDown preyFleeMinInf;
        private System.Windows.Forms.NumericUpDown preyFleeMaxAng;
        private System.Windows.Forms.NumericUpDown preyFleeMinAng;
        private System.Windows.Forms.NumericUpDown preyFleeMaxRad;
        private System.Windows.Forms.NumericUpDown preyFleeMinRad;
        private System.Windows.Forms.CheckBox preyFleeEnabled;
        private System.Windows.Forms.NumericUpDown preySpeedMaxInf;
        private System.Windows.Forms.NumericUpDown preySpeedMinInf;
        private System.Windows.Forms.NumericUpDown preySpeedMaxAng;
        private System.Windows.Forms.NumericUpDown preySpeedMinAng;
        private System.Windows.Forms.NumericUpDown preySpeedMaxRad;
        private System.Windows.Forms.NumericUpDown preySpeedMinRad;
        private System.Windows.Forms.CheckBox preySpeedEnabled;
        private System.Windows.Forms.NumericUpDown preyHeadingMaxInf;
        private System.Windows.Forms.NumericUpDown preyHeadingMinInf;
        private System.Windows.Forms.NumericUpDown preyHeadingMaxAng;
        private System.Windows.Forms.NumericUpDown preyHeadingMinAng;
        private System.Windows.Forms.NumericUpDown preyHeadingMaxRad;
        private System.Windows.Forms.NumericUpDown preyHeadingMinRad;
        private System.Windows.Forms.CheckBox preyHeadingEnabled;
        private System.Windows.Forms.NumericUpDown preyGroupingMaxInf;
        private System.Windows.Forms.NumericUpDown preyGroupingMinInf;
        private System.Windows.Forms.NumericUpDown preyGroupingMaxAng;
        private System.Windows.Forms.NumericUpDown preyGroupingMinAng;
        private System.Windows.Forms.NumericUpDown preyGroupingMaxRad;
        private System.Windows.Forms.NumericUpDown preyGroupingMinRad;
        private System.Windows.Forms.CheckBox preyGroupingEnabled;
        private System.Windows.Forms.Label labelPreyMaxInf;
        private System.Windows.Forms.NumericUpDown preyAvoidanceMaxInf;
        private System.Windows.Forms.Label labelPreyMinInf;
        private System.Windows.Forms.NumericUpDown preyAvoidanceMinInf;
        private System.Windows.Forms.Label labelPreyMaxAng;
        private System.Windows.Forms.NumericUpDown preyAvoidanceMaxAng;
        private System.Windows.Forms.Label labelPreyMinAng;
        private System.Windows.Forms.NumericUpDown preyAvoidanceMinAng;
        private System.Windows.Forms.Label labelPreyMaxRad;
        private System.Windows.Forms.NumericUpDown preyAvoidanceMaxRad;
        private System.Windows.Forms.Label labelPreyMinRad;
        private System.Windows.Forms.NumericUpDown preyAvoidanceMinRad;
        private System.Windows.Forms.CheckBox preyAvoidanceEnabled;
        private System.Windows.Forms.Label preyBehaviourLabel;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel preyOptions;
        private System.Windows.Forms.Label labelPreySpawnRad;
        private System.Windows.Forms.NumericUpDown preyMaxSpawnRad;
        private System.Windows.Forms.NumericUpDown preyMinSpawnRad;
        private System.Windows.Forms.Label labelPreyMass;
        private System.Windows.Forms.Label labelPreySize;
        private System.Windows.Forms.Label labelPreyStartVel;
        private System.Windows.Forms.Label labelPreyAccel;
        private System.Windows.Forms.NumericUpDown preyMaxMass;
        private System.Windows.Forms.NumericUpDown preyMinMass;
        private System.Windows.Forms.NumericUpDown preyMaxSize;
        private System.Windows.Forms.NumericUpDown preyMinSize;
        private System.Windows.Forms.NumericUpDown preyMaxStartVel;
        private System.Windows.Forms.NumericUpDown preyMinStartVel;
        private System.Windows.Forms.Label labelPreyOptMax;
        private System.Windows.Forms.NumericUpDown preyMaxAccel;
        private System.Windows.Forms.Label labelPreyOptMin;
        private System.Windows.Forms.NumericUpDown preyMinAccel;
        private System.Windows.Forms.Label preyOptionsLabel;
        private System.Windows.Forms.Panel predBehaviour;
        private System.Windows.Forms.NumericUpDown predChaseMaxInf;
        private System.Windows.Forms.NumericUpDown predChaseMinInf;
        private System.Windows.Forms.NumericUpDown predChaseMaxAng;
        private System.Windows.Forms.NumericUpDown predChaseMinAng;
        private System.Windows.Forms.NumericUpDown predChaseMaxRad;
        private System.Windows.Forms.NumericUpDown predChaseMinRad;
        private System.Windows.Forms.CheckBox predChaseEnabled;
        private System.Windows.Forms.NumericUpDown predFleeMaxInf;
        private System.Windows.Forms.NumericUpDown predFleeMinInf;
        private System.Windows.Forms.NumericUpDown predFleeMaxAng;
        private System.Windows.Forms.NumericUpDown predFleeMinAng;
        private System.Windows.Forms.NumericUpDown predFleeMaxRad;
        private System.Windows.Forms.NumericUpDown predFleeMinRad;
        private System.Windows.Forms.CheckBox predFleeEnabled;
        private System.Windows.Forms.NumericUpDown predSpeedMaxInf;
        private System.Windows.Forms.NumericUpDown predSpeedMinInf;
        private System.Windows.Forms.NumericUpDown predSpeedMaxAng;
        private System.Windows.Forms.NumericUpDown predSpeedMinAng;
        private System.Windows.Forms.NumericUpDown predSpeedMaxRad;
        private System.Windows.Forms.NumericUpDown predSpeedMinRad;
        private System.Windows.Forms.CheckBox predSpeedEnabled;
        private System.Windows.Forms.NumericUpDown predHeadingMaxInf;
        private System.Windows.Forms.NumericUpDown predHeadingMinInf;
        private System.Windows.Forms.NumericUpDown predHeadingMaxAng;
        private System.Windows.Forms.NumericUpDown predHeadingMinAng;
        private System.Windows.Forms.NumericUpDown predHeadingMaxRad;
        private System.Windows.Forms.NumericUpDown predHeadingMinRad;
        private System.Windows.Forms.CheckBox predHeadingEnabled;
        private System.Windows.Forms.NumericUpDown predGroupingMaxInf;
        private System.Windows.Forms.NumericUpDown predGroupingMinInf;
        private System.Windows.Forms.NumericUpDown predGroupingMaxAng;
        private System.Windows.Forms.NumericUpDown predGroupingMinAng;
        private System.Windows.Forms.NumericUpDown predGroupingMaxRad;
        private System.Windows.Forms.NumericUpDown predGroupingMinRad;
        private System.Windows.Forms.CheckBox predGroupingEnabled;
        private System.Windows.Forms.Label labelPredMaxInf;
        private System.Windows.Forms.NumericUpDown predAvoidanceMaxInf;
        private System.Windows.Forms.Label labelPredMinInf;
        private System.Windows.Forms.NumericUpDown predAvoidanceMinInf;
        private System.Windows.Forms.Label labelPredMaxAng;
        private System.Windows.Forms.NumericUpDown predAvoidanceMaxAng;
        private System.Windows.Forms.Label labelPredMinAng;
        private System.Windows.Forms.NumericUpDown predAvoidanceMinAng;
        private System.Windows.Forms.Label labelPredMaxRad;
        private System.Windows.Forms.NumericUpDown predAvoidanceMaxRad;
        private System.Windows.Forms.Label labelPredMinRad;
        private System.Windows.Forms.NumericUpDown predAvoidanceMinRad;
        private System.Windows.Forms.CheckBox predAvoidanceEnabled;
        private System.Windows.Forms.Label predBehaviourLabel;
        private System.Windows.Forms.Label predOptionsLabel;
        private System.Windows.Forms.Panel predOptions;
        private System.Windows.Forms.Label labelPredSpawnRad;
        private System.Windows.Forms.NumericUpDown predMaxSpawnRad;
        private System.Windows.Forms.NumericUpDown predMinSpawnRad;
        private System.Windows.Forms.Label labelPredMass;
        private System.Windows.Forms.Label labelPredSize;
        private System.Windows.Forms.Label labelPredStartVel;
        private System.Windows.Forms.Label labelPredAccel;
        private System.Windows.Forms.NumericUpDown predMaxMass;
        private System.Windows.Forms.NumericUpDown predMinMass;
        private System.Windows.Forms.NumericUpDown predMaxSize;
        private System.Windows.Forms.NumericUpDown predMinSize;
        private System.Windows.Forms.NumericUpDown predMaxVel;
        private System.Windows.Forms.NumericUpDown predMinVel;
        private System.Windows.Forms.Label labelPredOptMax;
        private System.Windows.Forms.NumericUpDown predMaxAccel;
        private System.Windows.Forms.Label labelPredOptMin;
        private System.Windows.Forms.NumericUpDown predMinAccel;
        private System.Windows.Forms.TabPage clientOptions;
        private System.Windows.Forms.Panel clientPerf;
        private System.Windows.Forms.NumericUpDown clientPhysInt;
        private System.Windows.Forms.Label labelClientPhysInt;
        private System.Windows.Forms.Label labelClientPerf;
        private System.Windows.Forms.Panel clientNetwork;
        private System.Windows.Forms.TextBox clientConnectIP;
        private System.Windows.Forms.Label clientConnectPortLabel;
        private System.Windows.Forms.Label clientConnectIPLabel;
        private System.Windows.Forms.Label labelClientNetwork;
        private System.Windows.Forms.CheckBox frameRateLockEnabled;
        private System.Windows.Forms.NumericUpDown frameRateCapAmt;
        private System.Windows.Forms.TextBox clientConnectPort;
        private System.Windows.Forms.CheckBox broadcastEnabled;
        private System.Windows.Forms.Label labelClientPhysIntSec;
        private System.Windows.Forms.Panel serverNetwork;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.Label labelServerPort;
        private System.Windows.Forms.Label labelServerNetwork;
        private System.Windows.Forms.NumericUpDown serverPhysInt;
        private System.Windows.Forms.Label labelServerPhysInt;
        private System.Windows.Forms.Label labelServerPhysIntSec;
    }
}

