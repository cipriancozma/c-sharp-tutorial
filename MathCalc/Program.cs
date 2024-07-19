using static System.Console;

WriteLine("Welcome to Console Math Calc!");
var isFirstRun = true;
double firstNumber = 0;

var operators = new[] { "+", "-", "/", "%", "*", "=" };

while (true)
{
    if(isFirstRun)
    {
        WriteLine("Enter number: ");
        var firstInput = ReadLine();

        if (!double.TryParse(firstInput, out firstNumber))
        {
            WriteLine("Invalid number!");
            continue;   
        }
    }

    WriteLine($"The first number is: {firstNumber}");

    WriteLine("Enter second number: ");
    var secondInput = ReadLine();

    if(!double.TryParse(secondInput, out double secondNumber))
    {
        WriteLine("Invalid number!");
        continue;
    }

    WriteLine($"Second number is: {secondNumber}");

    WriteLine($"Enter operator: ({string.Join(",", operators)})");
    var mathOperator = ReadLine();

    if(!isOperatorValid(mathOperator))
    {
        WriteLine("Invalid operator!");
        continue;
    }
}

bool isOperatorValid(string mathOperator)
{
    foreach (var op in operators)
    {   
        if (op.Equals(mathOperator))
        {
            return true;
        }
    }
    return false;
}