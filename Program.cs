using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOGOL
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello and welcome to BOGOL!\nQuit by writing 'quit'!");
            String command;
            bool quit = false;
            int[] intArray = new int[5];
            do
            {
                command = Console.ReadLine();
                string[] cword = command.Split(' ');

                switch (cword[0])
                {
                    case "quit":
                        quit = true;
                        break;
                    case "set":
                        switch (cword[1])
                        {
                            case "a":

                                break;
                        }
                        Console.WriteLine("variable " + cword[1] + " now has the value " + cword[3]);
                        break;
                    default:
                        Console.WriteLine("command: " + command);
                        break;
                }
            } while (quit == false);
        }
    }
}
