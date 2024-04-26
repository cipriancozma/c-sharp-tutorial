Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");
string firstInput = Console.ReadLine();
int firstNumber = int.Parse(firstInput);

Console.WriteLine("Input the second number: ");
string secondInput = Console.ReadLine();
int secondNumber = int.Parse(secondInput);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubstract");
Console.WriteLine("[M]ultiply");
string userChoice = Console.ReadLine();

string userChoiceUppercased = userChoice.ToUpper();


void showResult(string input)
{
    if (input == "A")
    {
        Console.WriteLine(firstNumber + "+" + secondNumber + "=" + (firstNumber + secondNumber));
    }
    else if (input == "S")
    {
       Console.WriteLine(firstNumber + "-" + secondNumber + "=" + (firstNumber - secondNumber));
    }
    else if (input == "M")
    {
        Console.WriteLine(firstNumber + "*" + secondNumber + "=" + (firstNumber * secondNumber));
    } else
    {
        Console.WriteLine("Invalid option");
    }

}

showResult(userChoiceUppercased);