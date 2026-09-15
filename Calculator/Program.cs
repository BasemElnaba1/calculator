Console.WriteLine("=== Simple Calculator ===");

bool continueCalculating = true;

while (continueCalculating)
{
    double firstNumber;

    while (true)
    {
        Console.Write("Enter first number: ");

        if (double.TryParse(Console.ReadLine(), out firstNumber))
        {
            break;
        }

        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    Console.Write("Enter operation (+, -, *, /): ");
    string? operation = Console.ReadLine();

    double secondNumber;

    while (true)
    {
        Console.Write("Enter second number: ");

        if (double.TryParse(Console.ReadLine(), out secondNumber))
        {
            break;
        }

        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    if (operation == "/" && secondNumber == 0)
    {
        Console.WriteLine("Error: Cannot divide by zero.");
    }
    else
    {
        double result = 0;

        switch (operation)
        {
            case "+":
                result = firstNumber + secondNumber;
                break;

            case "-":
                result = firstNumber - secondNumber;
                break;

            case "*":
                result = firstNumber * secondNumber;
                break;

            case "/":
                result = firstNumber / secondNumber;
                break;

            default:
                Console.WriteLine("Invalid operation.");
                continue;
        }

        Console.WriteLine($"Result: {result}");
    }

    Console.Write("Do you want another calculation? (y/n): ");
    string? answer = Console.ReadLine();

    if (answer?.ToLower() != "y")
    {
        continueCalculating = false;
    }

    Console.WriteLine();
}

Console.WriteLine("Calculator closed.");