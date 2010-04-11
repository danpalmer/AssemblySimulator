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
    public partial class ValidationWindow : Form
    {
        public ValidationWindow()
        {
            InitializeComponent();
            evd.numerical = true;
            evb.numerical = true;
            evh.numerical = false;
            rad.numerical = true;
            rab.numerical = true;
            rah.numerical = false;

        }

        private void evd_TextChanged(object sender, EventArgs e)
        {
            // Clear other boxes
            rah.Clear();
            rad.Clear();
            rab.Clear();

            if (evd.Text != "")
            {
                evb.Text = denaryToBinary(Convert.ToInt32(evd.Text));
                evh.Text = convertToHex(Convert.ToInt32(evd.Text));
            }
            else
            {
                evb.Text = "00000000";
                evh.Text = "0x00000000";
            }
        }

        private void rad_TextChanged(object sender, EventArgs e)
        {
            // Clear other boxes
            evh.Clear();
            evd.Clear();
            evb.Clear();

            if (rad.Text != "")
            {
                rab.Text = denaryToBinary(Convert.ToInt32(rad.Text));
                rah.Text = convertToHex(Convert.ToInt32(rad.Text));
            }
            else
            {
                rab.Text = "00000000";
                rah.Text = "0x00000000";
            }

        }

        private string convertToHex(int p)
        {
            string output = "";
            int temp;

            while (p > 0)
            {
                temp = p % 16;
                output = toChar(temp) + output;
                p = p / 16;
            }

            return output;
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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string toChar(int i)
        {
            string chars = "0123456789ABCDEF";
            return chars[i].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
