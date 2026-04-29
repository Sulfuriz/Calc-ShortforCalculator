# Calc (Short for Calculator)

A simple console-based calculator application written in C#. The project is just for me to learn a bit more C#.

## Features

- **Advanced Mode**: (Placeholder for future more advanced features such as one line operations and BIDMAS)
- **Multi-Line Mode**: Perform calculations by entering numbers and operators step-by-step.

## Getting Started

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later

### Running the Application

1. Clone the repository or download the source code.
2. Open a terminal and navigate to the project directory or open terminal in directory
3. Build and run the application:

   ```sh
   dotnet run --project Calc-ShortforCalculator/Calc-ShortforCalculator.csproj

Follow the on-screen prompts to use the calculator.

### Project Structure

- Program.cs: Handles user interaction and calculator mode selection.
- ExtendedLogic.cs: Contains logic for calculations and operator handling.
- SideLogic.cs: Handles mode selection and exit prompts.

---

#### Example usage - Multi-Line
-----Calc (Short for Calculator)-----   
Advanced or Multi-Line Calculator? Enter 'Advanced' or 'Multi-Line'  
Multi-Line  
Multi-Line mode active  
Enter a number.  
5  
Enter an operator. +, -, *, /, %  
*  
Enter a number  
3  
The result is 15  
Another sum? enter y or n  

#### Example usage - Advanced
-----Calc (Short for Calculator)-----   
Advanced or Multi-Line Calculator? Enter 'Advanced' or 'Multi-Line'  
Advanced   
Advanced mode active   
Enter a sum such as 5+3 or 10 - 2
7 * 7   
The result is 49   
Another sum? enter y or n  

---

## Upcoming Features

- BIDMAS
- Simple GUI
