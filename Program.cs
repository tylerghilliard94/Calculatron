using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1 = 0;
            double input2 = 0;
            double input3 = 0;
            bool inputCheck = false;
            int userInput = 0;
            string userInputConvert = "";
            Calculator Calculatron = new Calculator();
            while (inputCheck == false)
            {
                Console.WriteLine("Welcome to Calculatron!");
                Console.WriteLine("1) Add two numbers");
                Console.WriteLine("2) Subtract two numbers");
                Console.WriteLine("3) Multiply two numbers");
                Console.WriteLine("4) Divide two numbers");
                Console.WriteLine("5) Square one number");
                Console.WriteLine("6) Square root of a number");
                Console.WriteLine("7) Advanced: Write a simple equation (ex. 2 + 2)");
                Console.WriteLine("0) Exit");
                Console.WriteLine("");

                Console.Write("Choose an option: ");
                userInput = Int32.Parse(Console.ReadLine());
                if (userInput == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thanks for using Calculatron!");
                    inputCheck = true;
                }
                else if (userInput == 1)
                {
                    try
                    {
                        Console.Write("Please enter the numbers seperated by a space: ");
                        userInputConvert = Console.ReadLine();
                        input1 = double.Parse(userInputConvert.Split(" ")[0]);
                        input2 = double.Parse(userInputConvert.Split(" ")[1]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Incorrect input: Try again.");
                        Console.WriteLine("");
                        Console.Write("Please enter the numbers seperated by a space: ");
                        userInputConvert = Console.ReadLine();
                        input1 = double.Parse(userInputConvert.Split(" ")[0]);
                        input2 = double.Parse(userInputConvert.Split(" ")[1]);

                    }
                    double inputSum = Calculatron.Sum(input1, input2);

                    Console.WriteLine($"The result of adding {input1} and {input2} is {inputSum}");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();

                }
                else if (userInput == 2)
                {
                    try
                    {
                        Console.Write("Please enter the numbers seperated by a space: ");
                        userInputConvert = Console.ReadLine();
                        input1 = double.Parse(userInputConvert.Split(" ")[0]);
                        input2 = double.Parse(userInputConvert.Split(" ")[1]);





                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Incorrect input: Try again.");
                        Console.WriteLine("");
                        Console.Write("Please enter the numbers seperated by a space: ");
                        userInputConvert = Console.ReadLine();
                        input1 = double.Parse(userInputConvert.Split(" ")[0]);
                        input2 = double.Parse(userInputConvert.Split(" ")[1]);


                    }

                    double inputSub = Calculatron.Sub(input1, input2);

                    Console.WriteLine($"The result of subtraction {input1} and {input2} is {inputSub}");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (userInput == 3)
                {
                    try
                    {
                        Console.Write("Please enter the numbers seperated by a space: ");
                        userInputConvert = Console.ReadLine();
                        input1 = double.Parse(userInputConvert.Split(" ")[0]);
                        input2 = double.Parse(userInputConvert.Split(" ")[1]);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Incorrect input: Try again.");
                        Console.WriteLine("");
                        Console.Write("Please enter the numbers seperated by a space: ");
                        userInputConvert = Console.ReadLine();
                        input1 = double.Parse(userInputConvert.Split(" ")[0]);
                        input2 = double.Parse(userInputConvert.Split(" ")[1]);


                    }

                    double inputMult = Calculatron.Mult(input1, input2);

                    Console.WriteLine($"The result of multiplying {input1} and {input2} is {inputMult}");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (userInput == 4)
                {
                    try
                    {
                        Console.Write("Please enter the numbers seperated by a space: ");
                        userInputConvert = Console.ReadLine();
                        input1 = double.Parse(userInputConvert.Split(" ")[0]);
                        input2 = double.Parse(userInputConvert.Split(" ")[1]);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Incorrect input: Try again.");
                        Console.WriteLine("");
                        Console.Write("Please enter the numbers seperated by a space: ");
                        userInputConvert = Console.ReadLine();
                        input1 = double.Parse(userInputConvert.Split(" ")[0]);
                        input2 = double.Parse(userInputConvert.Split(" ")[1]);


                    }
                    double inputDiv = Calculatron.Div(input1, input2);

                    Console.WriteLine($"The result of dividing {input1} and {input2} is {inputDiv}");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (userInput == 5)
                {
                    try
                    {


                        Console.Write("Please enter the number to be squared: ");
                        userInputConvert = Console.ReadLine();
                        input3 = double.Parse(userInputConvert);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Incorrect input: Try again.");
                        Console.WriteLine("");
                        Console.Write("Please enter the number to be squared: ");
                        userInputConvert = Console.ReadLine();
                        input3 = double.Parse(userInputConvert);
                    }

                    double inputSquare = Calculatron.Square(input3);
                    Console.WriteLine($"The square of {input3} is {inputSquare}");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (userInput == 6)
                {
                    try
                    {


                        Console.Write("Please enter the number to get the square root of: ");
                        userInputConvert = Console.ReadLine();
                        input3 = double.Parse(userInputConvert);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Incorrect input: Try again.");
                        Console.WriteLine("");
                        Console.Write("Please enter the number to get the square root of: ");
                        userInputConvert = Console.ReadLine();
                        input3 = double.Parse(userInputConvert);
                    }

                    double inputSqr = Calculatron.SquareRoot(input3);
                    Console.WriteLine($"The square root of {input3} is {inputSqr}");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (userInput == 7)
                {
                    string op = "";
                    try
                    {


                        Console.Write("Please enter your equation with spaces between each number and the operators: ");
                        userInputConvert = Console.ReadLine();
                        input1 = double.Parse(userInputConvert.Split(" ")[0]);
                        input2 = double.Parse(userInputConvert.Split(" ")[2]);
                        op = userInputConvert.Split(" ")[1];
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Incorrect input: Try again.");
                        Console.WriteLine("");
                        Console.Write("Please enter your equation with spaces between each number and the operators: ");
                        userInputConvert = Console.ReadLine();
                        input1 = double.Parse(userInputConvert.Split(" ")[0]);
                        input2 = double.Parse(userInputConvert.Split(" ")[2]);
                        op = userInputConvert.Split(" ")[1];
                    }
                    double answer = 0;
                    if (op == "+")
                    {
                        answer = Calculatron.Sum(input1, input2);
                    }
                    else if (op == "-")
                    {
                        answer = Calculatron.Sub(input1, input2);
                    }
                    else if (op == "*")
                    {
                        answer = Calculatron.Mult(input1, input2);
                    }
                    else if (op == "/")
                    {
                        answer = Calculatron.Div(input1, input2);
                    }
                    Console.WriteLine($"The answer to your question is {answer}");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Incorrect Input: Try again!");
                    System.Threading.Thread.Sleep(3000);
                }
            }

        }
    }
}
