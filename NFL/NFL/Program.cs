using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    public class Program
    {
        static void Main(string[] args)
        {
            Quarterback qb1 = new Quarterback("Ryan Webb", 5, Grouping.Offensive, 25, 200, 6, 2);

            Console.WriteLine("{0} - #{1}", qb1.Name , qb1.JerseyNumber);
            Console.WriteLine("Completed passes: " + qb1.CompletedPasses);
            Console.WriteLine("Total passes: " + qb1.AttemptedPasses);
            Console.WriteLine("Passing %: {0:P1}", qb1.PassingPercentage);
            Console.WriteLine(Environment.NewLine);
            qb1.Pass();
            Console.WriteLine("Completed passes: " + qb1.CompletedPasses);
            Console.WriteLine("Total passes: " + qb1.AttemptedPasses);            
            Console.WriteLine("Passing %: {0:P1}", qb1.PassingPercentage);
            Console.Write(Environment.NewLine);
            qb1.Pass();
            Console.WriteLine("Completed passes: " + qb1.CompletedPasses);
            Console.WriteLine("Total passes: " + qb1.AttemptedPasses);
            Console.WriteLine("Passing %: {0:P1}", qb1.PassingPercentage);
            Console.ReadLine();
        }
    }
}
