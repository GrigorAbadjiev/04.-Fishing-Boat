﻿using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishersCount = int.Parse(Console.ReadLine());

            double boatPrice;
            switch (season)
            {
                case "Spring": boatPrice = 3000; break;
                case "Winter": boatPrice = 2600; break ;
                case "Summer":
                case "Autumn":
                default:
                    boatPrice = 4200;
                    break;
               
            }
            if (fishersCount <= 6)
            {
                boatPrice *= 0.9;

            }
            else if (fishersCount <= 11)
            {
                boatPrice *= 0.85;
            }
            else
            {
                boatPrice *= 0.75;
            }
            if (fishersCount % 2 == 0 && season != "Autumn")
            {
                boatPrice *= 0.95;
            }
            if (boatPrice <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - boatPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {boatPrice - budget:f2} leva.");
            }
            
        }
       
    }
}
