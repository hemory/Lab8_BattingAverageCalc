using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Batting
{
    public class Program
    {
        static void Main(string[] args)
        {
            string toContinue;
            do
            {
                Console.WriteLine("Welcome to Batting Average Calculator!");
                Console.WriteLine("Enter number of hits at bat: ");

                int timesWantToHit = Convert.ToInt32(Console.ReadLine());

                int[] hittingResults = new int[timesWantToHit];
                int hit = 1;
                for (int i = 0; i < timesWantToHit; i++)
                {
                    Console.WriteLine("How many bases did you score on hit #" + hit + " ?");
                    Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = homerun ");
                    hittingResults[i] = Convert.ToInt32(Console.ReadLine());
                   
                    {
                    }
                    hit++;
                }
                Console.WriteLine("Batting average:" + calculateBattingAverage(hittingResults));
                Console.WriteLine("Slugging percentage:" + calculateSluggingPercentage(hittingResults));

                Console.WriteLine("Would you like to calculate another average? y/n ");
                toContinue = Console.ReadLine();
            } while (toContinue == "y");
        }


        //These are methods
        public static double calculateBattingAverage(int[] battingSheet)
        {

            double numerator = 0;

            for (int index = 0; index < battingSheet.Length; index++)
            {
                if (battingSheet[index] > 0)

                    numerator = numerator + 1;
            }
            return (double)numerator / battingSheet.Length;
        }

        public static double calculateSluggingPercentage(int[] battingSheet)

        {
            int numberofBases = battingSheet.Sum();
            
            return (double)numberofBases / battingSheet.Length;
        }

    }
    
}




