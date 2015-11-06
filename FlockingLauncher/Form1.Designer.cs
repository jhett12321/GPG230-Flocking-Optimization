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
            this.loadButton = new System.Windows.Forms.Button();
            this.optionTabs = new System.Windows.Forms.TabControl();
            this.commonOptions = new System.Windows.Forms.TabPage();
            this.separator1 = new System.Windows.Forms.Label();
            this.localOptions = new System.Windows.Forms.TabPage();
            this.generalAgentOptions = new System.Windows.Forms.Panel();
            this.checkBoxRndSpawn = new System.Windows.Forms.CheckBox();
            this.agentRatioValue = new System.Windows.Forms.Label();
            this.labelAgentRatio = new System.Windows.Forms.Label();
            this.totalAgents = new System.Windows.Forms.NumericUpDown();
            this.labelTotalAgents = new System.Windows.Forms.Label();
            this.agentRatio = new System.Windows.Forms.TrackBar();
            this.agentControlHeading = new System.Windows.Forms.Label();
            this.serverOptions = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startLocal = new System.Windows.Forms.Button();
            this.startNetworkClient = new System.Windows.Forms.Button();
            this.startNetworkServer = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.optionTabs.SuspendLayout();
            this.commonOptions.SuspendLayout();
            this.localOptions.SuspendLayout();
            this.generalAgentOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalAgents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentRatio)).BeginInit();
            this.serverOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(76, 24);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(94, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(76, 24);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load...";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // optionTabs
            // 
            this.optionTabs.Controls.Add(this.commonOptions);
            this.optionTabs.Controls.Add(this.localOptions);
            this.optionTabs.Controls.Add(this.serverOptions);
            this.optionTabs.Location = new System.Drawing.Point(12, 70);
            this.optionTabs.Name = "optionTabs";
            this.optionTabs.SelectedIndex = 0;
            this.optionTabs.Size = new System.Drawing.Size(1136, 657);
            this.optionTabs.TabIndex = 2;
            // 
            // commonOptions
            // 
            this.commonOptions.Controls.Add(this.separator1);
            this.commonOptions.Location = new System.Drawing.Point(4, 22);
            this.commonOptions.Name = "commonOptions";
            this.commonOptions.Padding = new System.Windows.Forms.Padding(3);
            this.commonOptions.Size = new System.Drawing.Size(1128, 631);
            this.commonOptions.TabIndex = 0;
            this.commonOptions.Text = "Common Options";
            this.commonOptions.UseVisualStyleBackColor = true;
            // 
            // separator1
            // 
            this.separator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator1.Location = new System.Drawing.Point(6, 344);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(1116, 2);
            this.separator1.TabIndex = 0;
            // 
            // localOptions
            // 
            this.localOptions.Controls.Add(this.generalAgentOptions);
            this.localOptions.Controls.Add(this.agentControlHeading);
            this.localOptions.Location = new System.Drawing.Point(4, 22);
            this.localOptions.Name = "localOptions";
            this.localOptions.Padding = new System.Windows.Forms.Padding(3);
            this.localOptions.Size = new System.Drawing.Size(1128, 631);
            this.localOptions.TabIndex = 1;
            this.localOptions.Text = "Local Options";
            this.localOptions.UseVisualStyleBackColor = true;
            // 
            // generalAgentOptions
            // 
            this.generalAgentOptions.BackColor = System.Drawing.Color.Transparent;
            this.generalAgentOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.generalAgentOptions.Controls.Add(this.checkBoxRndSpawn);
            this.generalAgentOptions.Controls.Add(this.agentRatioValue);
            this.generalAgentOptions.Controls.Add(this.labelAgentRatio);
            this.generalAgentOptions.Controls.Add(this.totalAgents);
            this.generalAgentOptions.Controls.Add(this.labelTotalAgents);
            this.generalAgentOptions.Controls.Add(this.agentRatio);
            this.generalAgentOptions.Location = new System.Drawing.Point(18, 32);
            this.generalAgentOptions.Name = "generalAgentOptions";
            this.generalAgentOptions.Size = new System.Drawing.Size(1090, 221);
            this.generalAgentOptions.TabIndex = 5;
            // 
            // checkBoxRndSpawn
            // 
            this.checkBoxRndSpawn.AutoSize = true;
            this.checkBoxRndSpawn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRndSpawn.Location = new System.Drawing.Point(9, 80);
            this.checkBoxRndSpawn.Name = "checkBoxRndSpawn";
            this.checkBoxRndSpawn.Size = new System.Drawing.Size(102, 17);
            this.checkBoxRndSpawn.TabIndex = 6;
            this.checkBoxRndSpawn.Text = "Random Spawn";
            this.toolTip.SetToolTip(this.checkBoxRndSpawn, "Spawns Agents at a random position in the world.");
            this.checkBoxRndSpawn.UseVisualStyleBackColor = true;
            // 
            // agentRatioValue
            // 
            this.agentRatioValue.AutoSize = true;
            this.agentRatioValue.Location = new System.Drawing.Point(327, 12);
            this.agentRatioValue.Name = "agentRatioValue";
            this.agentRatioValue.Size = new System.Drawing.Size(44, 13);
            this.agentRatioValue.TabIndex = 5;
            this.agentRatioValue.Text = "UNSET";
            this.agentRatioValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.totalAgents.Name = "totalAgents";
            this.totalAgents.Size = new System.Drawing.Size(120, 20);
            this.totalAgents.TabIndex = 3;
            this.totalAgents.ThousandsSeparator = true;
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
            this.agentRatio.Value = 3;
            this.agentRatio.ValueChanged += new System.EventHandler(this.agentRatio_ValueChanged);
            // 
            // agentControlHeading
            // 
            this.agentControlHeading.AutoSize = true;
            this.agentControlHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentControlHeading.Location = new System.Drawing.Point(15, 13);
            this.agentControlHeading.Name = "agentControlHeading";
            this.agentControlHeading.Size = new System.Drawing.Size(114, 13);
            this.agentControlHeading.TabIndex = 4;
            this.agentControlHeading.Text = "General Agent Options";
            // 
            // serverOptions
            // 
            this.serverOptions.Controls.Add(this.panel1);
            this.serverOptions.Controls.Add(this.label3);
            this.serverOptions.Controls.Add(this.panel2);
            this.serverOptions.Controls.Add(this.label7);
            this.serverOptions.Controls.Add(this.label5);
            this.serverOptions.Location = new System.Drawing.Point(4, 22);
            this.serverOptions.Name = "serverOptions";
            this.serverOptions.Size = new System.Drawing.Size(1128, 631);
            this.serverOptions.TabIndex = 2;
            this.serverOptions.Text = "Server Options";
            this.serverOptions.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 91);
            this.panel1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown1.Location = new System.Drawing.Point(138, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agent Ratio";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown4.Location = new System.Drawing.Point(138, 8);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 3;
            this.numericUpDown4.ThousandsSeparator = true;
            this.numericUpDown4.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Draw Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Performance";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numericUpDown3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(18, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 91);
            this.panel2.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown2.Location = new System.Drawing.Point(138, 43);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.ThousandsSeparator = true;
            this.numericUpDown2.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max Clients";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown3.Location = new System.Drawing.Point(138, 8);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 3;
            this.numericUpDown3.ThousandsSeparator = true;
            this.numericUpDown3.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Max Agents Per Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Limits";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1116, 2);
            this.label5.TabIndex = 4;
            // 
            // startLocal
            // 
            this.startLocal.Location = new System.Drawing.Point(742, 12);
            this.startLocal.Name = "startLocal";
            this.startLocal.Size = new System.Drawing.Size(200, 23);
            this.startLocal.TabIndex = 3;
            this.startLocal.Text = "Start Local";
            this.startLocal.UseVisualStyleBackColor = true;
            this.startLocal.Click += new System.EventHandler(this.startLocal_Click);
            // 
            // startNetworkClient
            // 
            this.startNetworkClient.Location = new System.Drawing.Point(948, 12);
            this.startNetworkClient.Name = "startNetworkClient";
            this.startNetworkClient.Size = new System.Drawing.Size(200, 23);
            this.startNetworkClient.TabIndex = 4;
            this.startNetworkClient.Text = "Start Network Client";
            this.startNetworkClient.UseVisualStyleBackColor = true;
            // 
            // startNetworkServer
            // 
            this.startNetworkServer.Location = new System.Drawing.Point(948, 41);
            this.startNetworkServer.Name = "startNetworkServer";
            this.startNetworkServer.Size = new System.Drawing.Size(200, 23);
            this.startNetworkServer.TabIndex = 5;
            this.startNetworkServer.Text = "Start Network Server";
            this.startNetworkServer.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 739);
            this.Controls.Add(this.startNetworkServer);
            this.Controls.Add(this.startNetworkClient);
            this.Controls.Add(this.startLocal);
            this.Controls.Add(this.optionTabs);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Name = "mainForm";
            this.Text = "Flocking Sim Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.optionTabs.ResumeLayout(false);
            this.commonOptions.ResumeLayout(false);
            this.localOptions.ResumeLayout(false);
            this.localOptions.PerformLayout();
            this.generalAgentOptions.ResumeLayout(false);
            this.generalAgentOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalAgents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentRatio)).EndInit();
            this.serverOptions.ResumeLayout(false);
            this.serverOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TabControl optionTabs;
        private System.Windows.Forms.TabPage commonOptions;
        private System.Windows.Forms.TabPage localOptions;
        private System.Windows.Forms.TabPage serverOptions;
        private System.Windows.Forms.Button startLocal;
        private System.Windows.Forms.Button startNetworkClient;
        private System.Windows.Forms.Button startNetworkServer;
        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel generalAgentOptions;
        private System.Windows.Forms.CheckBox checkBoxRndSpawn;
        private System.Windows.Forms.Label agentRatioValue;
        private System.Windows.Forms.Label labelAgentRatio;
        private System.Windows.Forms.NumericUpDown totalAgents;
        private System.Windows.Forms.Label labelTotalAgents;
        private System.Windows.Forms.TrackBar agentRatio;
        private System.Windows.Forms.Label agentControlHeading;
    }
}

