using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1Slektstre
{
    class App
    {
        public string HandleCommand(String command)
        {
            String cmd = command.ToLower();
            if (cmd == "Hjelp")
                Console.WriteLine("Hjelp");
            else if (cmd == "Liste")
                Console.WriteLine("Liste");
            else if (cmd.Contains("Vis"))
                Console.WriteLine("Vis ID");
            else
                showHelp();
            return "";
        }

        private void showHelp()
        {
            Console.WriteLine();
        }
    }
}
