using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Assembly_Simulator
{
    public partial class InstructionView : UserControl
    {
        private Main parent;

        // Initialisation Code
        public InstructionView(string name, string detail, string OPCODE, int colour, Main p)
        {
            InitializeComponent();
            labelName.Text = name;
            labelDetail.Text = detail;
            labelOPCODESmall.Text = OPCODE;

            switch (colour)
            {
                case 1:
                    changeColour(Color.PowderBlue);
                    break;

                case 2:
                    changeColour(Color.Gold);
                    break;

                case 3:
                    changeColour(Color.OrangeRed);
                    break;

                case 4:
                    changeColour(Color.Orchid);
                    break;

                default:
                    changeColour(Color.FromName("GradientInactiveCaption"));
                    break;
            }

            parent = p;
            // Set other values

            this.Height = 25;
        }

        // Changes the colour of UI elements based on the colour argument
        private void changeColour(Color colour)
        {
            labelName.BackColor = colour;
            labelOPCODESmall.BackColor = colour;
        }

        // Expands and contracts the box when clicked. Toggle action
        public void nameLabel_Click(object sender, EventArgs e)
        {
            foreach (InstructionView x in this.Parent.Controls)
            {
                if (x != this)
                {
                    x.Height = 25;
                }
            }

            if (this.Height == 25)
                this.Height = 200;
            else
                this.Height = 25;
        }

        // Clears and resets the add instruction view
        private void clearInstruction_Click(object sender, EventArgs e)
        {
            textBoxLabel.Clear();
            textBoxOPERAND.Clear();
            radEnd.Select();
        }

        // Adds the current settings to a new instruction
        private void addInstruction_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (radBefore.Checked)
                x = 1;
            else if (radAfter.Checked)
                x = 2;
            else if (radEnd.Checked)
                x = 3;
            else
                MessageBox.Show("Please select where you would like to enter the instruction.");

            parent.addInstruction(
                textBoxLabel.Text,
                labelOPCODESmall.Text,
                textBoxOPERAND.Text,
                x);

            clearInstruction_Click(this, null);
        }

        // This asks the parent form for input with getValidateInput
        // This should open an input window that refuses entry of bad data
        // TODO: get this to work with tabbing in to the box rather than clicking on it.
        private void textBoxOPERAND_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            ((TextBox)sender).Text = parent.getValidatedInput(c);
            this.addInstruction.Select();
        }
    }
}