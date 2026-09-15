Console.WriteLine("=== Simple Calculator ===");

bool continueCalculating = true;

while (continueCalculating)
{
    Console.Write("Enter first number: ");
    double firstNumber = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter operation (+, -, *, /): ");
    string? operation = Console.ReadLine();

    Console.Write("Enter second number: ");
    double secondNumber = Convert.ToDouble(Console.ReadLine());

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

    Console.Write("Do you want another calculation? (y/n): ");
    string? answer = Console.ReadLine();

    if (answer?.ToLower() != "y")
    {
        continueCalculating = false;
    }

    Console.WriteLine();
}

Console.WriteLine("Calculator closed.");