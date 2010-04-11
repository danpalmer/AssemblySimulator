using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assembly_Simulator
{
    class Symlink
    {
        public string name { get; set; }
        public int address { get; set; }

        public Symlink(string _name, int _address)
        {
            name = _name;
            address = _address;
        }
    }
}