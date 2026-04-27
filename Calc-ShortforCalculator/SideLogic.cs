namespace Calc_ShortforCalculator;

public enum CalculatorModeType
{
    Advanced,
    MultiLine
}

public class SideLogic
{
    public static void ExitAppMessage(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            string? userResponse = Console.ReadLine()?.ToLower();
            if (userResponse == "y") break;
            if (userResponse == "n") ExitApp();
            Console.WriteLine("Invalid response");
        }
    }

    public static void ExitApp()
    {
        Environment.Exit(0);
    }

    public static CalculatorModeType CalculatorMode(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            string? check = Console.ReadLine()?.Trim();
            
            if (string.Equals(check, "Advanced", StringComparison.OrdinalIgnoreCase))
                return CalculatorModeType.Advanced;

            if (string.Equals(check, "Multi-Line", StringComparison.OrdinalIgnoreCase) || string.Equals(check, "MultiLine", StringComparison.OrdinalIgnoreCase))
                return CalculatorModeType.MultiLine;
            
            Console.WriteLine("Please enter a valid mode");
        }
    }
}