namespace Assembly_Simulator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitView = new System.Windows.Forms.SplitContainer();
            this.textBoxAccumulatorHex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteLine = new System.Windows.Forms.Button();
            this.intervalBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.executeWithDebug = new System.Windows.Forms.Button();
            this.executeWithTimer = new System.Windows.Forms.Button();
            this.textBoxOverflow = new System.Windows.Forms.TextBox();
            this.textBoxSign = new System.Windows.Forms.TextBox();
            this.textBoxZero = new System.Windows.Forms.TextBox();
            this.textBoxCarry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAccumulator = new System.Windows.Forms.TextBox();
            this.textBoxProgramCounter = new System.Windows.Forms.TextBox();
            this.clearOutput = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.programView = new System.Windows.Forms.ListView();
            this.columnLabel = new System.Windows.Forms.ColumnHeader();
            this.columnOpcode = new System.Windows.Forms.ColumnHeader();
            this.columnOperand = new System.Windows.Forms.ColumnHeader();
            this.collapseItems = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mainFormTabs = new System.Windows.Forms.TabControl();
            this.tabWrite = new System.Windows.Forms.TabPage();
            this.instructionFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabExecute = new System.Windows.Forms.TabPage();
            this.cpuACCHex = new System.Windows.Forms.TextBox();
            this.cpuCIR2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cpuACC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cpuPC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cpuMAR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stepForward = new System.Windows.Forms.Button();
            this.cpuCIR = new System.Windows.Forms.TextBox();
            this.buttonRemoveRAM = new System.Windows.Forms.Button();
            this.buttonAddRAM = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.RAMView = new System.Windows.Forms.ListView();
            this.columnAddress = new System.Windows.Forms.ColumnHeader();
            this.columnValue = new System.Windows.Forms.ColumnHeader();
            this.ramImage = new System.Windows.Forms.PictureBox();
            this.cpuImage = new System.Windows.Forms.PictureBox();
            this.systemBusPictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.splitView.Panel1.SuspendLayout();
            this.splitView.Panel2.SuspendLayout();
            this.splitView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.mainFormTabs.SuspendLayout();
            this.tabWrite.SuspendLayout();
            this.tabExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemBusPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitView
            // 
            this.splitView.BackColor = System.Drawing.Color.Transparent;
            this.splitView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitView.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitView.IsSplitterFixed = true;
            this.splitView.Location = new System.Drawing.Point(0, 0);
            this.splitView.Name = "splitView";
            // 
            // splitView.Panel1
            // 
            this.splitView.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitView.Panel1.Controls.Add(this.textBoxAccumulatorHex);
            this.splitView.Panel1.Controls.Add(this.label1);
            this.splitView.Panel1.Controls.Add(this.label11);
            this.splitView.Panel1.Controls.Add(this.newButton);
            this.splitView.Panel1.Controls.Add(this.helpButton);
            this.splitView.Panel1.Controls.Add(this.openButton);
            this.splitView.Panel1.Controls.Add(this.aboutButton);
            this.splitView.Panel1.Controls.Add(this.saveButton);
            this.splitView.Panel1.Controls.Add(this.deleteLine);
            this.splitView.Panel1.Controls.Add(this.intervalBox);
            this.splitView.Panel1.Controls.Add(this.label9);
            this.splitView.Panel1.Controls.Add(this.executeWithDebug);
            this.splitView.Panel1.Controls.Add(this.executeWithTimer);
            this.splitView.Panel1.Controls.Add(this.textBoxOverflow);
            this.splitView.Panel1.Controls.Add(this.textBoxSign);
            this.splitView.Panel1.Controls.Add(this.textBoxZero);
            this.splitView.Panel1.Controls.Add(this.textBoxCarry);
            this.splitView.Panel1.Controls.Add(this.label8);
            this.splitView.Panel1.Controls.Add(this.label4);
            this.splitView.Panel1.Controls.Add(this.label3);
            this.splitView.Panel1.Controls.Add(this.label7);
            this.splitView.Panel1.Controls.Add(this.label6);
            this.splitView.Panel1.Controls.Add(this.label5);
            this.splitView.Panel1.Controls.Add(this.textBoxAccumulator);
            this.splitView.Panel1.Controls.Add(this.textBoxProgramCounter);
            this.splitView.Panel1.Controls.Add(this.clearOutput);
            this.splitView.Panel1.Controls.Add(this.outputBox);
            this.splitView.Panel1.Controls.Add(this.programView);
            // 
            // splitView.Panel2
            // 
            this.splitView.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitView.Panel2.Controls.Add(this.collapseItems);
            this.splitView.Panel2.Controls.Add(this.pictureBox1);
            this.splitView.Panel2.Controls.Add(this.pictureBox3);
            this.splitView.Panel2.Controls.Add(this.mainFormTabs);
            this.splitView.Size = new System.Drawing.Size(992, 636);
            this.splitView.SplitterDistance = 329;
            this.splitView.TabIndex = 0;
            // 
            // textBoxAccumulatorHex
            // 
            this.textBoxAccumulatorHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAccumulatorHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAccumulatorHex.Location = new System.Drawing.Point(251, 432);
            this.textBoxAccumulatorHex.Name = "textBoxAccumulatorHex";
            this.textBoxAccumulatorHex.ReadOnly = true;
            this.textBoxAccumulatorHex.Size = new System.Drawing.Size(63, 20);
            this.textBoxAccumulatorHex.TabIndex = 33;
            this.textBoxAccumulatorHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Registers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(12, 550);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 22);
            this.label11.TabIndex = 31;
            this.label11.Text = "Program Output";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.newButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Location = new System.Drawing.Point(12, -1);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(60, 33);
            this.newButton.TabIndex = 30;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Location = new System.Drawing.Point(253, -1);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(60, 33);
            this.helpButton.TabIndex = 29;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.openButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Location = new System.Drawing.Point(130, -1);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(60, 33);
            this.openButton.TabIndex = 28;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Location = new System.Drawing.Point(194, -1);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(60, 33);
            this.aboutButton.TabIndex = 27;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(71, -1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(60, 33);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteLine
            // 
            this.deleteLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteLine.BackColor = System.Drawing.Color.LightSteelBlue;
            this.deleteLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.deleteLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteLine.Location = new System.Drawing.Point(190, 386);
            this.deleteLine.Name = "deleteLine";
            this.deleteLine.Size = new System.Drawing.Size(124, 22);
            this.deleteLine.TabIndex = 25;
            this.deleteLine.Text = "Delete Line";
            this.deleteLine.UseVisualStyleBackColor = false;
            this.deleteLine.Click += new System.EventHandler(this.deleteLine_Click);
            // 
            // intervalBox
            // 
            this.intervalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.intervalBox.FormattingEnabled = true;
            this.intervalBox.Items.AddRange(new object[] {
            "Instant",
            "0.5s",
            "1s",
            "2s",
            "5s"});
            this.intervalBox.Location = new System.Drawing.Point(237, 545);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(76, 21);
            this.intervalBox.TabIndex = 22;
            this.intervalBox.SelectedIndexChanged += new System.EventHandler(this.intervalBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(190, 544);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Interval:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // executeWithDebug
            // 
            this.executeWithDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.executeWithDebug.BackColor = System.Drawing.Color.LightSteelBlue;
            this.executeWithDebug.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.executeWithDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeWithDebug.Location = new System.Drawing.Point(190, 460);
            this.executeWithDebug.Name = "executeWithDebug";
            this.executeWithDebug.Size = new System.Drawing.Size(124, 43);
            this.executeWithDebug.TabIndex = 21;
            this.executeWithDebug.Text = "Debug Program";
            this.executeWithDebug.UseVisualStyleBackColor = false;
            this.executeWithDebug.Click += new System.EventHandler(this.executeWithDebug_Click);
            // 
            // executeWithTimer
            // 
            this.executeWithTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.executeWithTimer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.executeWithTimer.Enabled = false;
            this.executeWithTimer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.executeWithTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeWithTimer.Location = new System.Drawing.Point(190, 502);
            this.executeWithTimer.Name = "executeWithTimer";
            this.executeWithTimer.Size = new System.Drawing.Size(124, 43);
            this.executeWithTimer.TabIndex = 20;
            this.executeWithTimer.Text = "Execute Program";
            this.executeWithTimer.UseVisualStyleBackColor = false;
            this.executeWithTimer.Click += new System.EventHandler(this.executeWithTimer_Click);
            // 
            // textBoxOverflow
            // 
            this.textBoxOverflow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOverflow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOverflow.Location = new System.Drawing.Point(131, 508);
            this.textBoxOverflow.Name = "textBoxOverflow";
            this.textBoxOverflow.ReadOnly = true;
            this.textBoxOverflow.Size = new System.Drawing.Size(38, 20);
            this.textBoxOverflow.TabIndex = 18;
            this.textBoxOverflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOverflow.TextChanged += new System.EventHandler(this.textBox_Register_TextChanged);
            // 
            // textBoxSign
            // 
            this.textBoxSign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSign.Location = new System.Drawing.Point(131, 489);
            this.textBoxSign.Name = "textBoxSign";
            this.textBoxSign.ReadOnly = true;
            this.textBoxSign.Size = new System.Drawing.Size(38, 20);
            this.textBoxSign.TabIndex = 17;
            this.textBoxSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSign.TextChanged += new System.EventHandler(this.textBox_Register_TextChanged);
            // 
            // textBoxZero
            // 
            this.textBoxZero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxZero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxZero.Location = new System.Drawing.Point(131, 470);
            this.textBoxZero.Name = "textBoxZero";
            this.textBoxZero.ReadOnly = true;
            this.textBoxZero.Size = new System.Drawing.Size(38, 20);
            this.textBoxZero.TabIndex = 16;
            this.textBoxZero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxZero.TextChanged += new System.EventHandler(this.textBox_Register_TextChanged);
            // 
            // textBoxCarry
            // 
            this.textBoxCarry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCarry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCarry.Location = new System.Drawing.Point(131, 451);
            this.textBoxCarry.Name = "textBoxCarry";
            this.textBoxCarry.ReadOnly = true;
            this.textBoxCarry.Size = new System.Drawing.Size(38, 20);
            this.textBoxCarry.TabIndex = 15;
            this.textBoxCarry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCarry.TextChanged += new System.EventHandler(this.textBox_Register_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(12, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Overflow Flag";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(12, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Negative Sign Flag";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(12, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Zero Flag";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(190, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Accumulator";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(12, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Program Counter";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(12, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Carry Flag";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAccumulator
            // 
            this.textBoxAccumulator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAccumulator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAccumulator.Location = new System.Drawing.Point(190, 432);
            this.textBoxAccumulator.Name = "textBoxAccumulator";
            this.textBoxAccumulator.ReadOnly = true;
            this.textBoxAccumulator.Size = new System.Drawing.Size(62, 20);
            this.textBoxAccumulator.TabIndex = 8;
            this.textBoxAccumulator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxProgramCounter
            // 
            this.textBoxProgramCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProgramCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProgramCounter.Location = new System.Drawing.Point(131, 432);
            this.textBoxProgramCounter.Name = "textBoxProgramCounter";
            this.textBoxProgramCounter.ReadOnly = true;
            this.textBoxProgramCounter.Size = new System.Drawing.Size(38, 20);
            this.textBoxProgramCounter.TabIndex = 7;
            this.textBoxProgramCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearOutput
            // 
            this.clearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.clearOutput.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clearOutput.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.clearOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearOutput.Location = new System.Drawing.Point(260, 571);
            this.clearOutput.Name = "clearOutput";
            this.clearOutput.Size = new System.Drawing.Size(54, 49);
            this.clearOutput.TabIndex = 3;
            this.clearOutput.Text = "Clear";
            this.clearOutput.UseVisualStyleBackColor = false;
            this.clearOutput.Click += new System.EventHandler(this.clearOutput_Click);
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(12, 571);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(249, 49);
            this.outputBox.TabIndex = 1;
            // 
            // programView
            // 
            this.programView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.programView.AutoArrange = false;
            this.programView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.programView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnLabel,
            this.columnOpcode,
            this.columnOperand});
            this.programView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programView.FullRowSelect = true;
            this.programView.GridLines = true;
            this.programView.HideSelection = false;
            this.programView.Location = new System.Drawing.Point(12, 39);
            this.programView.MultiSelect = false;
            this.programView.Name = "programView";
            this.programView.Size = new System.Drawing.Size(302, 348);
            this.programView.TabIndex = 0;
            this.programView.UseCompatibleStateImageBehavior = false;
            this.programView.View = System.Windows.Forms.View.Details;
            // 
            // columnLabel
            // 
            this.columnLabel.Text = "Label";
            this.columnLabel.Width = 114;
            // 
            // columnOpcode
            // 
            this.columnOpcode.Text = "OPCODE";
            this.columnOpcode.Width = 77;
            // 
            // columnOperand
            // 
            this.columnOperand.Text = "OPERAND";
            this.columnOperand.Width = 88;
            // 
            // collapseItems
            // 
            this.collapseItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.collapseItems.BackColor = System.Drawing.Color.LightSteelBlue;
            this.collapseItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapseItems.Location = new System.Drawing.Point(563, 613);
            this.collapseItems.Name = "collapseItems";
            this.collapseItems.Size = new System.Drawing.Size(75, 24);
            this.collapseItems.TabIndex = 5;
            this.collapseItems.Text = "Collapse All";
            this.collapseItems.UseVisualStyleBackColor = false;
            this.collapseItems.Click += new System.EventHandler(this.collapseItems_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 614);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 2);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(638, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2, 620);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // mainFormTabs
            // 
            this.mainFormTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFormTabs.Controls.Add(this.tabWrite);
            this.mainFormTabs.Controls.Add(this.tabExecute);
            this.mainFormTabs.ItemSize = new System.Drawing.Size(60, 20);
            this.mainFormTabs.Location = new System.Drawing.Point(13, 12);
            this.mainFormTabs.Multiline = true;
            this.mainFormTabs.Name = "mainFormTabs";
            this.mainFormTabs.SelectedIndex = 0;
            this.mainFormTabs.Size = new System.Drawing.Size(627, 604);
            this.mainFormTabs.TabIndex = 0;
            this.mainFormTabs.SelectedIndexChanged += new System.EventHandler(this.mainFormTabs_SelectedIndexChanged);
            // 
            // tabWrite
            // 
            this.tabWrite.BackColor = System.Drawing.SystemColors.Window;
            this.tabWrite.Controls.Add(this.instructionFlowPanel);
            this.tabWrite.Location = new System.Drawing.Point(4, 24);
            this.tabWrite.Name = "tabWrite";
            this.tabWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tabWrite.Size = new System.Drawing.Size(619, 576);
            this.tabWrite.TabIndex = 0;
            this.tabWrite.Text = "Write Program";
            // 
            // instructionFlowPanel
            // 
            this.instructionFlowPanel.AutoScroll = true;
            this.instructionFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.instructionFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instructionFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.instructionFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.instructionFlowPanel.Name = "instructionFlowPanel";
            this.instructionFlowPanel.Size = new System.Drawing.Size(613, 570);
            this.instructionFlowPanel.TabIndex = 0;
            // 
            // tabExecute
            // 
            this.tabExecute.BackColor = System.Drawing.SystemColors.Window;
            this.tabExecute.Controls.Add(this.cpuACCHex);
            this.tabExecute.Controls.Add(this.cpuCIR2);
            this.tabExecute.Controls.Add(this.label14);
            this.tabExecute.Controls.Add(this.cpuACC);
            this.tabExecute.Controls.Add(this.label13);
            this.tabExecute.Controls.Add(this.cpuPC);
            this.tabExecute.Controls.Add(this.label12);
            this.tabExecute.Controls.Add(this.cpuMAR);
            this.tabExecute.Controls.Add(this.label2);
            this.tabExecute.Controls.Add(this.stepForward);
            this.tabExecute.Controls.Add(this.cpuCIR);
            this.tabExecute.Controls.Add(this.buttonRemoveRAM);
            this.tabExecute.Controls.Add(this.buttonAddRAM);
            this.tabExecute.Controls.Add(this.label10);
            this.tabExecute.Controls.Add(this.RAMView);
            this.tabExecute.Controls.Add(this.ramImage);
            this.tabExecute.Controls.Add(this.cpuImage);
            this.tabExecute.Controls.Add(this.systemBusPictureBox);
            this.tabExecute.Location = new System.Drawing.Point(4, 24);
            this.tabExecute.Name = "tabExecute";
            this.tabExecute.Padding = new System.Windows.Forms.Padding(3);
            this.tabExecute.Size = new System.Drawing.Size(619, 560);
            this.tabExecute.TabIndex = 1;
            this.tabExecute.Text = "Execute Program";
            // 
            // cpuACCHex
            // 
            this.cpuACCHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuACCHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuACCHex.Location = new System.Drawing.Point(131, 224);
            this.cpuACCHex.Name = "cpuACCHex";
            this.cpuACCHex.ReadOnly = true;
            this.cpuACCHex.Size = new System.Drawing.Size(126, 31);
            this.cpuACCHex.TabIndex = 43;
            this.cpuACCHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cpuCIR2
            // 
            this.cpuCIR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuCIR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuCIR2.Location = new System.Drawing.Point(131, 122);
            this.cpuCIR2.Name = "cpuCIR2";
            this.cpuCIR2.ReadOnly = true;
            this.cpuCIR2.Size = new System.Drawing.Size(126, 31);
            this.cpuCIR2.TabIndex = 42;
            this.cpuCIR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(73, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 31);
            this.label14.TabIndex = 40;
            this.label14.Text = "ACC";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuACC
            // 
            this.cpuACC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuACC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuACC.Location = new System.Drawing.Point(131, 194);
            this.cpuACC.Name = "cpuACC";
            this.cpuACC.ReadOnly = true;
            this.cpuACC.Size = new System.Drawing.Size(126, 31);
            this.cpuACC.TabIndex = 39;
            this.cpuACC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(73, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 31);
            this.label13.TabIndex = 38;
            this.label13.Text = "PC";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuPC
            // 
            this.cpuPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuPC.Location = new System.Drawing.Point(131, 160);
            this.cpuPC.Name = "cpuPC";
            this.cpuPC.ReadOnly = true;
            this.cpuPC.Size = new System.Drawing.Size(126, 31);
            this.cpuPC.TabIndex = 37;
            this.cpuPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(73, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 31);
            this.label12.TabIndex = 36;
            this.label12.Text = "MAR";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuMAR
            // 
            this.cpuMAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuMAR.Location = new System.Drawing.Point(131, 272);
            this.cpuMAR.Name = "cpuMAR";
            this.cpuMAR.ReadOnly = true;
            this.cpuMAR.Size = new System.Drawing.Size(126, 31);
            this.cpuMAR.TabIndex = 35;
            this.cpuMAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "CIR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stepForward
            // 
            this.stepForward.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stepForward.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.stepForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stepForward.Location = new System.Drawing.Point(19, 494);
            this.stepForward.Name = "stepForward";
            this.stepForward.Size = new System.Drawing.Size(113, 49);
            this.stepForward.TabIndex = 26;
            this.stepForward.Text = "Step Forward";
            this.stepForward.UseVisualStyleBackColor = false;
            this.stepForward.Click += new System.EventHandler(this.stepForward_Click);
            // 
            // cpuCIR
            // 
            this.cpuCIR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuCIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuCIR.Location = new System.Drawing.Point(131, 92);
            this.cpuCIR.Name = "cpuCIR";
            this.cpuCIR.ReadOnly = true;
            this.cpuCIR.Size = new System.Drawing.Size(126, 31);
            this.cpuCIR.TabIndex = 33;
            this.cpuCIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRemoveRAM
            // 
            this.buttonRemoveRAM.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveRAM.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.buttonRemoveRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveRAM.Location = new System.Drawing.Point(506, 489);
            this.buttonRemoveRAM.Name = "buttonRemoveRAM";
            this.buttonRemoveRAM.Size = new System.Drawing.Size(37, 23);
            this.buttonRemoveRAM.TabIndex = 25;
            this.buttonRemoveRAM.Text = "-";
            this.buttonRemoveRAM.UseVisualStyleBackColor = false;
            this.buttonRemoveRAM.Click += new System.EventHandler(this.buttonRemoveRAM_Click);
            // 
            // buttonAddRAM
            // 
            this.buttonAddRAM.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddRAM.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRAM.Location = new System.Drawing.Point(542, 489);
            this.buttonAddRAM.Name = "buttonAddRAM";
            this.buttonAddRAM.Size = new System.Drawing.Size(37, 23);
            this.buttonAddRAM.TabIndex = 24;
            this.buttonAddRAM.Text = "+";
            this.buttonAddRAM.UseVisualStyleBackColor = false;
            this.buttonAddRAM.Click += new System.EventHandler(this.buttonAddRAM_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(401, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Add/Remove RAM";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RAMView
            // 
            this.RAMView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RAMView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAddress,
            this.columnValue});
            this.RAMView.GridLines = true;
            this.RAMView.Location = new System.Drawing.Point(401, 55);
            this.RAMView.Name = "RAMView";
            this.RAMView.Size = new System.Drawing.Size(178, 435);
            this.RAMView.TabIndex = 2;
            this.RAMView.UseCompatibleStateImageBehavior = false;
            this.RAMView.View = System.Windows.Forms.View.Details;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Address";
            this.columnAddress.Width = 55;
            // 
            // columnValue
            // 
            this.columnValue.Text = "Value";
            this.columnValue.Width = 98;
            // 
            // ramImage
            // 
            this.ramImage.BackColor = System.Drawing.Color.Transparent;
            this.ramImage.Image = ((System.Drawing.Image)(resources.GetObject("ramImage.Image")));
            this.ramImage.Location = new System.Drawing.Point(365, 9);
            this.ramImage.Name = "ramImage";
            this.ramImage.Size = new System.Drawing.Size(237, 537);
            this.ramImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ramImage.TabIndex = 1;
            this.ramImage.TabStop = false;
            // 
            // cpuImage
            // 
            this.cpuImage.BackColor = System.Drawing.Color.Transparent;
            this.cpuImage.Image = ((System.Drawing.Image)(resources.GetObject("cpuImage.Image")));
            this.cpuImage.Location = new System.Drawing.Point(19, 17);
            this.cpuImage.Name = "cpuImage";
            this.cpuImage.Size = new System.Drawing.Size(293, 310);
            this.cpuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpuImage.TabIndex = 0;
            this.cpuImage.TabStop = false;
            // 
            // systemBusPictureBox
            // 
            this.systemBusPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("systemBusPictureBox.BackgroundImage")));
            this.systemBusPictureBox.Location = new System.Drawing.Point(10, 8);
            this.systemBusPictureBox.Name = "systemBusPictureBox";
            this.systemBusPictureBox.Size = new System.Drawing.Size(600, 539);
            this.systemBusPictureBox.TabIndex = 41;
            this.systemBusPictureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(992, 636);
            this.Controls.Add(this.splitView);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assembly Simulator";
            this.splitView.Panel1.ResumeLayout(false);
            this.splitView.Panel1.PerformLayout();
            this.splitView.Panel2.ResumeLayout(false);
            this.splitView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.mainFormTabs.ResumeLayout(false);
            this.tabWrite.ResumeLayout(false);
            this.tabExecute.ResumeLayout(false);
            this.tabExecute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemBusPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitView;
        private System.Windows.Forms.ListView programView;
        private System.Windows.Forms.ColumnHeader columnLabel;
        private System.Windows.Forms.ColumnHeader columnOpcode;
        private System.Windows.Forms.ColumnHeader columnOperand;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button clearOutput;
        private System.Windows.Forms.TextBox textBoxAccumulator;
        private System.Windows.Forms.TextBox textBoxProgramCounter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCarry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOverflow;
        private System.Windows.Forms.TextBox textBoxSign;
        private System.Windows.Forms.TextBox textBoxZero;
        private System.Windows.Forms.TabControl mainFormTabs;
        private System.Windows.Forms.TabPage tabWrite;
        private System.Windows.Forms.TabPage tabExecute;
        private System.Windows.Forms.Button executeWithDebug;
        private System.Windows.Forms.Button executeWithTimer;
        private System.Windows.Forms.ComboBox intervalBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox ramImage;
        private System.Windows.Forms.PictureBox cpuImage;
        private System.Windows.Forms.ListView RAMView;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ColumnHeader columnValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonRemoveRAM;
        private System.Windows.Forms.Button buttonAddRAM;
        private System.Windows.Forms.Button stepForward;
        private System.Windows.Forms.FlowLayoutPanel instructionFlowPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button deleteLine;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cpuMAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cpuCIR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cpuACC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cpuPC;
        private System.Windows.Forms.PictureBox systemBusPictureBox;
        private System.Windows.Forms.TextBox cpuCIR2;
        private System.Windows.Forms.TextBox textBoxAccumulatorHex;
        private System.Windows.Forms.TextBox cpuACCHex;
        private System.Windows.Forms.Button collapseItems;
    }
}

