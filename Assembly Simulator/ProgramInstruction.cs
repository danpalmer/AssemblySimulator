using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assembly_Simulator
{
    public class ProgramInstruction
    {
        public string label { get; set; }
        public string opcode { get; set; }
        public string operand { get; set; }

        // INITIALISATION
        public ProgramInstruction(string _label, string _opcode, string _operand)
        {
            label = _label;
            opcode = _opcode;
            operand = _operand;
        }

        // Returns a string for the details of the instruction
        public string description()
        {
            return label + "::" + opcode + "::" + operand;
        }

        // Returns 
        public string cleanOperand()
        {
            if (this.operand != null || this.operand[0].ToString() == "#")
            {
                return operand.Replace("#", "");
            }
            else
            {
                return operand;
            }
        }

        // Returns a string that can be saved to a file.
        public string saveableInstruction()
        {
            string output;
            output = getFixedLengthString(label, 20);
            output += getFixedLengthString(opcode, 20);
            output += getFixedLengthString(operand, 20);
            return output;
        }

        // fixes the length of a string
        public string getFixedLengthString(string input, int length)
        {
            string result = string.Empty;

            if (string.IsNullOrEmpty(input))
            {
                result = new string(' ', length);
            }
            else if (input.Length > length)
            {
                result = input.Substring(0, length);
            }
            else
            {
                result = input.PadRight(length);
            }

            return result;
        }

        // Returns the correct HEX machine code for the opcode
        public string hexOpcode()
        {
            switch(opcode)
            {
                case "LD":
                    if (this.operand != null || this.operand[0].ToString() == "#")
                        return "0D";
                    else
                        return "0E";
                case "ST":
                    return "11";
                case "ADD":
                    if (this.operand != null || this.operand[0].ToString() == "#")
                        return "15";
                    else
                        return "16";
                case "SUB":
                    if (this.operand != null || this.operand[0].ToString() == "#")
                        return "19";
                    else
                        return "1A";
                case "MUL":
                    if (this.operand != null || this.operand[0].ToString() == "#")
                        return "1D";
                    else
                        return "1E";
                case "DIV":
                    if (this.operand != null || this.operand[0].ToString() == "#")
                        return "21";
                    else
                        return "22";
                case "GETCHAR":
                    return "F0";
                case "GETINT":
                    return "F4";
                case "PUTCHAR":
                    return "F8";
                case "PUTINT":
                    return "FC";
                case "AND":
                    return "31";
                case "OR":
                    return "33";
                case "CMP":
                    return "41";
                case "JE":
                    return "51";
                case "JL":
                    return "A2";
                case "JG":
                    return "A3";
                case "JNE":
                    return "A4";
                case "JLE":
                    return "A5";
                case "JGE":
                    return "A6";
                case "JP":
                    return "A7";
                case "DEFB":
                    return "DB";

                default:
                    return "XX";
                    
            }
        }
    }
}
