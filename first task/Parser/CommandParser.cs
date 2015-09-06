using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    internal class CommandParser
    {
        public CommandParser(string RawCommandString)
        {
            string command = null;
            List<string> commandArray = new List<string>();
            for (int index = 0; index < RawCommandString.Length; index++)
            {
                if (RawCommandString[index].Equals(' ') || index == (RawCommandString.Length - 1))
                {
                    if (RawCommandString[index] != ' ')
                        command += RawCommandString[index];
                    commandArray.Add(command);
                    command = "";
                }
                else
                {
                    command += RawCommandString[index];
                }
            }
            for (int index = 0; index < commandArray.Count; index++)
            {
                switch (commandArray[index])
                {
                    case "/help":
                        help();
                        break;
                    case "-help":
                        help();
                        break;
                    case "/?":
                        help();
                        break;
                    case "-ping":
                        ping();
                        break;
                    case "/ping":
                        ping();
                        break;
                    case "-exit":
                        exit();
                        break;
                    case "/exit":
                        exit();
                        break;
                    case "":
                        help();
                        break;
                  /*  default:
                        if (commandArray[index].Substring(0, 6) == "-print" || commandArray[index].Substring(0, 6) == "/print")
                        {
                            print(commandArray[index].Substring(7));
                        }
                        else
                        {
                            if (commandArray[index].Substring(0, 2) == "-k" || commandArray[index].Substring(0, 2) == "/k")
                            {
                                keyValue(commandArray[index].Substring(2, 2), commandArray[index].Substring(5));
                            }
                            else
                            {
                                Console.WriteLine("Command <" + commandArray[index] + "> is not supported, use /? or /help or -help to see set of allowed commands");

                            }
                        }
                        break;*/
                }
            }
        }

        public void help()
        {
            Console.WriteLine(@"    Help:

-help, /help, /? - this commands display help information.
Use this command without any paramethers.

-ping, /ping - this command beeps.
Use this command without any paramethers.

-print <message>, /print <message>- this command print any messages, that you want to see.
<message> - on this place you must write text of your message.
Example: -print I write my first message

-k key value - this command print a table of key-value.
key value - on this place you must write key and value what you need.
Example: -key a alphabet

-exit, /exit - this command help you to close programm.
");
        }

        public void ping()
        {
            Console.Beep();
            Console.WriteLine("Pinging...");
        }

        public void print(string message)
        {
            Console.WriteLine(message);
        }


        public void keyValue(string key, string value)
        {
            Console.WriteLine(key + " - " + value);
        }

        public void exit()
        {
            Environment.Exit(0);
        }

    }
}