using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Jose Gomes 25/02/2021
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();

            ConsoleHelper.DisplayHeading();

                //Display Choices
                Console.WriteLine("Input the number of the app you wish to run, ex: 1");
                int choice = Convert.ToInt32(Console.ReadLine());

                App01.DistanceConverter converter = new App01.DistanceConverter();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n--------------App01 Convert Distances--------------");
                        converter.ConvertDistances();
                        break;
                    case 2:
                        Console.WriteLine("----------------App02 BMI Calculator---------------\n");
                        //app02
                        break;
                    case 3:
                        Console.WriteLine("----------------App03 Student Marks----------------\n");
                        //app03
                        break;
                    case 4:
                        Console.WriteLine("----------------App04 Social Network---------------\n");
                        //app04
                        break;
                    case 5:
                         Console.WriteLine("---------------App05 Game Images------------------\n");
                         //app04
                        break;
                default:
                        Console.WriteLine("ERROR: Invalid Input");
                        break;
                }
        }
    }
}
