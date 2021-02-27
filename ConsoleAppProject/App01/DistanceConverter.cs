using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will convert any unit (miles,feet,metres) to another.
    /// </summary>
    /// <author>
    /// Jose Gomes version 0.1
    /// </author>
    public class DistanceConverter
    {
        //units
        public const int FEET_IN_MILE = 5280;
        public const double METRES_IN_MILE = 1609.34;
        public const double FEET_IN_METRE = 3.28;

        //inputs
        string unitTo;
        string unitFrom;

        //output
        double result;

        //restart 
        bool quit = false;

        //Display Unit Multiple Choices 
        public void DisplayUnitChoices()
        {
            Console.WriteLine("+ Miles");
            Console.WriteLine("+ Feet");
            Console.WriteLine("+ Metres");
            Console.WriteLine("Please enter your choice:");
        }

        //ConvertDistances
        public void ConvertDistances()
        {
            //Keep console running until user decides to quit
            while (quit == false)
            {
                //Pick unit you want to convert from
                Console.WriteLine("\nConvert from:");
                DisplayUnitChoices();
                unitFrom = Console.ReadLine();

                if (unitFrom == "miles" || unitFrom == "feet" || unitFrom == "metres")
                {
                    Console.WriteLine("\nYou have selected {0}\n", unitFrom);
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid Input");
                    break;
                }

                //Pick unit you want to convert to
                Console.WriteLine("Convert to:");
                DisplayUnitChoices();
                unitTo = Console.ReadLine();

                if (unitTo == "miles" || unitTo == "feet" || unitTo == "metres")
                {
                    Console.WriteLine("\nYou have selected {0}\n", unitTo);
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid Input");
                    break;
                    
                }

                //Conversion 
                if (unitFrom == "miles" && unitTo == "feet") //miles to feet
                {
                    MilesToFeet();
                }
                else if (unitFrom == "miles" && unitTo == "metres") //miles to metres
                {
                    MilesToMetres();
                }
                else if (unitFrom == "feet" && unitTo == "miles") //feet to miles
                {
                    FeetToMiles();
                }
                else if (unitFrom == "feet" && unitTo == "metres") //feet to metres
                {
                    FeetToMetres();
                }
                else if (unitFrom == "metres" && unitTo == "miles") //metres to miles
                {
                    MetresToMiles();
                }
                else if (unitFrom == "metres" && unitTo == "feet") //metres to foot
                {
                    MetresToFoot();
                }
                Restart();
            }
        }

        //Restart
        public void Restart()
        {
            Console.WriteLine("\nDo you wish to restart? yes/no");
            string decision = Console.ReadLine();
            if (decision == "no")
            {
                quit = true;
            }
        }
        
        //Convert Miles To Feet
        public void MilesToFeet()
        {
            PrintInstructions();
            double value1 = Convert.ToDouble(Console.ReadLine());
            result = value1 * FEET_IN_MILE;
            Console.WriteLine("\n{0} miles is {1} feet", value1, result);
        }

        //Convert Miles To Metres
        public void MilesToMetres()
        {
            PrintInstructions();
            double value1 = Convert.ToDouble(Console.ReadLine());
            result = value1 * METRES_IN_MILE;
            Console.WriteLine("\n{0} miles is {1} metres", value1, result);
        }

        //Convert Feet to Miles
        public void FeetToMiles()
        {
            PrintInstructions();
            double value1 = Convert.ToDouble(Console.ReadLine());
            result = value1 / FEET_IN_MILE;
            Console.WriteLine("\n{0} feet is {1} miles", value1, result);
        }

        //Convert Feet to Metres
        public void FeetToMetres()
        {
            PrintInstructions();
            double value1 = Convert.ToDouble(Console.ReadLine());
            result = value1 / FEET_IN_METRE;
            Console.WriteLine("\n{0} feet is {1} metres", value1, result);
        }

        //Convert Metres to Miles
        public void MetresToMiles()
        {
            PrintInstructions();
            double value1 = Convert.ToDouble(Console.ReadLine());
            result = value1 / METRES_IN_MILE;
            Console.WriteLine("\n{0} metres is {1} miles", value1, result);
        }

        //Convert Metres to Foot
        public void MetresToFoot()
        {
            PrintInstructions();
            double value1 = Convert.ToDouble(Console.ReadLine());
            result = value1 * FEET_IN_METRE;
            Console.WriteLine("\n{0} metres is {1} feet", value1, result);
        }

        //Print Instructions 
        public void PrintInstructions()
        {
            Console.WriteLine("Converting {0} to {1}...", unitFrom, unitTo);
            Console.WriteLine("Enter distance in {0}:", unitFrom);
        }
    }
}
