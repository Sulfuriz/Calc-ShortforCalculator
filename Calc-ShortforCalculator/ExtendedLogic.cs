using System.Text.RegularExpressions;

namespace Calc_ShortforCalculator;

public class ExtendedLogic
{
    public static void CalculateAdvanced(string message)
    {
        Console.WriteLine(message);
        string? input = Console.ReadLine();
        input = input.Replace(" ", "");
        
        var check = Regex.Match(input, @"^(-?\d+(\.\d+)?)([+\-*/%])(-?\d+(\.\d+)?)$");

        if (check.Success)
        {
            double number1 = double.Parse(check.Groups[1].Value);
            string operatorSymbol = check.Groups[3].Value;
            double number2 = double.Parse(check.Groups[4].Value);

            double sum = operatorSymbol switch
            {
                "+" => number1 + number2,
                "-" => number1 - number2,
                "*" => number1 * number2,
                "/" => number2 != 0 ? number1 / number2 : throw new DivideByZeroException(),
                "%" => number2 != 0 ? number1 % number2 : throw new DivideByZeroException(),
                _ => throw new InvalidOperationException("Something went wrong. Try again")
            };
            Console.WriteLine($"The result is {sum}");
            return;
        }
        Console.WriteLine("Invalid input");
    }
    
    public static double CalculateMultiLine(string message)
    {
        double number;
        while (true)
        {
            Console.WriteLine(message);
            if (double.TryParse(Console.ReadLine(), out number)) return number;
            Console.WriteLine("Invalid input");
        }
    }
    

    public static string GetMathOperator(string mathOperator)
    {
        while (true)
        {
            Console.WriteLine(mathOperator);
            string? input = Console.ReadLine()?.ToLower();

            switch (input)
            {
                case "+":
                case "plus":
                case "add":
                    return "+";
                
                case "-":
                case "minus":
                case "subtract":
                    return "-";
                
                case "*":
                case "multiply":
                case "times":
                    return "*";
                
                case "/":
                case "divide":
                    return "/";
                
                case "%":
                case "mod":
                    return "%";
                
                case "toot":
                    return "toot";
                
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    public static double Calculate(double number1, double number2, string mathOperator)
    {
        return mathOperator switch
        {
            "+" => number1 + number2,
            "-" => number1 - number2,
            "*" => number1 * number2,
            "/" => number1 / number2,
            "%" => number1 % number2,
            "toot" => TootHelper(number1, number2),
            _ => throw new ArgumentException("Something went wrong. Try again")
        };
    }

    private static readonly Random Rand = new Random();
    
    private static double TootHelper(double number1, double number2)
    {
        var operatorList = new List<Func<double, double, double>>
        {
            (a, b) => a + b,
            (a, b) => a - b,
            (a, b) => a * b,
            (a, b) => a / b,
            (a, b) => a % b,
        };
        
        int randNum = Rand.Next(operatorList.Count);
        return operatorList[randNum](number1, number2);
    }

    public static void CalculateMultiLine()
    {
        double number1 = CalculateMultiLine("Enter a number.");
        string mathOperator = GetMathOperator("Enter an operator. +, -, *, /, %");
        double number2 = CalculateMultiLine("Enter a number");
    
        if ((mathOperator == "/" || mathOperator == "%") && number2 == 0)
            Console.WriteLine("Cannot divide/mod by zero");
        else
        {
            double sum = Calculate(number1, number2, mathOperator);
            Console.WriteLine($"The result is {sum}");
        }
    }
}