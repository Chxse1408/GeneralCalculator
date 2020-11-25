using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace QuadraticFormulaC
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CalcMenu();
        }

        private static void CalcMenu()
        {
            Console.Clear();
            bool runProgram = true;
            do
            {
                Console.WriteLine("\n\t1)Quadratic Formula calulator");
                Console.WriteLine("\t2)Addition/Subtraction calculator");
                Console.WriteLine("\t3)Quit?");
                Console.Write("\tChoose an option >> ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        QuadraticCalculator();
                        CalcMenu();
                        break;

                    case "2":
                        AddSubCalculator();
                        CalcMenu();
                        break;

                    case "3":
                        runProgram = true;
                        break;
                }
            } while (!runProgram);
        }

        private static void AddSubCalculator()
        {
            double userNumber = 0;
            bool done = false;
            do
            {
                Console.Clear();
                DisplayHeader("adding and subtracting calculator");
                Console.Write("\tWould you like to 'add' or 'subtract' or are you 'done'? ");
                string menuChoice = Console.ReadLine().ToUpper();

                if (menuChoice == "ADD")
                {
                    userNumber = DisplayAdditionCalc();
                }
                if (menuChoice == "SUBTRACT")
                {
                    userNumber = DisplaySubtractionCalc();
                }
                if (menuChoice == "DONE")
                {
                    done = true;
                }
            } while (!done);

            Console.WriteLine($"\n\tYour answer is {userNumber}");
            Console.WriteLine("\tpress any key to continue");
            Console.ReadKey();
        }

        private static double DisplayAdditionCalc()
        {
            double answer = 0;
            string userInput;

            DisplayHeader("Subtraction Calculator");

            Console.WriteLine("\tInput numbers that you would like to add. (Press enter between every entry)");
            Console.WriteLine("\tEnter 'DONE' when you are finished.");
            do
            {
                Console.Write("\t");
                userInput = Console.ReadLine().ToUpper();

                if (double.TryParse(userInput, out double userDouble))
                {
                    double oldAnswer = userDouble;
                    answer = oldAnswer + answer;
                }
            } while (userInput != "DONE");
            return answer;
        }

        private static double DisplaySubtractionCalc()
        {
            double answer = 0;
            string userInput;

            DisplayHeader("Subtraction Calculator");

            Console.WriteLine("\tInput numbers that you would like to add. (Press enter between every entry)");
            Console.WriteLine("\tEnter 'DONE' when you are finished.");
            do
            {
                Console.Write("\t");
                userInput = Console.ReadLine().ToUpper();

                if (double.TryParse(userInput, out double userDouble))
                {
                    double oldAnswer = userDouble;
                    answer = oldAnswer - answer;
                }
            } while (userInput != "DONE");
            return answer;
        }

        private static void QuadraticCalculator()
        {
            Console.Clear();
            double a, b, c, bx2, inside, ac, fourAc;

            Console.WriteLine("\n\tThe Quadratic Formula Calculator");
            Console.WriteLine("\n\tax2 + bx + c = 0");
            Console.Write("\n\tPlease give your 'a' coifficient >> ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\tPlease give your 'b' coifficient >> ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\tPlease give your 'c' coifficient >> ");
            c = Convert.ToDouble(Console.ReadLine());

            bx2 = b * b;
            ac = a * c;
            fourAc = 4 * ac;
            inside = bx2 - fourAc;

            Complex sq = Complex.Sqrt(inside); ;

            Complex c1 = -b + sq;
            Complex c2 = -b - sq;

            Console.WriteLine("\tx = " + c1 / (2 * a));
            Console.WriteLine("\tx = " + c2 / (2 * a));
            Console.ReadKey();
            CalcMenu();
        }

        #region tools

        private static void DisplayChooseAnOption()
        {
            Console.Write("\tChoose an option>> ");
        }

        private static void DisplayClosingScreen()
        {
            Console.Clear();
            DisplayHeader("Thank you for checking out my application!");
            DisplayContinuePrompt();
        }

        private static void DisplayContinuePrompt()
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine("\tpress enter to continue.");
            Console.ReadKey();
        }

        private static void DisplayHeader(string x)
        {
            Console.Clear();
            Console.WriteLine($"\n\t{x}");
        }

        private static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("\tHello, Welcome to the Finch robot application!");
            Console.WriteLine("\tThis application will show you a few things that the Finch can do.");
            DisplayContinuePrompt();
        }

        private static void DisplayIncorrectInput()
        {
            Console.Clear();
            Console.WriteLine("\n\tThat seems to be and incorrect input.");
            Console.WriteLine("\tPress any key to try again.");
            Console.ReadKey();
        }

        #endregion tools
    }
}