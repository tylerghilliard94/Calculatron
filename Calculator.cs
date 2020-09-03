using System;

namespace calculator
{
    public class Calculator
    {

        public double Sum(double input1, double input2)
        {
            double inputSum = input1 + input2;
            return inputSum;
        }
        public double Sub(double input1, double input2)
        {
            double inputSub = input1 - input2;
            return inputSub;
        }
        public double Mult(double input1, double input2)
        {
            double inputMult = input1 * input2;
            return inputMult;
        }
        public double Div(double input1, double input2)
        {
            try
            {


                double inputDiv = input1 / input2;
                return inputDiv;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not Divide by zero. So here is a zero for your effort. Try again.");
                return 0;
            }

        }
        public double Square(double input1)
        {
            double inputSquare = input1 * input1;
            return inputSquare;
        }
        public double SquareRoot(double input1)
        {
            double inputSqr = Math.Sqrt(input1);
            return inputSqr;
        }
    }
}