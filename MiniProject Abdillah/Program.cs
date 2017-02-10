using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_Abdillah
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            int insertPlanet;
            double insertWeight;
            string planet;
            double weight;

            do
            {
                Console.Clear();

                // Set menu
                Console.WriteLine("         Menu of Planets          ");
                Console.WriteLine("         ==== == =======          ");
                Console.WriteLine("1. Jupiter   2. Mars    3. Mercury");
                Console.WriteLine("4. Neptune   5. Pluto   6. Saturn ");
                Console.WriteLine("7. Uranus    8. Venus   9. <Quit> ");
                Console.WriteLine(); //Empty Lines

                //Input validation
                Console.WriteLine("Enter your menu selection:");
                int.TryParse(Console.ReadLine(), out insertPlanet);
                Console.WriteLine();

            }
            while (insertPlanet > 9 || insertPlanet < 1);//To make sure it restarts after 9 and before 1

            switch (insertPlanet)
            {
                case 1:
                    Console.WriteLine("You Chose Jupiter");
                    break;
                case 2:
                    Console.WriteLine("You Chose Mars");
                    break;
                case 3:
                    Console.WriteLine("You Chose Mercury");
                    break;
                case 4:
                    Console.WriteLine("You Chose Neptune");
                    break;
                case 5:
                    Console.WriteLine("You Chose Pluto");
                    break;
                case 6:
                    Console.WriteLine("You Chose Saturn");
                    break;
                case 7:
                    Console.WriteLine("You Chose Uranus");
                    break;
                case 8:
                    Console.WriteLine("You Chose Venus");
                    break;
                case 9:
                    Environment.Exit(0);//to Quit when you press 9
                    break;
            }

            //Input validation
            Console.WriteLine("Enter your weight on earth:");
            double.TryParse(Console.ReadLine(), out insertWeight);
            Console.WriteLine();

            //Use switch statements to set planet and weight
            switch (insertPlanet)
            {
                case 1:
                    planet = "Jupiter";
                    weight = insertWeight * 2.64;
                    Console.WriteLine("Your weight of {0} lbs on Earth would be {1:#.#} lbs on {2}.", insertWeight, weight, planet);
                    Console.WriteLine();
                    break;
                case 2:
                    planet = "Mars";
                    weight = insertWeight * 0.38;
                    Console.WriteLine("Your weight of {0} lbs on Earth would be {1.#.#} lbs on {2}.", insertWeight, weight, planet);
                    Console.WriteLine();
                    break;
                case 3:
                    planet = "Mercury";
                    weight = insertWeight * 0.37;
                    Console.WriteLine("Your weight of {0} lbs on Earth would be {1:#.#} lbs on {2}.", insertWeight, weight, planet);
                    Console.WriteLine();
                    break;
                case 4:
                    planet = "Neptune";
                    weight = insertWeight * 1.12;
                    Console.WriteLine("Your weight of {0} lbs on Earth would be {1:#.#} lbs on {2}.", insertWeight, weight, planet);
                    Console.WriteLine();
                    break;
                case 5:
                    planet = "Pluto";
                    weight = insertWeight * 0.04;
                    Console.WriteLine("Your weight of {0} lbs on Earth would be {1:#.#} lbs on {2}.", insertWeight, weight, planet);
                    Console.WriteLine();
                    break;
                case 6:
                    planet = "Saturn";
                    weight = insertWeight * 1.15;
                    Console.WriteLine("Your weight of {0} lbs on Earth would be {1:#.#} lbs on {2}.", insertWeight, weight, planet);
                    Console.WriteLine();
                    break;
                case 7:
                    planet = "Uranus";
                    weight = insertWeight * 1.15;
                    Console.WriteLine("Your weight of {0} lbs on Earth would be {1:#.#} lbs on {2}.", insertWeight, weight, planet);
                    Console.WriteLine();
                    break;
                case 8:
                    planet = "Venus";
                    weight = insertWeight * 0.88;
                    Console.WriteLine("Your weight of {0} lbs on Earth would be {1:#.#} lbs on {2}.", insertWeight, weight, planet);
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
            //Keep the console window open (only for debug)
            Console.WriteLine("Press Any Key To exit.");
            Console.ReadKey();

        }
    }
}
