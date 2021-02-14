using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine(string.Join(' ', numbs));
                    break;
                }

                string[] requiredCommands = command.Split();

                if (requiredCommands[0] == "Add")
                {
                    int number = int.Parse(requiredCommands[1]);
                    numbs.Add(number);
                }
                else if (requiredCommands[0] == "Insert")
                {
                    int idx = int.Parse(requiredCommands[2]);
                    int number = int.Parse(requiredCommands[1]);

                    if (idx >= 0 && idx <= numbs.Count-1)
                    {
                        numbs.Insert(idx, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }                    
                }
                else if (requiredCommands[0] == "Remove")
                {
                    int idx = int.Parse(requiredCommands[1]);

                    if (idx >= 0 && idx <= numbs.Count - 1)
                    {
                        numbs.RemoveAt(idx);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }                    
                }
                else if (requiredCommands[0] == "Shift")
                {
                    if (requiredCommands[1] == "left" )
                    {
                        int countMovements = int.Parse(requiredCommands[2]);
                        for (int i = 0; i < countMovements; i++)
                        {
                            numbs.Add(numbs[0]);
                            numbs.RemoveAt(0);
                        }
                    }
                    else  // requiredCommands[1] == "right" 
                    {
                        int countMovements = int.Parse(requiredCommands[2]);
                        for (int i = 0; i < countMovements; i++)
                        {                          
                           numbs.Insert(0, numbs[numbs.Count - 1]);
                           numbs.RemoveAt(numbs.Count-1);
                        }
                    }
                }                    
            }
        }
    }
}
