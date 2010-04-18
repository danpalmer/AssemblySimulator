using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

namespace Assembly_Simulator
{
    public class EnhancedTextBox : System.Windows.Forms.TextBox
    {

        // Intercept the OnKeyPress event and analyse the KeyPressEventArgs
        // If a Digit, Backspace or negative sign, pass up the class hierarchy,
        // If the character is NOT wanted, then set e.Handled to true to tell
        //  the superclasses that the key has been handled and they need not
        //  process it, therefore ignoring the input.


        public bool numerical = false;

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string negativeSign = numberFormatInfo.NegativeSign;

            string keyInput = e.KeyChar.ToString();


            if (e.KeyChar == '\b')
            {
                // Allow backspace first
            }
            else if (numerical && Char.IsDigit(e.KeyChar))
            {
                // Do in this order so that the letters aren't run through the next bit of validation
                if (Convert.ToInt32(this.Text + e.KeyChar) > 255)
                {
                    e.Handled = true;
                    errorFlash();
                }
                else
                {
                    // Let super handle this
                }
            }
            else if (e.KeyChar == ' ')
            {
                if (numerical)
                {
                    // DO NOT USE KEYSTROKE
                    e.Handled = true;
                    errorFlash();
                }
                else
                {
                    // Ignore and let superclass handle
                    // When execution ends, the unhandled keys (like this one) are passed to the superclass
                }
            }
            else
            {
                if (numerical)
                {
                    // DO NOT USE KEYSTROKE
                    e.Handled = true;
                    errorFlash();
                }
                else
                {
                    // Ignore and let superclass handle
                    // When execution ends, the unhandled keys (like this one) are passed to the superclass
                }
            }
        }

        // These two methods are a rough, but easy way to flash the textbox red for a limited time
        // The benefit of this method is, during the flash, the program remains responsive whereas
        //  if a wait command was used it would freeze the process.
        private void errorFlash()
        {
            // Set the textbox's appearance while flashing...
            base.BackColor = Color.Red;
            base.ForeColor = Color.White;
            // Create a timer set to call endErrorFlash in 0.1s and start it
            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += new System.EventHandler(this.endErrorFlash);
            timer.Start();
        }

        // Called 0.1 seconds later
        private void endErrorFlash(object sender, EventArgs e)
        {
            // Set the texbox back to normal
            base.BackColor = Color.White;
            base.ForeColor = Color.Black;
            // Tidy up the timer stuff to stop this method being called again
            Timer timer = (Timer)sender;
            timer.Stop();
        }
    }
}
