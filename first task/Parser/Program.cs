using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CommandParser pars;
            string Command = "";
            while (true)
            {    Command = Console.ReadLine();
                 pars = new CommandParser(Command);
               
            } 
        }
    }
}
