using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace Assembly_Simulator
{
    public partial class Main : Form
    {

        // Globals and Initialisation
        /* ------------------------------------------------------------------------------- */
        #region Globals and Initialisation
        private List<ProgramInstruction> instructions = new List<ProgramInstruction>();
        bool RAM_OutOfDate;
        CPU processor;

        public Main()
        {
            InitializeComponent();

            // Do setup here
            addRAM(10);
            processor = new CPU(this);
            updateProcessorValues();

            // Get the array of Instructions from the XML Parser
            try
            {
                XMLInstructionParser parser = new XMLInstructionParser("InstructionList.dat");

                string[,] opcodes = parser.GetInstructions();


                for (int i = 0; i < (opcodes.Length / 4); i++)
                {
                    InstructionView newInstruction
                        = new InstructionView(
                            opcodes[i, 0],
                            opcodes[i, 1],
                            opcodes[i, 2],
                            Convert.ToInt32(opcodes[i, 3]),
                            this);
                    instructionFlowPanel.Controls.Add(newInstruction);
                }
                RAM_OutOfDate = false;
            }
            catch
            {
                MessageBox.Show("Could not find application resource Instructions.dat",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }

            // For user experience
            intervalBox.SelectedIndex = 0;
            InstructionView iv = (InstructionView)instructionFlowPanel.Controls[0];
            EventArgs e = new EventArgs();
            iv.nameLabel_Click(this, e);
        }
        #endregion

        // Program Execution Handling
        /* ------------------------------------------------------------------------------- */
        #region Program Execution Handling
        // Prepare for and start execution with the timer controlling execution
        private void executeWithTimer_Click(object sender, EventArgs e)
        {
            // Check to see a program has been written
            if (programView.Items.Count > 0)
            {
                // There is a program, start running it
                mainFormTabs.SelectTab(tabExecute);
                timer.Start();

                // Start the program running
                processor.reset("all");
                updateProcessorValues();
                programView.SelectedIndices.Clear();
                programView.SelectedIndices.Add(0);
                executeWithTimer.Enabled = false;
                timer.Start();
            }
            else
            {
                // No program, show an error
                MessageBox.Show(
                    "You have not written a program to run yet. "
                    + "Use the boxes on the left hand side to write a program and then execute it.",
                    "No Program to Run");
            }
        }

        // Program Execution Method
        private void timer_Tick(object sender, EventArgs e)
        {

            // Check to see if last tick and stop if necessary
            if (i(textBoxProgramCounter.Text) != instructions.Count)
            {
                programView.SelectedItems.Clear();
                programView.Items[i(textBoxProgramCounter.Text)].Selected = true;
                ProgramInstruction x = instructions[i(textBoxProgramCounter.Text)];
                processor.Process(
                    x.label,
                    x.opcode,
                    x.operand);


                updateProcessorValues();
                updateCPUDiagramValues();
            }
            else
            {
                // Execution complete
                timer.Stop();
                MessageBox.Show("Program execution complete");
                executeWithTimer.Enabled = true;
            }
        }

        // Stops program execution and displays an error message. Called by CPU on bad instructions or args
        public void stopOnError()
        {
            timer.Stop();
            processor.reset("all");
            MessageBox.Show(
                "Due to errors in the program instructions, the program could not continue. "
                + "Please consult the documentation for help or seek help on writing assembly "
                + "language programs from a teacher or the internet.",
                "Program Execution Ended",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            executeWithTimer.Enabled = true;
            mainFormTabs.SelectedTab = tabWrite;
        }
        #endregion

        // User Interface Code
        /* ------------------------------------------------------------------------------- */
        #region User Interface Code

        // Clears the program output text field
        private void clearOutput_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
        }

        // Sets the colour of the text to red if 1 or green if 0
        private void textBox_Register_TextChanged(object sender, EventArgs e)
        {
            // Create a new control and cast the sender to it
            System.Windows.Forms.Control control;
            control = (Control)sender;

            if (control.Text == "1")
                control.BackColor = Color.Red;
            else
                control.BackColor = Color.GreenYellow;
        }

        // Switch to the execute tab and highlight the START button?
        private void executeWithDebug_Click(object sender, EventArgs e)
        {
            mainFormTabs.SelectTab(tabExecute);
            // CHANGED: the start/step button is now highlighted
            stepForward.Select();
        }

        // Enable/Disable the eecute button and change the timer interval as necessary
        private void intervalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (intervalBox.Text == "")
                executeWithTimer.Enabled = false;
            else
                executeWithTimer.Enabled = true;

            switch (intervalBox.Text)
            {
                case "Instant":
                    timer.Interval = 1;
                    break;

                case "0.5s":
                    timer.Interval = 500;
                    break;

                case "1s":
                    timer.Interval = 1000;
                    break;

                case "2s":
                    timer.Interval = 2000;
                    break;

                case "5s":
                    timer.Interval = 5000;
                    break;
            }
        }

        // Triggers addRAM from button click
        private void buttonAddRAM_Click(object sender, EventArgs e)
        {
            addRAM(1);
        }

        // Update the list view on the control
        private void updateProgramView()
        {
            // Reset the view
            programView.Items.Clear();

            // Loop through intructions and add items to programView
            foreach (ProgramInstruction x in instructions)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = x.label;
                item.SubItems.Add(x.opcode);
                item.SubItems.Add(x.operand);
                programView.Items.Add(item);
            }
        }

        // Load the program instructions into the RAM view
        private void mainFormTabs_SelectedIndexChanged(object x, EventArgs e)
        {
            // Update the debug view based on whether the ram is out of date or not
            TabControl sender =(TabControl)x;
            if (sender.SelectedTab == tabExecute)
            {
                Debug.WriteLine("Execute tab selected");

                if (RAM_OutOfDate)
                {
                    // Clear the RAM, update with instructions then add new ram addresses
                    RAMView.Items.Clear();


                    foreach (ProgramInstruction p in instructions)
                    {
                        ListViewItem ramItem;
                        int count = RAMView.Items.Count;
                        ramItem = this.RAMView.Items.Add(count.ToString());
                        ListViewItem.ListViewSubItem RAMValue = new ListViewItem.ListViewSubItem();
                        ramItem.SubItems.Add(RAMValue);
                        string y = p.hexOpcode() + p.cleanOperand();
                        ramItem.SubItems[1].Text = y;
                        ramItem.ForeColor = Color.Red;
                    }

                    // Add some RAM for use in the program
                    addRAM(10);
                }
            }

        }

        // Update form labels based on processor registers etc...
        private void updateProcessorValues()
        {
            textBoxProgramCounter.Text = processor.programCounter;
            textBoxAccumulator.Text = processor.accumulator;
            textBoxAccumulatorHex.Text = "0x" + Convert.ToInt32(processor.accumulator).ToString("X");

            textBoxCarry.Text = Convert.ToInt32(processor.carryFlag).ToString();
            textBoxZero.Text = Convert.ToInt32(processor.zeroFlag).ToString();
            textBoxSign.Text = Convert.ToInt32(processor.negativeSignFlag).ToString();
            textBoxOverflow.Text = Convert.ToInt32(processor.overflowFlag).ToString();
        }

        // Update labels on the CPU diagram
        private void updateCPUDiagramValues()
        {
            // CPU Diagram values
            cpuACC.Text = processor.accumulator;
            cpuACCHex.Text = "0x" + Convert.ToInt32(processor.accumulator).ToString("X");
            cpuMAR.Text = cpuPC.Text;
            cpuPC.Text = textBoxProgramCounter.Text;
            try
            {
                string ci;
                ci = getValueForRAMIndex(Convert.ToInt32(cpuPC.Text) - 1);
                cpuCIR.Text = ci;
                ci = ci.Replace(ci.Substring(0, 2), "");
                ci = ci.Insert(0, "#");
                cpuCIR2.Text = denaryToBinary(processor.getOperandValue(ci));
            }
            catch
            {

            }
        }

        // Display an about box
        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        // Display a help window
        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help not yet implemented");
        }

        // Clear the data
        private void newButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the current program and start a new one? All unsaved work will be lost.",
                "Delete Unsaved Work",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Delete all data
                instructions.Clear();
                updateProgramView();
                RAM_OutOfDate = true;
                processor.reset("all");
                updateProcessorValues();
                mainFormTabs.SelectTab(tabExecute);
                updateCPUDiagramValues();
            }
        }

        #endregion

        // Instruction Set-Up Logic
        /* ------------------------------------------------------------------------------- */
        #region Instruction Set-Up Logic
        // Adds x number of memory addresses
        public int addRAM(int x)
        {
            for (int i = 0; i < x; i++)
            {
                // Create a list item, add a subitem and set the properties
                ListViewItem ramItem;
                int count = RAMView.Items.Count;
                ramItem = this.RAMView.Items.Add(count.ToString());
                ListViewItem.ListViewSubItem RAMValue = new ListViewItem.ListViewSubItem();
                ramItem.SubItems.Add(RAMValue);
                ramItem.SubItems[1].Text = "0";
                ramItem.ForeColor = Color.Green;
            }

            // return address for last item
            return RAMView.Items.Count - 1;
        }

        // Removes the RAM address that is last in the list
        private void buttonRemoveRAM_Click(object sender, EventArgs e)
        {
            if (RAMView.Items.Count >= 2)
            {
                RAMView.Items.RemoveAt(RAMView.Items.Count - 1);
            }
        }

        // Adds an instruction passed from an instruction view and updates the view
        public void addInstruction(string label, string opcode, string operand, int position)
        {
            // Add instruction to the instruction list
            ProgramInstruction x = new ProgramInstruction(label, opcode, operand);


            switch (position)
            {
                case 1:
                    // Add before currently selected instruction
                    if (programView.SelectedIndices.Count > 0)
                    {
                        if ((programView.SelectedIndices[0]) >= 0)
                        {
                            instructions.Insert(programView.SelectedIndices[0], x);
                        }
                        else
                        {
                            MessageBox.Show("Could not add instruction at that place. Check it is possible");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not add instruction at that place. Check it is possible");
                    }
                    break;

                case 2:
                    // Add after currently selected instruction
                    if (programView.SelectedIndices.Count > 0)
                    {
                        instructions.Insert(programView.SelectedIndices[0] + 1, x);

                    }
                    else
                    {
                        MessageBox.Show("Could not add instruction at that place. Check it is possible");
                    }
                    break;

                case 3:
                    // Add at end
                    instructions.Add(x);
                    break;

                default:
                    instructions.Add(x);
                    break;
            }

            updateProgramView();

            // Set the ram view needs to update
            RAM_OutOfDate = true;
        }

        // Delete the currently selected line from the program view
        private void deleteLine_Click(object sender, EventArgs e)
        {
            try
            {
                instructions.RemoveAt(programView.SelectedIndices[0]);
                updateProgramView();
            }
            catch
            {
                MessageBox.Show("Please select a line to delete");
            }
        }
        #endregion

        // Delegate Methods and Methods for simpler code
        /* ------------------------------------------------------------------------------- */
        #region Delegate Methods and Methods for simpler code
        // Shorthand to make code easier to read
        private int i(string x)
        {
            return Convert.ToInt32(x);
        }

        // Sets a RAM value to a string. Returns False if RAM address does not exist
        public bool setValueForRAMIndex(int index, string value)
        {
            if (RAMView.Items[index] != null)
            {
                RAMView.Items[index].SubItems[1].Text = value;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Sets the name on the RAM address
        public bool setNameForRAMIndex(int index, string value)
        {
            if (RAMView.Items[index] != null)
            {
                RAMView.Items[index].SubItems[0].Text = value;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Gets a RAM value for a string. Returns "error" if RAM address does not exist
        public string getValueForRAMIndex(int index)
        {
            if (RAMView.Items.Count >= index)
            {
                if (RAMView.Items[index] != null)
                    return RAMView.Items[index].SubItems[1].Text;
                else
                    return "error";
            }
            else
            {
                return "error";
            }
        }

        // Displays an input box for the user. Returns value given or "error" for cancelling.
        public string getInput(string message, bool numerical)
        {
            Input inputForm = new Input(message, numerical);
            if (inputForm.ShowDialog(this) == DialogResult.OK)
            {
                if (inputForm.textBoxInput.Text == "")
                {
                    return "error";
                }
                else
                {
                    return inputForm.textBoxInput.Text;
                }
            }
            else
            {
                return "error";
            }

        }

        // Add some output to the output box. Called by CPU
        public void printOutput(string output)
        {
            this.outputBox.Text += output;
        }

        // Return the index of an instruction with a label
        public int programInstructionIndexForLabel(string label)
        {
            // Can't use foreach as not supported by ListView
            for (int i = 0; i < programView.Items.Count; i++)
            {
                if (programView.Items[i].SubItems[0].Text == label)
                {
                    // Check that instruction is not a DEFB. Re-defining byte will cause errors
                    if (programView.Items[i].SubItems[1].Text != "DEFB")
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        // Converts a HEX ram value to Binary
        private string hexToBinary(string input)
        {
            // Trim the string to only the first 2 chars,
            //  then convert from hex to binary and return
            //  a string with leading zeros
            if (input == "")
            {
                return "00000000";
            }

            string x = input;

            if (input.Length > 2)
            {
                x = input.Remove(2);
            }

            if (x == "XX")
            {
                processor.error(null, "Malformed memory value");
                return "";
            }
            Debug.WriteLine("Instruction in memory position is: {0}", x);

            // Convert Hex to Denary
            int i = 1;
            int c = 1;
            int d = 0;
            while ((i + 1) != 0)
            {
                d += (ToNum(x[i].ToString()) * c);
                i = i - 1;
                c = (c * 16);
            }

            // Convert Denary to Binary
            string output = "";

            while (d > 0)
            {
                output = (d % 2).ToString() + output;
                d = Convert.ToInt32(d / 2);
            }

            // Add leading zeros
            output = output.PadLeft(8, '0');

            return output;
        }

        // Used by hexToBinary for conversion to integer from hexadecimal
        private int ToNum(string x)
        {
            if (x == "A")
                return 10;
            else if (x == "B")
                return 11;
            else if (x == "C")
                return 12;
            else if (x == "D")
                return 13;
            else if (x == "E")
                return 14;
            else if (x == "F")
                return 15;
            else
                return Convert.ToInt32(x);
        }

        private string denaryToBinary(int input)
        {
            string output = "";

            while (input > 0)
            {
                output = (input % 2).ToString() + output;
                input = input / 2;
            }


            // Add leading zeros
            output = output.PadLeft(8, '0');

            return output;
        }

        #endregion

        // Saving and Loading of Programs
        /* ------------------------------------------------------------------------------- */
        #region Saving and Loading
        // Save the currently written program
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Assembly Simulator Files(*.as)\"|*.as";
            save.DefaultExt = "sas";
            save.AddExtension = true;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                if (save.FileName != "")
                {
                    StreamWriter s;
                    s = File.CreateText(save.FileName);
                    foreach (ProgramInstruction i in instructions)
                    {
                        s.WriteLine(i.saveableInstruction());
                    }
                    s.Close();
                }
                else
                {
                    MessageBox.Show("No path was selected, the file was not saved.");
                }
            }
        }

        private byte[] byteArrayForString(string input)
        {
            ASCIIEncoding enc = new ASCIIEncoding();
            return enc.GetBytes(input);
        }

        // Display a dialog for opening a saved project and open it
        private void openButton_Click(object sender, EventArgs e)
        {
            if (new_program() == DialogResult.Yes)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.RestoreDirectory = true;
                open.Filter = "Assembly Simulator Files(*.as)\"|*.as";
                if (open.ShowDialog() == DialogResult.OK)
                {

                    StreamReader s;
                    string i;
                    s = File.OpenText(open.FileName);
                    i = s.ReadLine();
                    while (i != null)
                    {
                        // Add instruction
                        ProgramInstruction x = new ProgramInstruction(
                            i.Substring(0, 20).Trim(),
                            i.Substring(19, 20).Trim(),
                            i.Substring(39, 20).Trim()
                        );
                        instructions.Add(x);
                        // Read in new instruction
                        i = s.ReadLine();
                    }
                    updateProgramView();
                    s.Close();
                }
            }
        }

        private DialogResult new_program()
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the current program "
                + "and open a previous saved file? All unsaved work will be lost.",
                "Delete Unsaved Work",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                // Delete all data
                instructions.Clear();
                updateProgramView();
                RAM_OutOfDate = true;
                processor.reset("all");
                updateProcessorValues();
                mainFormTabs.SelectTab(tabExecute);
                updateCPUDiagramValues();
            }
            return dr;
        }
        #endregion


        internal string getValidatedInput(Control control)
        {
            ValidationWindow v = new ValidationWindow();
            TextBox x = (TextBox)control;

            this.TopMost = true;
            if (v.ShowDialog(this) == DialogResult.OK)
            {
                if (v.evh.Text != "")
                {
                    this.TopMost = false;
                    return v.evh.Text;
                }
                if (v.rah.Text != "")
                {
                    this.TopMost = false;
                    return v.rah.Text.Insert(0, "#");
                }
                else
                {
                    // Fail
                    this.TopMost = false;
                    return "";
                }
            }
            else
            {
                // Epic Fail
                this.TopMost = false;
                return "";
            }
        }

        private void stepForward_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer_Tick(sender, e);
            timer.Stop();
        }

        private void collapseItems_Click(object sender, EventArgs e)
        {
            foreach (InstructionView x in this.instructionFlowPanel.Controls)
            {
                x.Height = 25;
            }
        }

    }
}