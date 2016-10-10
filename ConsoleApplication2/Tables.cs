using Homework1_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_3
{
    public class MultiplyingTable
    {
        public void CreateTable()
        {

            int x;
            int y;
            string Input;
            string Input2;
            bool Parsed;
            bool Parsed2;
            bool Restart = false;

            Console.WriteLine();
            Console.WriteLine("Multiples Table Generator");

            do
            {
                Console.Write("Please Insert Multiple : ");
                Input = Console.ReadLine();
                Parsed = Int32.TryParse(Input, out x);

                if (Parsed)
                {
                    MultTable(x);

                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("(1) Return to Main Menu or (2) To Quit?");
                        Input2 = Console.ReadLine();
                        Parsed2 = Int32.TryParse(Input2, out y);

                        if (Parsed2)
                        {
                            if (y == 1)
                            {
                                Restart = true;
                            }
                            else if (y == 2)
                            {
                                closeApp();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Incorrect Input");
                                Console.WriteLine();
                            }
                        }  
                    }
                    while (!Parsed2);
                }
                else if (!Parsed)
                {
                    Console.WriteLine("Incorrect Input, Please only input a number");
                }
            }
            while (Restart != true);

            Console.WriteLine();
            Console.WriteLine("Restarting Application");
            Console.WriteLine();
        }

        static void MultTable(int x)
        {
            Console.WriteLine();

            for(int i = 1; i < x+1; i++)
            {
                for(int j = 1; j < x+1; j++)
                {
                    Console.Write(i*j + " ");
                }
                Console.WriteLine();
            }
        }

        public void closeApp()
        {
            Environment.Exit(1);
        }
    }
}