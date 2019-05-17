using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestLibrary;

namespace RepoExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a repo test!");

            // sample 
        
            int value1 = 4;
            int value2 = 3;

            int addResult = ComputeModule.AddIntegerAsync(value1, value2).Result;
            Console.WriteLine(String.Format("The sum of {0} and {1} is {2}", value1, value2, addResult));

            // your code changes here ...

            Console.Read();
        }
    }
}
