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

		// These objects are kept in a List<Symlink> so that they can be found at a later time.
		// There is no validation on the inputs as they are not open to the user.
        public Symlink(string _name, int _address)
        {
            name = _name;
            address = _address;
        }
    }
}