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
                        int value;

                        bool success = int.TryParse(cword[3], out value);
                        if (success)
                        {
                            value = int.Parse(cword[3]);
                            switch (cword[1])
                            {
                                case "a":
                                    intArray[0] = value;
                                    Console.WriteLine("variable " + cword[1] + " now has the value " + cword[3]);
                                    break;
                                case "b":
                                    intArray[1] = value;
                                    Console.WriteLine("variable " + cword[1] + " now has the value " + cword[3]);
                                    break;
                                case "c":
                                    intArray[2] = value;
                                    Console.WriteLine("variable " + cword[1] + " now has the value " + cword[3]);
                                    break;
                                case "d":
                                    intArray[3] = value;
                                    Console.WriteLine("variable " + cword[1] + " now has the value " + cword[3]);
                                    break;
                                case "e":
                                    intArray[4] = value;
                                    Console.WriteLine("variable " + cword[1] + " now has the value " + cword[3]);
                                    break;
                                default:
                                    Console.WriteLine("That is outside of the array!");
                                    break;
                            }
                        }
                        else
                        {
                            if (cword[3].Contains("a"))
                            {
                                value = intArray[0];
                            }
                            else if (cword[3].Contains("b"))
                            {
                                value = intArray[1];
                            }
                            else if (cword[3].Contains("c"))
                            {
                                value = intArray[2];
                            }
                            else if (cword[3].Contains("d"))
                            {
                                value = intArray[3];
                            }
                            else if (cword[3].Contains("e"))
                            {
                                value = intArray[4];
                            }
                            switch (cword[1])
                            {
                                case "a":
                                    intArray[0] = value;
                                    Console.WriteLine("variable " + cword[1] + " now has the value " + cword[3]);
                                    break;
                                case "b":
                                    intArray[1] = value;
                                    Console.WriteLine("variable " + cword[1] + " now has the value " + cword[3]);
                                    break;
                                case "c":
                                    intArray[2] = value;
                                    Console.WriteLine("variable " + cword[1] + " now has the value " + cword[3]);
                                    break;
                                case "d":
                                    intArray[3] = value;
                                    Console.WriteLine("variable " + cword[1] + " now has the value " + cword[3]);
                                    break;
                                case "e":
                                    intArray[4] = value;
                                    Console.WriteLine("variable " + cword[1] + " now has the value " + cword[3]);
                                    break;
                            }
                        }
                        break;
                    case "print":
                        switch (cword[1]){
                            case "a":
                                Console.WriteLine(intArray[0]);
                                break;
                            case "b":
                                Console.WriteLine(intArray[1]);
                                break;
                            case "c":
                                Console.WriteLine(intArray[2]);
                                break;
                            case "d":
                                Console.WriteLine(intArray[3]);
                                break;
                            case "e":
                                Console.WriteLine(intArray[4]);
                                break;
                            case "all":
                                for(int i = 0; i < 5; i++)
                                {
                                    if(i == 0)
                                    {
                                        Console.WriteLine("a = " + intArray[i]);
                                    } else if(i == 1)
                                    {
                                        Console.WriteLine("b = " + intArray[i]);
                                    } else if(i == 2)
                                    {
                                        Console.WriteLine("c = " + intArray[i]);
                                    } else if (i == 3)
                                    {
                                        Console.WriteLine("d = " + intArray[i]);
                                    } else if (i == 4)
                                    {
                                        Console.WriteLine("e = " + intArray[i]);
                                    }

                                }
                                break;
                            default:
                                Console.WriteLine("That variable does not exist!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("unknown command: " + command);
                        break;
                }
            } while (quit == false);
        }
    }
}
