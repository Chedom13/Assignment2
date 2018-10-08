using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch;
            bool passed;
            do
            {
                Console.WriteLine("Choose from below options:");
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");
                passed = int.TryParse(Console.ReadLine().ToString(), out caseSwitch);

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Enter three integers :");
                        string[] inputs = Console.ReadLine().ToString().Split(' ');
                        if (inputs.Length == 3)
                        {
                            List<int> dimensions = new List<int>();
                            bool isValidInput = true;
                            foreach(string dimElement in inputs.Select(str => str).ToArray())
                            {
                                int temp;
                                if(!int.TryParse(dimElement, out temp))
                                {
                                    Console.WriteLine("Input must be in integers");
                                    isValidInput = false;
                                    break;
                                }
                                dimensions.Add(temp);
                            }
                            if (isValidInput)
                                Console.WriteLine(TriangleSolver.Analyze(dimensions[0], dimensions[1], dimensions[2]));
                        }
                        else
                            Console.WriteLine("Invalid number of arguments provided.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again!");
                        break;

                }
            }
            while (!passed||caseSwitch!=2);           
        }
    
    }
}
