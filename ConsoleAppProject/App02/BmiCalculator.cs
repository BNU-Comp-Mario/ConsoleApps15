using System;
using System.Text;
using System.Collections.Generic;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Jose Gomes 10/03/2021
    /// </author>
    public class BmiCalculator
    {
        string unitChoice;

        double heightMetres;
        int heightCentimetres;
        double weightKilos;
        int weightGrams;
        int heightFeet;
        int heightInches;
        int weightPounds;
        int weightStones;

        double metricBmiResult;
        int imperialBmiResult;

        public void DisplayHeading()
        { 
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("    Body Mass Index Calculator");
            Console.WriteLine("         by Jose Gomes");
            Console.WriteLine("-----------------------------------");
        }

        public void SelectUnits()
        {
            Console.WriteLine("Please select between the following units:");
            Console.WriteLine("Metric || Imperial");
            unitChoice = Console.ReadLine();
        }

        public void BameWarningHeading()
        {
            Console.WriteLine("\nIf you are Black, Asian or other minority ethnic groups, you have a higher risk:\n");
            Console.WriteLine("Adults 23.0 or more are at increased risk!");
            Console.WriteLine("Adults 27.5 or more are at high risk!");
        }

        public void MetricHeightHeading()
        {
            Console.WriteLine("\nEnter your height in metres and centimetres:\n");
            Console.WriteLine("Enter your height in metres:");
            heightMetres = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in centimetres:");
            heightCentimetres = Convert.ToInt32(Console.ReadLine());
        }

        public void MetricWeightHeading()
        {
            Console.WriteLine("\nEnter your weight in kilos and grams:");
            Console.WriteLine("Enter your height in kilos:");
            weightKilos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in grams:");
            weightGrams = Convert.ToInt32(Console.ReadLine());
        }

        public void ImperialWeightHeading()
        {
            Console.WriteLine("\nEnter your weight in stones and pounds:");
            Console.WriteLine("Enter your height in stones:");
            weightStones = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your height in pounds:");
            weightPounds = Convert.ToInt32(Console.ReadLine());
        }

        public void ImperialHeightHeading()
        {
            Console.WriteLine("\nEnter your height in feet and inches:\n");
            Console.WriteLine("Enter your height in feet:");
            heightMetres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your height in inches:");
            heightCentimetres = Convert.ToInt32(Console.ReadLine());
        }

       public void CalculateMetricBmi()
        {
            metricBmiResult = weightKilos / (heightMetres * heightMetres);
        }

        public void CalculateImperialBmi()
        {
            imperialBmiResult = (weightPounds * 703) / (heightInches * heightInches);
        }

        //resultados
        public void MetricBmiResults()
        {
            if (metricBmiResult < 18.50)
            {
                Console.WriteLine("Your BMI is {0}. You are Underweight!", metricBmiResult);
            }
            else if (metricBmiResult > 18.5 && metricBmiResult < 24.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Normal!", metricBmiResult);
            }
            else if (metricBmiResult > 25.0 && metricBmiResult < 29.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Overweight!", metricBmiResult);
            }
            else if (metricBmiResult > 30.0 && metricBmiResult < 34.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class I", metricBmiResult);
            }
            else if (metricBmiResult > 35.0 && metricBmiResult < 39.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class II", metricBmiResult);
            }
            else if (metricBmiResult >= 40)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class III", metricBmiResult);
            }
            else
            {
                Console.WriteLine("Error: Invalid Data");
            }
        }
        public void BmiCalculation()
        {
            DisplayHeading();
            SelectUnits();

            if(unitChoice == "metric")
            {
                MetricHeightHeading();
                MetricWeightHeading();
                CalculateMetricBmi();
                MetricBmiResults();
                BameWarningHeading();
            }
            else if(unitChoice == "imperial")
            {
                ImperialHeightHeading();
                CalculateImperialBmi();
            }
            else
            {
                Console.WriteLine("ero");
            }

        }

        //
        //
        //
        //
        //
    }

}
