using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        //Number of students to be evaluated
        public const int NoStudents = 10;
        //Grades Marking Values
        public const int LowestGradeF = 0;
        public const int LowestGradeD = 40;     
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        //Students, Marks Arrays
        public string[] Students { get; set; }
        public int[] Marks { get; set; }

        //Variables to Store the Minimum, Mean and Maximum Mark
        public double Mean = 0;
        public int Minimum = 0;
        public int Maximum = 0;

        //Declares Students Names and the Lenght of the Marks Array
        public StudentGrades()
        {
            Students = new string[NoStudents]
            {
                "Jose","Mario","Grace","Jessica","Matt","Carolina","Natalie","Fabio","Diogo","Jeremy"
            };
            Marks = new int[Students.Length];
        }

        //Insert Student Marks
        public void InputMarks()
        {
            int mark, index = 0;

            Console.WriteLine();

            foreach (string student in Students)
            {
                Console.Write("Please enter a mark for {0} ", student);
                mark = Convert.ToInt32(Console.ReadLine());
                Marks[index] = mark;
                index++;
            }

            Console.WriteLine();
        }

        //Display Marks and Grades
        public void OutputMarksGrades()
        {
            Console.WriteLine("\nListing of Student Marks\n"); 
            for (int index = 0; index < NoStudents; index++)
            {
                if(Marks[index] >= LowestGradeA)
                {
                    Console.WriteLine("{0} scored {1} || A - First Class", Students[index], Marks[index]);
                }
                else if(Marks[index] >= LowestGradeB)
                {
                    Console.WriteLine("{0} scored {1} || B - Upper Second Class", Students[index], Marks[index]);
                }
                else if (Marks[index] >= LowestGradeC)
                {
                    Console.WriteLine("{0} scored {1} || C - Lower Second Class", Students[index], Marks[index]);
                }
                else if (Marks[index] >= LowestGradeD)
                {
                    Console.WriteLine("{0} scored {1} || D - Third Class", Students[index], Marks[index]);
                }
                else if (Marks[index] >= LowestGradeF)
                {
                    Console.WriteLine("{0} scored {1} || F - Fail", Students[index], Marks[index]);
                }
            }
            Console.WriteLine();
        }
        //Display Student Grades Heading
        public void DisplayHeading()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("        Students  Grades");
            Console.WriteLine("         by Jose Gomes");
            Console.WriteLine("-----------------------------------\n");
        }

        //Display App03 Choices
        public void DisplayChoices()
        {
            Console.WriteLine("1. Mark Students");
            Console.WriteLine("2. List Students (Mark and Grade)");
            Console.WriteLine("3. Show Minimum, Mean and Maximum Mark");
            Console.WriteLine("4. Show Grades Percentages");
            Console.WriteLine("0. Quit");
        }

        //Show Minimum, Mean and Maximum Marks
        public void MinMeanMaxMark()
        {
            for (int index = 0; index < NoStudents; index++)
            {
                if (Marks[index] > Maximum)
                {
                    Maximum = Marks[index];
                }
                else if (Marks[index] < Minimum)
                {
                    Minimum = Marks[index];
                }
                    Mean += Marks[index];
            }

            Mean /= NoStudents;

            Console.WriteLine("\nMinimum Mark:{0} || Maximum Mark:{1} || Mean Mark:{2}\n", Minimum, Maximum, Mean);
        }

        //Calculate Every Grade Percentage
        public void GradePercentages()
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            int F = 0;

            for (int index = 0; index < NoStudents; index++)
            {
                if (Marks[index] >= LowestGradeA)
                {
                    A += 1;
                }
                else if (Marks[index] >= LowestGradeB)
                {
                    B += 1;
                }
                else if (Marks[index] >= LowestGradeC)
                {
                    C += 1;
                }
                else if (Marks[index] >= LowestGradeD)
                {
                    D += 1;
                }
                else if (Marks[index] >= LowestGradeF)
                {
                    F += 1;
                }               
            }

            A *= 10;
            B *= 10;
            C *= 10;
            D *= 10;
            F *= 10;

            Console.WriteLine("\nIndividual Grade Percentages:");
            Console.WriteLine("\nA:{0}% B:{1}% C:{2}% D:{3}% F{4}%\n", A,B,C,D,F);
        }

        //User Selects What To Do
        public void UserChoice()
        {
            DisplayHeading();
            DisplayChoices();

            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                InputMarks();
            }
            else if(choice == 2)
            {
                OutputMarksGrades();
            }
            else if(choice == 3)
            {
                MinMeanMaxMark();
            }
            else if(choice == 4)
            {
                GradePercentages();
            }
            else if(choice == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nInvalid Input\n");
            }
            UserChoice();
        }
    }
}
