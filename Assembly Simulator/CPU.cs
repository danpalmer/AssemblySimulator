using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Assembly_Simulator
{
    class CPU
    {
        private List<Symlink> symlinks = new List<Symlink>();

        // Setters and Getters: Validation and actions for accumulator
        /* ----------------------------------------------------------- */

        // Some validation is done when a value is input, however some happens here too.
        // All values coming to this point should be 'valid' but some will chang registers
        // on the CPU when set as the accumulator. These registers are used for Jump functions.

		// TODO: Add Support for RAM addresses and Symlinks to ADD
		// TODO: Add Support for RAM addresses and Symlinks to SUB
		// TODO: Add Support for RAM addresses and Symlinks to MUL
		// TODO: Add Support for RAM addresses and Symlinks to DIV

        public string accumulator {
            get
            {
                return _accumulator;
            }

            set
            {
                int x = Convert.ToInt32(value);
                if (x < -127)
                {
                    negativeSignFlag = true;
                    zeroFlag = false;
                    overflowFlag = true;
                    _accumulator = (x * -1).ToString();
                }
                else if (x < 0)
                {
                    negativeSignFlag = true;
                    zeroFlag = false;
                    overflowFlag = false;
                    _accumulator = (x * -1).ToString();
                }
                else if (x == 0)
                {
                    negativeSignFlag = false;
                    zeroFlag = true;
                    overflowFlag = false;
                    _accumulator = x.ToString();
                }
                else if (x > 127)
                {
                    negativeSignFlag = false;
                    zeroFlag = false;
                    overflowFlag = true;
                    _accumulator = x.ToString();
                }
                else
                {
                    negativeSignFlag = false;
                    zeroFlag = false;
                    overflowFlag = false;
                    _accumulator = x.ToString();
                }
            }
        }
        // This is the 'real' accumulator hidden behind the above validation code.
        private string _accumulator { get; set; }
        // These are all publically accessible so that Main can access them to update the form
        public string programCounter { get; set; }
        public bool zeroFlag { get; set; }
        public bool carryFlag { get; set; }
        public bool overflowFlag { get; set; }
        public bool negativeSignFlag { get; set; }

        bool instructionFailed;

        // Used as a handle so that messages can be passed up the hierarchy
        // This should really be _parent as it is the private version, but
        // 'parent' is used more than '_parent' so I am keeping it this way.
        Main parent;

        public CPU(Main _parent)
        {
            accumulator = "0";
            programCounter = "0";
            zeroFlag = false;
            carryFlag = false;
            overflowFlag = false;
            negativeSignFlag = false;
            parent = _parent;
            instructionFailed = false;
        }

        public void Process(string label, string opcode, string operand)
        {
            parent.timer.Stop();
            instructionFailed = false;
            Debug.WriteLine("Processing: " + label + ", " + opcode + ", " + operand);
            int intOperand = 0;

            // Start processing

            if (operand != null && operand != "")
            {
                intOperand = getOperandValue(operand);
            }

            // I use a switch here as it requires fewer comparisons and therefore should be faster
            switch (opcode) {
                case "LD":
                    reset("flags");
                    LD(label, intOperand);
                    break;
                case "ST":
                    reset("flags");
                    ST(label, intOperand, operand);
                    break;
                case "ADD":
                    reset("flags");
                    ADD(label, intOperand);
                    break;
                case "SUB":
                    reset("flags");
                    SUB(label, intOperand);
                    break;
                case "MUL":
                    reset("flags");
                    MUL(label, intOperand);
                    break;
                case "DIV":
                    reset("flags");
                    DIV(label, intOperand);
                    break;
                case "GETCHAR":
                    reset("flags");
                    GETCHAR(label, intOperand);
                    break;
                case "GETINT":
                    reset("flags");
                    GETINT(label, intOperand);
                    break;
                case "PUTCHAR":
                    reset("flags");
                    PUTCHAR(label, intOperand);
                    break;
                case "PUTINT":
                    reset("flags");
                    PUTINT(label, intOperand);
                    break;
                case "CMP":
                    reset("flags");
                    CMP(label, intOperand);
                    break;
                case "DEFB":
                    reset("flags");
                    DEFB(label, intOperand);
                    break;
                case "JG":
                    JG(label, operand);
                    break;
                case "JL":
                    JL(label, operand);
                    break;
                case "JE":
                    JE(label, operand);
                    break;
                case "JNE":
                    JNE(label, operand);
                    break;
                case "JGE":
                    JGE(label, operand);
                    break;
                case "JLE":
                    JLE(label, operand);
                    break;
                case "JP":
                    JP(label, operand);
                    break;
                case "AND":
                    AND(label, intOperand);
                    break;
                case "OR":
                    OR(label, intOperand);
                    break;
                default:
                    error(null, "Error, could not process instruction");
                    break;
            }


            // End of processing, update Program Counter
            this.programCounter = (Convert.ToInt32(this.programCounter) + 1).ToString();
            if (instructionFailed == false)
                parent.timer.Start();
        }

        /* ----------------------------------------------------------------------------- */

        /*
            This section contains code for each instruction. Details of these
            can be found in the XML instruction list. See the Jump table
            below for details on the processing of jump instructions.
        */

        // Load Address or Operand into Accumulator
        private void LD(string label, int operand)
        {
            accumulator = operand.ToString();
        }

        // Store Accumulator at Address or Label
        private void ST(string label, int intOperand, string operand)
        {
            // Show errors if the user has specified a value or non-existent symlink as
            //  the operand
            if (operand[0] == Convert.ToChar("#"))
            {
                error(null, "Cannot set direct address as memory location value");
                Debug.WriteLine("Error: Bad Instruction");
            }
            else if (checkSymlink(operand))
            {
                foreach (Symlink s in symlinks)
                {
                    if (s.name == operand)
                    {
                        parent.setValueForRAMIndex(s.address, accumulator);
                        return;
                    }
                }

                error(null, "Could not find symbolic link in array, "
                    + "please contact the publisher of this program for assistance");
            }
            else
            {
                parent.setValueForRAMIndex(Convert.ToInt32(operand), accumulator);
                Debug.WriteLine("Stored accumulator in memory location");
            }
        }

        // Add Operand to Accumulator
        private void ADD(string label, int operand)
        {
            accumulator = (Convert.ToInt32(accumulator) + operand).ToString();
            Debug.WriteLine("Added operand to acculumator");
        }

        // Subtract Operand from Accumulator
        private void SUB(string label, int operand)
        {
            accumulator = (Convert.ToInt32(accumulator) - operand).ToString();
            Debug.WriteLine("Subtracted operand from accumulator");
        }

        // Multiply the Accumulator by the Operand
        private void MUL(string label, int operand)
        {
            accumulator = (Convert.ToInt32(accumulator) * operand).ToString();
        }

        // Divide the Accumulator by the Operand
        private void DIV(string label, int operand)
        {
            accumulator = Convert.ToInt32((Convert.ToInt32(accumulator) / operand)).ToString();
        }

        // Get a single character input from the user
        private void GETCHAR(string label, int operand)
        {
            string x = parent.getInput("Please enter a single character:", false);

            // If getInput can't get an input then it returns 'error'
            if (x != "error")
            {
                int y = (int)x[0];
                negativeSignFlag = false;
                accumulator = y.ToString();
            }
            else
            {
                error(null, "No character input");
            }
        }

        // Get an integer fromt he user in the range -127 to 127
        private void GETINT(string label, int operand)
        {
            string x = parent.getInput("Please enter an integer up to 256:", true);

            // If getInput can't get an input then it returns 'error'
            if (x != "error")
            {
                int y = Convert.ToInt32(x);

                // Validation done here because the input window is for letters and numbers
                if (y > 127 || y < -127)
                    error(null, "Integer is not within the correct bounds");
                else
                {
                    accumulator = y.ToString();
                }
            }
            else
            {
                error(null, "No character input");
            }
        }

        // Output character interpretation of Accumulator
        private void PUTCHAR(string label, int operand)
        {
            int x = Convert.ToInt32(accumulator);
            // Explicit cast to char will use convert based on the ascii codes
            parent.printOutput(((char)x).ToString());
        }

        // Output Accumulator
        private void PUTINT(string label, int operand)
        {
            parent.printOutput(accumulator);
        }

        // Compares accumulator to operand for Jump functions
        private void CMP(string label, int operand)
        {
            try
            {
                int x = Convert.ToInt32(accumulator) - operand;

                if (x == 0)
                    zeroFlag = true;
                if (x < 0)
                    negativeSignFlag = true;
                if (x < -127 || x > 127)
                    overflowFlag = true;
            }
            catch
            {
                error(null, "Could not convert operand or accumulator to an integer.");
            }
        }

        // Reserve a memory address
        private void DEFB(string label, int operand)
        {
			if (label == "" || label == null) {
				error("No Label Provided", "The DEFB instruction requires a Label for it to link to a RAM address. Do not use a Label that you may use for Jump instructions.");
			}
            // Ignore operand
            int ramIndex = parent.addRAM(1);
            parent.setNameForRAMIndex(ramIndex, label);
            Symlink s = new Symlink(label, ramIndex);
            symlinks.Add(s);
        }

        // Jump parameters
        //  if(z = 0) and (s = o) - JG
        //  if(s <> o)            - JL
        //  if (z = 1)            - JE
        //  if (z = 0)            - JNE
        //  if (s = o) or z=1     - JGE
        //  if (s <> o) or z = 1  - JLE

        // Jump to operand label
        private void JP(string label, string operand)
        {
			if (operand == "" || operand == null) {
            	// Change the next instruction to be executed by getting the label to jump to
            	this.programCounter = (parent.programInstructionIndexForLabel(operand) -1).ToString();
			}
        }

        // Jump to operand label if greater: z=0 and ns=0
        private void JG(string label, string operand)
        {
            if (!zeroFlag && !negativeSignFlag)
                JP(label, operand);
        }

        // Jump to operand label if equal: z=1
        private void JE(string label, string operand)
        {
            if (zeroFlag)
                JP(label, operand);
        }

        // Jump to operand label if lower: ns!=o
        private void JL(string label, string operand)
        {
            if (negativeSignFlag != overflowFlag)
                JP(label, operand);
        }

        // Jump to operand label if greater or equal: ns=o
        private void JGE(string label, string operand)
        {
            if (negativeSignFlag == overflowFlag)
                JP(label, operand);
        }

        // Jump to operand label if lower or equal: ns!=o or z=1
        private void JLE(string label, string operand)
        {
            if (negativeSignFlag != overflowFlag || zeroFlag)
                JP(label, operand);
        }

        // Jump to operand label if not equal: z=0
        private void JNE(string label, string operand)
        {
            if (!zeroFlag)
                JP(label, operand);
        }

        // Run AND on the accumulator and operand
        private void AND(string label, int operand)
        {
            int x = Convert.ToInt32(accumulator);
            x = x & operand;
            accumulator = x.ToString();
        }

        // Run OR on the accumulator and operand
        private void OR(string label, int operand)
        {
            int x = Convert.ToInt32(accumulator);
            x = x | operand;
            accumulator = x.ToString();
        }

        /* ----------------------------------------------------------------------------- */

        // Returns the actual operand value whether it is a memory address value or value from symlink
        public int getOperandValue(string operand)
        {
            if (operand[0].ToString() == "#")
            {
                operand = operand.Replace("#", "");
                operand = hexToInt(operand);
                int x = Convert.ToInt32(operand);
                return x;
            }
            else if (checkSymlink(operand))
            {
                foreach (Symlink s in symlinks)
                {
                    if (s.name == operand)
                    {
                        return Convert.ToInt32(parent.getValueForRAMIndex(s.address));
                    }
                }

                error(null, "Could not find symbolic link in array, "
                    + "please contact the publisher of this program for assistance");
            }
            else if (parent.programInstructionIndexForLabel(operand) != -1)
            {
                // Operand is a label to JUMP to
                return 0;
            }
            else
            {
                // Must be a memory location
                operand = hexToInt(operand);
                int x = Convert.ToInt32(operand);
                string y = parent.getValueForRAMIndex(x);
                if (y == "error")
                {
                    error(null, "Memory address out of bounds");
                    return 0;
                }
                return Convert.ToInt32(y);
            }
            error(null, "Badly formed operand");
            return -1;
        }

        // Displays pre-formed error message with options, tells the main form to stop execution
        public void error(string title, string caption)
        {
            if (title == null)
                title = "Error in program execution";
            System.Windows.Forms.MessageBox.Show(
                caption,
                title,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error,
                System.Windows.Forms.MessageBoxDefaultButton.Button1);

            // Tell parent to stop processing and reset values
            instructionFailed = true;
            parent.stopOnError();
        }

        // Returns a string of an integer representation of a hex string
        private string hexToInt(string s)
        {
            int i = s.Length - 1;
            int c = 1;
            int output = 0;
            while ((i + 1) != 0)
            {
                output += (ToNum(s[i].ToString()) * c);
                i = i - 1;
                c = (c * 16);
            }
            return output.ToString();
        }

        // Used by hexToInt for conversion to integer from hexadecimal
        private int ToNum(string x)
        {
            // CHANGED: using switch as it is faster
            // Note, the unecessary breaks were included to keep the compiler happy
            switch (x)
            {
                case "A":
                    return 10;
                    break;
                case "B":
                    return 11;
                    break;
                case "C":
                    return 12;
                    break;
                case "D":
                    return 13;
                    break;
                case "E":
                    return 14;
                    break;
                case "F":
                    return 15;
                    break;
                default:
                    return Convert.ToInt32(x);
                    break;
            }
        }

        // Resets CPU: flags resets only flags, default reselts all
        internal void reset(string variablesToReset)
        {
            if (variablesToReset == "flags")
            {
                zeroFlag = false;
                carryFlag = false;
                overflowFlag = false;
                negativeSignFlag = false;
            }
            else
            {
                accumulator = "0";
                programCounter = "0";
                zeroFlag = false;
                carryFlag = false;
                overflowFlag = false;
                negativeSignFlag = false;
            }
        }

        // Return true if the symlink is found in the array
        private bool checkSymlink(string name)
        {
            foreach (Symlink s in symlinks)
            {
                if (s.name == name)
                    return true;
            }

            return false;
        }
    }
}
