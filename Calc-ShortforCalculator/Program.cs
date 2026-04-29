using Calc_ShortforCalculator;

Console.WriteLine("-----Calc (Short for Calculator)-----");

while (true)
{
    var mode = SideLogic.CalculatorMode("Advanced or Multi-Line Calculator? Enter 'Advanced' or 'Multi-Line'");

    switch (mode)
    {
        case CalculatorModeType.Advanced:
            Console.WriteLine("Advanced mode active");
            ExtendedLogic.CalculateAdvanced("Enter a sum such as 5+3 or 10 - 2");
            SideLogic.ExitAppMessage("Another sum? enter y or n");
            break;
        
        case CalculatorModeType.MultiLine:
            Console.WriteLine("Multi-Line mode active");
            ExtendedLogic.CalculateMultiLine();
            SideLogic.ExitAppMessage("Another sum? enter y or n");
            break;
    }

    
}