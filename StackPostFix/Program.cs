using System;
using System.Collections;
using System.Collections.Generic;

//namespace StackPostFix
class PostfixCalculator
{
    public static double EvaluatePostfix(string expression)
    {
        Stack stack = new Stack();

        string[] tokens = expression.Split(' ');

        foreach (string token in tokens)
        {
            if (double.TryParse(token, out double operand))
            {
                stack.Push(operand);
            }
            else
            {
                double operand2 = (double)stack.Pop();
                double operand1 = (double)stack.Pop();

                switch (token)
                {
                    case "+":
                        stack.Push(operand1 + operand2);
                        break;
                    case "-":
                        stack.Push(operand1 - operand2);
                        break;
                    case "*":
                        stack.Push(operand1 * operand2);
                        break;
                    case "/":
                        stack.Push(operand1 / operand2);
                        break;
                    default:
                        throw new ArgumentException("Invalid operator: " + token);
                }
            }
        }

        return (double)stack.Pop();
    }

    static void Main()
    {
        //string postfixExpression = "5 3 + 8 *";

        Console.Write("Enter a number: ");
        string postfixExpression = Console.ReadLine();
        double result = EvaluatePostfix(postfixExpression);
        Console.WriteLine("Result: " + result);
    }
}