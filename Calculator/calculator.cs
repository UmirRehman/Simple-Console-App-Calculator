using System;
using System.Globalization;

namespace calculator
{
    class calc
    {
        static void Main(string[] args)
        {
            void calculationLoop()
            {
                string operation;
                string firstNum;
                double num1;

                string secondNum;
                double num2;

                double finalCalc = 0;

                void chooseNumbers()
                {
                    // Choosing first number
                    bool wrongInput = false;
                    while (true)
                    {
                        if (wrongInput == false)
                        {
                            Console.Write("Enter the first number: ");
                        }
                        else
                        {
                            Console.Write("Wrong input. Enter a number: ");
                        }

                        firstNum = Console.ReadLine();
                        bool isNumber = double.TryParse(firstNum, out num1);

                        if (isNumber == true)
                        {
                            break;
                        }

                        wrongInput = true;
                    }

                    // Choosing second number
                    bool wrongInput2 = false;
                    while (true)
                    {
                        if (wrongInput2 == false)
                        {
                            Console.Write("Enter the second number: ");
                        }
                        else
                        {
                            Console.Write("Wrong input. Enter a number: ");
                        }

                        secondNum = Console.ReadLine();
                        bool isNumber = double.TryParse(secondNum, out num2);

                        if (isNumber == true)
                        {
                            break;
                        }
                        wrongInput2 = true;
                    }
                }

                void chooseOperator()
                {
                    bool wrongInput = false;
                    while (true)
                    {

                        if (wrongInput == false)
                        {
                            Console.WriteLine("Enter the operation would you like to perform: + , - , * , / .");
                            operation = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Wrong input. Enter a valid operator: ");
                            operation = Console.ReadLine();
                        }

                        if (operation == "+" ^ operation == "-" ^ operation == "*" ^ operation == "/")
                        {
                            break;
                        }

                        wrongInput = true;
                    }

                    chooseNumbers();

                }

                chooseOperator();

                if (operation == "+")
                {
                    finalCalc = num1 + num2;
                }
                else if (operation == "-")
                {
                    finalCalc = num1 - num2;
                }
                else if (operation == "*")
                {
                    finalCalc = num1 * num2;
                }
                else if (operation == "/")
                {
                    finalCalc = num1 / num2;
                }

                Console.WriteLine($"\n{firstNum} {operation} {secondNum} = {finalCalc}");
            }

            void restart()
            {

                while (true)
                {
                    Console.WriteLine("\nType 'yes' to do another calculation.");
                    string response = Console.ReadLine();

                    if (response == "yes")
                    {
                        break;
                    }
                }    
            }

            while (true)
            {
                calculationLoop();
                restart();
            }
        }
    }
}

