using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assembly_Simulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        ///
        /// This function is the root of the process. It creates a Main form and runs it.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}