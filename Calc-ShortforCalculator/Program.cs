using Calc_ShortforCalculator;

Console.WriteLine("-----Calc (Short for Calculator)-----");

while (true)
{
    var mode = SideLogic.CalculatorMode("Advanced or Multi-Line Calculator? Enter 'Advanced' or 'Multi-Line'");

    switch (mode)
    {
        case CalculatorModeType.Advanced:
            Console.WriteLine("Advanced mode active");
            break;
        case CalculatorModeType.MultiLine:
            Console.WriteLine("Multi-Line mode active");
            bool sumShown = false;

            double number1 = ExtendedLogic.CalculateMultiLine("Enter a number.");
            string mathOperator = ExtendedLogic.GetMathOperator("Enter an operator. +, -, *, /, %");
            double number2 = ExtendedLogic.CalculateMultiLine("Enter a number");
    
            if ((mathOperator == "/" || mathOperator == "%") && number2 == 0)
                Console.WriteLine("Cannot divide/mod by zero");
            else
            {
                double sum = ExtendedLogic.Calculate(number1, number2, mathOperator);
                Console.WriteLine($"The result is {sum}");
                sumShown = true;
            }

            if (sumShown)
                SideLogic.ExitAppMessage("Another sum? enter y or n");
            break;
    }

    
}