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
            //name, points, points allowed, touchdowns, interceptions, sacks
            Team greenBayPackers = new Team("Green Bay Packers", 368, 20.4, 16, 8, 47);

            Quarterback aaronRogers = new Quarterback("Aaron Rodgers", 12, Grouping.Offensive, 32, 225, 92.7, 80, 45, 4, 1, 471);
            Quarterback scottTolzien = new Quarterback("Scott Tolzien", 16, Grouping.Offensive, 28, 213, 83.3, 1, 1, 0, 0, 4);

            WideReceiver jaredAbbrederis = new WideReceiver("Jared Abbrederis", 84, Grouping.Offensive, 25, 195, 69, 9, 111, 0);
            WideReceiver jeffJanis = new WideReceiver("Jeff Janis", 83, Grouping.Offensive, 24, 219, 71, 2, 79, 0);

            RunningBack johnCrockett = new RunningBack("John Crockett", 38, Grouping.Offensive, 23, 217, 68, 9, 21, 0);
            RunningBack johnKuhn = new RunningBack("John Kuhn", 30, Grouping.Offensive, 33, 250, 89, 9, 28, 2);


            //add to list
            var recruitAaronRogers = aaronRogers + greenBayPackers;
            var recruitAbbrederis = jaredAbbrederis + greenBayPackers;
            var recruitTolzien = scottTolzien + greenBayPackers;
            var recruitJanis = jeffJanis + greenBayPackers;
            var recruitCrockett = johnCrockett + greenBayPackers;
            var recruitKuhn = johnKuhn + greenBayPackers;
            greenBayPackers.ReadFile("../../GreenBayPackersRoster.txt");
            Console.WriteLine("Count: " + greenBayPackers.roster.playerList.Count);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("************");
            greenBayPackers.roster.PrintTopFive();

            //remove from list
            //var tradeAbbrederis = jaredAbbrederis - greenBayPackers;
            //Console.WriteLine(Environment.NewLine);
            //greenBayPackers.ReadFile("../../GreenBayPackersRoster.txt");

            Console.ReadLine();
        }
    }

}
