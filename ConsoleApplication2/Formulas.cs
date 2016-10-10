using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1_3;

namespace Homework1_4
{
    public class MainFormulas
    {
        static void Main ()
        {
            int x;
            string Input;
            bool Parsed;
            bool Exit = false;

            do
            {
                do
                {
                    Console.WriteLine("Please choose from the following : ");
                    Console.WriteLine();
                    Console.WriteLine("1 : Multiples Table Generator");
                    Console.WriteLine("2 : Max Equation");
                    Console.WriteLine("3 : Min Equation");
                    Console.WriteLine("4 : Average Equation");
                    Console.WriteLine("5 : Exit Application");
                    Console.WriteLine();
                    Console.Write("Enter Here : ");
                    Input = Console.ReadLine();
                    Parsed = Int32.TryParse(Input, out x);

                    if (Parsed)
                    {
                        if (x == 1)
                        {
                            var multTable = new MultiplyingTable();
                            multTable.CreateTable();
                        }
                        else if (x == 2)
                        {
                            var getMax = new MainFormulas();
                            getMax.Max();
                        }
                        else if (x == 3)
                        {
                            var getMin = new MainFormulas();
                            getMin.Min();
                        }
                        else if (x == 4)
                        {
                            var getAvg = new MainFormulas();
                            getAvg.Average();
                        }
                        else if (x == 5)
                        {
                            Exit = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Incorrect Input Please Try Again");
                        Console.WriteLine();
                    }
                }
                while (!Parsed);
            }
            while (Exit == false);

            Console.WriteLine("Thanks for using this application");
            Console.ReadLine();
        }

        public void Max ()
        {
            Console.WriteLine();
            Console.WriteLine("Insert A series of Numbers separated by Spaces");
            string[] maxInputs = Console.ReadLine().Split();
            bool checkInput;
            int z;
            int oldz = 0;

            foreach(string item in maxInputs)
            {
                checkInput = int.TryParse(item, out z);
                
                if (z > oldz)
                {
                    oldz = z;
                }
                
            }
            Console.WriteLine("Max Number : " + oldz);
            Console.ReadLine();
        }

        public void Min()
        {
            Console.WriteLine();
            Console.WriteLine("Insert A series of Numbers separated by Spaces");
            string[] maxInputs = Console.ReadLine().Split();
            bool checkInput;
            int z;
            int oldz = 1000000;

            foreach (string item in maxInputs)
            {
                checkInput = int.TryParse(item, out z);

                if (z < oldz)
                {
                    oldz = z;
                }

            }
            Console.WriteLine("Min Number : " + oldz);
            Console.ReadLine();
        }

        public void Average()
        {
            Console.WriteLine();
            Console.WriteLine("Insert A series of Numbers separated by Spaces");
            string[] avgInputs = Console.ReadLine().Split();
            bool checkInput;
            decimal z = 0;
            decimal totalz = 0;
            decimal countz = 0;

            foreach (string input in avgInputs)
            {
                checkInput = Decimal.TryParse(input, out z);
                totalz += z;
                countz++;
            }

            Console.WriteLine();
            Console.WriteLine("Average of values is : " + totalz / countz);
        }
    }
}
