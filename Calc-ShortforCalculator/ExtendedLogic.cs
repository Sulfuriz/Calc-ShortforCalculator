namespace Calc_ShortforCalculator;

public class ExtendedLogic
{
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
}