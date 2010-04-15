using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assembly_Simulator
{
    public partial class Input : Form
    {
        public Input(string message, bool numerical)
        {
            InitializeComponent();

            // Init code
            labelMessage.Text = message;
            textBoxInput.Select();
            textBoxInput.numerical = numerical;
            buttonAccept.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonAccept.Enabled = false;
        }

        // Enable and disable the accept button dependant on text in textbox
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length > 0)
                buttonAccept.Enabled = true;
            else
                buttonAccept.Enabled = false;
        }

        // Stop 'Enter' from working when no text in the textbox
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (textBoxInput.Text.Length < 0)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
