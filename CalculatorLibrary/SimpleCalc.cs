using System;

namespace CalculatorLibrary
{
    public class SimpleCalc
    {

        public double addNumbers(double leftNumber, double rightNumber)
        {
            double result = double.NaN;
            result = leftNumber + rightNumber;
            return result;
        }

        public double substractNumbers(double leftNumber, double rightNumber)
        {
            double result = double.NaN;
            result = leftNumber - rightNumber;
            return result;
        }


        public double mulitplyNumbers(double leftNumber, double rightNumber)
        {
            double result = double.NaN;
            result = leftNumber * rightNumber;
            return result;
        }

        public double divideNumbers(double leftNumber, double rightNumber)
        {
            double result = double.NaN;
            if (rightNumber != 0)
            {
                result = leftNumber / rightNumber;
            }
            return result;
        }



        public double OperatorSwitch(double leftNumber, double rightNumber, string op)
        {

            double result = double.NaN;

            switch (op)
            {
                case "+":
                    result = addNumbers(leftNumber, rightNumber);
                    break;
                case "-":
                    result = substractNumbers(leftNumber, rightNumber);
                    break;
                case "*":
                    result = mulitplyNumbers(leftNumber, rightNumber);
                    break;
                case "/":
                    result = divideNumbers(leftNumber, rightNumber);
                    break;
                default:
                    break;
            }
            return result;
        }


    }
}
